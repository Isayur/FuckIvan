using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOD2_project
{
    [Serializable]
    public class Pump : Component
    {
        private int maxFlow;
        private int currentFlow;
        private Connection output;
        Rectangle rect;
        public bool isUsed { get; set; }

        public Pump(Image image, int size, Point coordinates, int CurrentFlow)
            : base(image, size, coordinates)
        {
            //rect = new Rectangle(point.X - 1, point.Y - 1, base.size, base.size);
            currentFlow = CurrentFlow;
            isUsed = false;
        }

        public void Clear()
        {
            isUsed = false;
            output = null;
        }

        public override void DrawComponent(Graphics gr)
        {
            try
            { 
                gr.DrawImage(base.image, base.rect);
                gr.DrawString(Convert.ToString(getFlow()), new Font(FontFamily.GenericSerif, 17, FontStyle.Bold), Brushes.Green , new Point(getPosition().X + 10 ,getPosition().Y +12));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Connection getOutput()
        {
            return output;
        }

        public int getFlow()
        {
            return currentFlow;
        }

        public override Point getPosition()
        {
            return base.getPosition();
        }

        public void setOutput(ref Connection con)
        {
            if (!isUsed)
            {
                output = con;
                con.flow = currentFlow;
                isUsed = true;
            }
            else
            {
                MessageBox.Show("You cannot have more than 1 output in a Pump");
                con = null;
            }
        }


    }
}