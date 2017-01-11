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
    public class Sink : Component
    {
        public Connection input;
        private bool isEmpty;
        private int inFlow;
        Rectangle rect;

        public Sink(Image image, int size, Point coordinates) 
            : base(image, size, coordinates) 
        {
            inFlow = 0;
            isEmpty = true;
        }

        public void Clear()
        {
            input = null;
            isEmpty = true;
            inFlow = 0;
        }

        public override void DrawComponent(Graphics gr)
        {
            try
            {
                rect = new Rectangle(point.X - 1, point.Y - 1, base.size, base.size);
                gr.DrawImage(base.image, rect);
                gr.DrawString(Convert.ToString(inFlow), new Font(FontFamily.GenericSerif, 17, FontStyle.Bold), Brushes.Green , new Point(getPosition().X + 10 ,getPosition().Y +12));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// return the position of the component
        /// </summary>
        /// <returns></returns>
        public override Point getPosition()
        {
            return base.getPosition();
        }

        /// <summary>
        /// sets the pipe connected to the component
        /// </summary>
        /// <param name="con"></param>
        public void setInput(ref Connection con)
        {
            if (isEmpty)
            {
                input = con;
                this.inFlow = con.flow;
                isEmpty = false;
            }
            else
            {
                con = null;
                MessageBox.Show("You cannot have more than one Input in the Sink!");
            }
        }

    }
}