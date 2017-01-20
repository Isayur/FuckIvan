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
    public class Splitter : Component
    {
        public double upperOutFlow;
        public double lowOutFlow;
        public double inFlow;
        public Connection Input;
        public Connection upperOutput;
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
            else if (con == this.upperOutput)
            {
                hasUpOut = false;
                LowOutput = null;
            }
        }
        public void Clear()
        {
             
                hasIn = false;
                inFlow = 0;
                upperOutFlow = 0;
                lowOutFlow = 0;
                Input = null;
            
                hasLowOut = false;
                LowOutput = null;
             
                hasUpOut = false;
              
        }

        public void setInput( ref Connection conn)
        {
            if (hasIn)
            {
                MessageBox.Show("You cannot have more than 1 Input");
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

        public void SetupperOutput(ref Connection conn)
        {
            if (!hasUpOut)
            {
                this.upperOutput = conn;
                Split();
                conn.flow = upperOutFlow;
                hasUpOut = true;
            }
            else
            {
                MessageBox.Show("You can not have more than 2 up Outputs");
                conn = null;
            }
        }

        public void SetLowOutput(ref Connection conn)
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
                MessageBox.Show("You can not have more than 2 low Outputs");
                conn = null;
            }
        }

        public override Point getPosition()
        {
            return base.getPosition();
        }


    }
    
}
