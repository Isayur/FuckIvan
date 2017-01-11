using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    [Serializable]
    class Splitter : Component
    {
        private double upperOutFlow;
        private double lowOutFlow;
        private double inFlow;
        public Connection Input;
        public Connection UpOutput;
        public Connection LowOutput;
        private bool hasIn = false;
        private bool hasUpOut = false;
        private bool hasLowOut = false;

        public Rectangle upperRight;
        public Rectangle lowerRight;
        public Rectangle input;

        public Splitter(Image image, int size, Point coordinates)
            : base(image, size, coordinates)
        {
            this.lowOutFlow = 0;
            this.upperOutFlow = 0;
            this.inFlow = 0;
            upperRight = new Rectangle((base.rect.Right - (base.rect.Width / 2) + 10), base.rect.Bottom - base.rect.Height, 30, 27);
            lowerRight = new Rectangle((base.rect.Right - (base.rect.Width / 2) + 12), base.rect.Top + (base.rect.Height / 2), base.rect.Width / 2, (base.rect.Height / 2) + 1);
            input = new Rectangle(base.rect.Left, base.rect.Top, base.rect.Width / 2, base.rect.Height);

            //upperRight = new Rectangle(base.rect.Left + (base.rect.Width / 2), base.rect.Top + (base.rect.Width / 2), base.rect.Width / 2, base.rect.Height / 2);
            //lowerRight = new Rectangle(base.rect.Left + (base.rect.Width / 2), base.rect.Top + (base.rect.Height / 2), base.rect.Width / 2, base.rect.Height / 2);
            //input = new Rectangle(base.rect.Left, base.rect.Top, base.rect.Width / 2, base.rect.Height);
        }

        public virtual void Split()
        {
            // input = base.currentFlow;
            this.upperOutFlow = this.lowOutFlow = inFlow / 2;
        }

        public void Clear(Connection con)
        {
            if (con == this.Input)
            {
                hasIn = false;
                inFlow = 0;
                upperOutFlow = 0;
                lowOutFlow = 0;
                Input = null;
            }
            else if (con == this.LowOutput)
            {
                hasLowOut = false;
                LowOutput = null;
            }
            else if (con == this.UpOutput)
            {
                hasUpOut = false;
                LowOutput = null;
            }
        }

        public void addIn(ref Connection conn)
        {
            if (hasIn)
            {
                MessageBox.Show("Can't have more than 1 input");
                conn = null;
            }
            else
            {
                this.Input = conn;
                this.inFlow = conn.flow;
                Split();
                hasIn = true;
            }

        }

        public void addUpper(ref Connection conn)
        {
            if (!hasUpOut)
            {
                this.UpOutput = conn;
                Split();
                conn.flow = upperOutFlow;
                hasUpOut = true;
            }
            else
            {
                MessageBox.Show("Can't have a second upper output");
                conn = null;
            }
        }

        public void addLower(ref Connection conn)
        {
            if (!hasLowOut)
            {
                this.LowOutput = conn;
                Split();
                conn.flow = lowOutFlow;
                hasLowOut = true;
            }
            else
            {
                MessageBox.Show("Can't have a second lower output");
                conn = null;
            }
        }

        public override Point getPosition()
        {
            return base.getPosition();
        }


    }
}
