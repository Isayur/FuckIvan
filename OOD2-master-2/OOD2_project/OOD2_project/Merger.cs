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
    public class Merger : Component
    {
        public Connection upInput { get; set; }
        public Connection lowInput { get; set; }
        public Connection Output { get; set; }
        private int lowInflow;
        private int upInflow;
        public int outFlow;
        public bool counterLowIn = false;
        public bool counterUpIn = false;
        public bool counterOut = false;

        public Rectangle upperLeft;
        public Rectangle lowerLeft;
        public Rectangle output;

        public Merger(Image image, int size, Point coordinates)
            : base(image, size, coordinates)
        {
            //this.upInput = UpInput;
            //this.lowInput = LowInput;
            lowInflow = 0;
            upInflow = 0;
            outFlow = 0;
            upperLeft = new Rectangle(base.rect.Left, base.rect.Top, 27, 27);
            lowerLeft = new Rectangle(base.rect.Left, base.rect.Top + (base.rect.Height / 2), 27, 27);
            output = new Rectangle(base.rect.Left + (base.rect.Width / 2), base.rect.Top, base.rect.Width/2,base.rect.Height);
        }

        public void Clear(Connection con)
        {
            //remove all connections related to a component
            if (con == this.Output)
            {
                counterOut = false;
                Output = null;
            }
            else if (con == this.lowInput)
            {
                counterLowIn = false;
                lowInflow = 0;
                outFlow = upInflow;
                lowInput = null;
            }
            else if (con == this.upInput)
            {
                counterUpIn = false;
                upInflow = 0;
                outFlow = lowInflow;
                lowInput = null;
            }
        }

        public void DrawComponent(Graphics gr, Point p)
        {
            // draw the certain component on the work panel
        }

        public override Point getPosition()
        {
            return base.getPosition();
            // get the position of the component
        }

        public void Merge()
        {
            //merge the low and up outputs
            outFlow = upInflow + lowInflow;
        }

        public void setLowInput(ref Connection c)
        {
            //set the the low input
            if (!counterLowIn)
            {
                lowInput = c;
                lowInflow = c.flow;
                Merge();
                counterLowIn = true;
            }
            else
            {
                MessageBox.Show("You cannot have more than 2 low Inputs in a Merger!");
                c = null;
            }

        }

        public void setUpInput(ref Connection c)
        {
            if (!counterUpIn)
            {
                upInput = c;
                upInflow = c.flow;
                Merge();
                counterUpIn = true;
            }
            else
            {
                MessageBox.Show("You cannot have more than 2 low Inputs in a Merger!");
                c = null;
                //set the up input of the component
            }
        }

        public void setOutput(ref Connection c)
        {
            if (!counterOut)
            {
                Output = c;
                Merge();
                c.flow = outFlow;
                counterOut = true;
            }
            else
            {
                c = null;
                MessageBox.Show("You cannot have more than 2 low Inputs in a Merger!");
            }
        }




    }
}
