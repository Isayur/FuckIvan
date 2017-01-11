using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    class Merger : Component
    {
        private double upperInFlow;
        private double lowInFlow;
        private double outFlow;
        public Connection upInput;
        public Connection lowInput;
        public Connection output;
        private bool hasUpIn = false;
        private bool hasLowIn = false;
        private bool hasOut = false;

        public Rectangle upperIn;
        public Rectangle lowerIn;
        public Rectangle outputRect;

        public Merger(Image image, int size, Point coordinates)
            : base(image, size, coordinates)
        {
            //this.upInput = UpInput;
            //this.lowInput = LowInput;
            lowInFlow = 0;
            upperInFlow = 0;
            outFlow = 0;
            upperIn = new Rectangle(base.rect.Left, base.rect.Top, 27, 27);
            lowerIn = new Rectangle(base.rect.Left, base.rect.Top + (base.rect.Height / 2), 27, 27);
            outputRect = new Rectangle(base.rect.Left + (base.rect.Width / 2), base.rect.Top, base.rect.Width / 2, base.rect.Height);
        }

        public void Clear(Connection con)
        {
            //remove all connections related to a component
            if (con == this.output)
            {
                hasOut = false;
                output = null;
            }
            else if (con == this.lowInput)
            {
                hasLowIn = false;
                lowInFlow = 0;
                outFlow = upperInFlow;
                lowInput = null;
            }
            else if (con == this.upInput)
            {
                hasUpIn = false;
                upperInFlow = 0;
                outFlow = lowInFlow;
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
            outFlow = upperInFlow + lowInFlow;
        }

        public void setLowInput(ref Connection c)
        {
            //set the the low input
            if (!hasLowIn)
            {
                lowInput = c;
                lowInFlow = c.flow;
                Merge();
                hasLowIn = true;
            }
            else
            {
                MessageBox.Show("Can't have a second lower input");
                c = null;
            }

        }

        public void setUpInput(ref Connection c)
        {
            if (!hasUpIn)
            {
                upInput = c;
                upperInFlow = c.flow;
                Merge();
                hasUpIn = true;
            }
            else
            {
                MessageBox.Show("Can't have a second upper input");
                c = null;
                //set the up input of the component
            }
        }

        public void setOutput(ref Connection c)
        {
            if (!hasOut)
            {
                output = c;
                Merge();
                c.flow = outFlow;
                hasOut = true;
            }
            else
            {
                c = null;
                MessageBox.Show("Can't have a second output");
            }
        }

    }
}
