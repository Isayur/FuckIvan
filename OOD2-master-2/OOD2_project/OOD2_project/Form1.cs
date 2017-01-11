using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;

namespace OOD2_project
{
    public partial class Form1 : Form
    {
        List<Point> pointsList;
        private Image selectedImage;
        private string selectedComponent;
        private bool isSelected = false; //To show that there is a selected component..
        public Network network;
        private Point point;
        private Component startComponent;
        private Component endComponent;
        private Adjustable_Spliter adjSpliter;
        Connection con;
        private Point[] points;
        private bool pipeActivate;

        public Form1()
        {
            InitializeComponent();
            pointsList = new List<Point>();
            this.network = new Network(workPanel.Height, workPanel.Width);
            this.tbCurrentFlow.Text = "0";
            this.tbMaxFlow.Text = "0";
        }

        private void workPanel_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        //Drawing the component on the workPanel..
        private void workPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            if (isSelected)
            {
                
                switch (selectedComponent)
                {
                    case "pump":   // CUrrent flow added...
                        if (tbCurrentFlow.Text == "" && tbMaxFlow.Text == "")
                        {
                            MessageBox.Show("Please enter the current and max flow");
                        }
                        else if (Convert.ToInt32(tbCurrentFlow.Text) < 0 && Convert.ToInt32(tbMaxFlow.Text) < 0)
                        {
                            MessageBox.Show("Current and Max flow must be positive integers");
                        }
                        else
                        {
                            if (!this.network.checkOverlap(point))
                            {

                                this.network.listComponents.Add(new Pump(selectedImage, (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width)), point, Convert.ToInt32(tbCurrentFlow.Text)));

                            }
                            else
                                MessageBox.Show("Components cannot overlap!");
                        }
                        break;
                    case "adjSpliter":
                        trackBar1.Visible = true;
                        btSet.Visible = true;
                        lbPrc.Visible = true;
                        if (!this.network.checkOverlap(point))
                        {
                            this.adjSpliter = new Adjustable_Spliter(selectedImage, (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width)), point);
                            this.network.listComponents.Add(adjSpliter);
                            isSelected = false;
                        }
                        else
                            MessageBox.Show("Components cannot overlap!");
                        break;
                    case "spliter":
                        if (!this.network.checkOverlap(point))
                        {
                            this.network.listComponents.Add(new Spliter(selectedImage, (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width)), point));
                        }
                        else
                            MessageBox.Show("Components cannot overlap!");
                        break;
                    case "merger":
                        if (!this.network.checkOverlap(point))
                        {
                            this.network.listComponents.Add(new Merger(selectedImage, (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width)), point));
                        }
                        else
                            MessageBox.Show("Components cannot overlap!");
                        break;
                    case "sink":
                        if (!this.network.checkOverlap(point))
                        {
                            this.network.listComponents.Add(new Sink(selectedImage, (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width)), point));
                        }
                        else
                            MessageBox.Show("Components cannot overlap!");
                        break;
                    //case "pipe":
                    //    //this.network.listConnections.Add(new Connection(startComponent, endComponent, Convert.ToInt32(tbCurrentFlow.Text),Convert.ToInt32(tbMaxFlow),points));
                    //    break;
                }
                foreach(Component com in this.network.listComponents)
                {
                    // foreach loop to draw
                    if(com is Pump)
                        com.DrawComponent(gr);
                    else
                        com.DrawComponent(gr);
                }
                foreach (Connection c in this.network.listConnections)
                {
                   
                        c.DrawConnection(gr);
                }
            }
            if (pipeActivate && endComponent != null)
            {
                if(con != null)
                    con.DrawConnection(gr);
                pointsList = new List<Point>();
                startComponent = null;
                endComponent = null;
                pipeActivate = false;
            }
            this.network.panelHeight = Convert.ToInt32(this.workPanel.Size.Height);
            this.network.panelWidth = Convert.ToInt32(this.workPanel.Size.Width);

        }
        private void pbPump_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbPump.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbPump.Image;
            selectedComponent = "pump";
            pbPump.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
        }

        private void pbSink_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbPump.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbSink.Image;
            selectedComponent = "sink";
            pbPump.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;            
        }

        private void pbAdjustableSpliter_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbPump.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbAdjustableSpliter.Image;
            selectedComponent = "adjSpliter";
            pbPump.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
        }

        private void pbSpliter_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbPump.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbSpliter.Image;
            selectedComponent = "spliter";
            pbPump.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
        }

        private void pbMerger_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbPump.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbMerger.Image;
            selectedComponent = "merger";
            pbPump.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
            
        }

        private void pbPipe_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbPump.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbPipe.Image;
            selectedComponent = "pipe";
            pbPump.DoDragDrop(selectedImage, DragDropEffects.Copy);
            pipeActivate = true;
        }

        private void workPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //Checks where the client clicks on the workPanel and add the point to the listComponent..
        private void workPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedImage != null)
            {
                point = workPanel.PointToClient(new Point(e.X, e.Y));
                this.workPanel.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.workPanel.AllowDrop = true;
        }

        private void pbPump_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbPump.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }

        private void pbSink_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbSink.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }

        private void pbAdjustableSpliter_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbAdjustableSpliter.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
            //trackBar1.Visible = true;
            
        }

        private void pbSpliter_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbSpliter.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }

        private void pbMerger_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbMerger.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }

        private void pbPipe_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbPipe.BorderStyle = BorderStyle.None;
        }

        //Checks where the user click..
        private void workPanel_MouseClick(object sender, MouseEventArgs e)
        {
            //The point where the user click
            Point p = new Point(e.X, e.Y); 

            if (pipeActivate)
            {
                if (startComponent == null || endComponent == null)
                {
                    this.addConnectionPoints(p);
                }
               
            }
            if (e.Button == MouseButtons.Right)
            {
                if (this.network.listComponents.Count >= 1 && this.network.getComponent(p) != null)
                {
                    
                         MenuItem[] menuItems = new MenuItem[2];
                        menuItems[0] = new MenuItem("Remove Connection(s)");
                        menuItems[1] = new MenuItem("Remove Component");
                        ContextMenu buttonMenu = new ContextMenu(menuItems);
                        buttonMenu.Show(workPanel, new System.Drawing.Point(p.X, p.Y));
                        menuItems[0].Click += new EventHandler((obj, evargs) => menuItem_click(obj, evargs, p, menuItems));
                        menuItems[1].Click += new EventHandler((obj, evargs) => menuItem_click(obj, evargs, p, menuItems));
             
                  }
            }
          
        }

        public void menuItem_click(object sender, EventArgs e, Point point, MenuItem[] menuItems)
        {
            //MenuItem Delete Connection from the list with connections
            if (sender == menuItems[0])
            {
              
            }
            //MenuItem Delete Component form the list with components
            if (sender == menuItems[1])
            {
                //MUST BE FIXED !!!!!
              this.network.RemoveComponent(this.network.getComponent(point));
               
               // isSelected = false;
               // this.network.getComponent(point).RemoveConnection(this.network.getConnection();
            }
            workPanel.Invalidate();
        }

        /// <summary>
        /// Collects and assigns points to the connections
        /// </summary>
        /// <param name="p"></param>
        private void addConnectionPoints(Point p)
        {
            if (this.network.getComponent(p) != null)
            {
                if (startComponent == null)
                {
                    startComponent = this.network.getComponent(p);
                    if (startComponent is Sink)
                    {
                        MessageBox.Show("You cannot start with Sink");
                        startComponent = null;
                    }
                    else
                        pointsList.Add(new Point(p.X + 10, p.Y + 5));
                }
                else if (endComponent == null)
                {
                    endComponent = this.network.getComponent(p);
                    
                        pointsList.Add(p);
                        points = pointsList.ToArray();
                        con = new Connection(startComponent, endComponent, Convert.ToInt32(tbMaxFlow.Text), points);
                        //adjSpliter.setInput(con,Convert.ToInt32(con.setFlow()));
                        this.network.AddConnection(ref con);
                        this.workPanel.Invalidate();
                }

            }
            else if (startComponent == null)
            {
                MessageBox.Show("You must select a starting component first");
            }
            else if (endComponent == null)
                pointsList.Add(p);

        }

        private void btSet_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = false;
            btSet.Visible = false;
            lbPrc.Visible = false;
            adjSpliter.setPercentage(trackBar1.Value);
             
        }

        private void pbPipe_MouseClick(object sender, MouseEventArgs e)
        {
            pipeActivate = true;
        }

        private void pbPipe_Click(object sender, EventArgs e)
        {
            pipeActivate = true;
        }

        
      

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.network.listComponents.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to save your current work?", "Save file ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.network.SaveAs(this.network);
                    this.network.listComponents.Clear();
                    this.network.listConnections.Clear();
                    this.isSelected = false;
                    this.workPanel.Invalidate();
                }
                else
                    this.network.listComponents.Clear();
                this.network.listConnections.Clear();
                this.isSelected = false;
                this.workPanel.Invalidate();

            }
            else
            {
                this.network.listComponents.Clear();
                this.network.listConnections.Clear();
                this.isSelected = false;
                this.workPanel.Invalidate();

            }
        }

        /// <summary>
        /// Method to Open a file with network
        /// </summary>
        public bool OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                BinaryFormatter bf = null;

                openFileDialog.Filter = "SimulatorExtension files (*.simex)|*.simex";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;


                fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                Network loadNetwork = (Network)(bf.Deserialize(fs));
                this.network = loadNetwork;
                this.network.listComponents = loadNetwork.listComponents;
                this.network.listConnections = loadNetwork.listConnections;
                return true;
            }
            else
                return false;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.network.listComponents.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to save your current work?", "Save file ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.network.SaveAs(this.network);
                    this.OpenFile();
                    isSelected = true;
                    workPanel.Invalidate();
                }
                else
                    this.OpenFile();
                    this.isSelected = true;
                workPanel.Invalidate();
            }
            else
            {
                this.OpenFile();
                this.isSelected = true;
                workPanel.Invalidate();
            }
           // workPanel.Invalidate();

        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.network.SaveAs(this.network);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.network.listComponents.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to save your current work?", "Save file ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.network.SaveAs(this.network);
                    this.Close();
                }
                else
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

    }
}
