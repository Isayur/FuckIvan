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
        private double lowInflow;
        private double upperInFlow;
        public double outFlow;
        public bool hasLowIn = false;
        public bool hasUpperIn = false;
        public bool hasOut = false;

        public Rectangle upperLeft;
        public Rectangle lowerLeft;
        public Rectangle output;

        public Merger(Image image, int size, Point coordinates)
            : base(image, size, coordinates)
        {
            //this.upInput = UpInput;
            //this.lowInput = LowInput;
            lowInflow = 0;
            upperInFlow = 0;
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
                hasOut = false;
                Output = null;
            }
            else if (con == this.lowInput)
            {
                hasLowIn = false;
                lowInflow = 0;
                outFlow = upperInFlow;
                lowInput = null;
            }
            else if (con == this.upInput)
            {
                hasUpperIn = false;
                upperInFlow = 0;
                outFlow = lowInflow;
                lowInput = null;
            }
        }

        public void Clear()
        {
             
             
                hasOut = false;
                Output = null;
             
                hasLowIn = false;
                lowInflow = 0;
                outFlow = upperInFlow;
                lowInput = null;
            
                hasUpperIn = false;
                upperInFlow = 0;
                outFlow = lowInflow;
              
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
            outFlow = upperInFlow + lowInflow;
        }

        public void setLowInput(ref Connection c)
        {
            //set the the low input
            if (!hasLowIn)
            {
                lowInput = c;
                lowInflow = c.flow;
                Merge();
                hasLowIn = true;
            }
            else
            {
                MessageBox.Show("You cannot have more than 2 low Inputs in a Merger!");
                c = null;
            }

        }

        public void setUpInput(ref Connection c)
        {
            if (!hasUpperIn)
            {
                upInput = c;
                upperInFlow = c.flow;
                Merge();
                hasUpperIn = true;
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
            if (!hasOut)
            {
                Output = c;
                Merge();
                c.flow = outFlow;
                hasOut = true;
            }
            else
            {
                c = null;
                MessageBox.Show("You cannot have more than 2 low Inputs in a Merger!");
            }
        }




    }
}
