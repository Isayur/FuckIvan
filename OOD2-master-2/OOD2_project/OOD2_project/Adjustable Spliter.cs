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
    public class Adjustable_Spliter : Component
    {
        private int percentage;
        private int inFlow;
        public int upOutFlow;
        public int lowOutFlow;
        private Connection Input;
        public Connection UpOutput;
        public Connection LowOutput;
        private bool counterIn = false;
        private bool counterUpOut = false;
        private bool counterLowOut = false;

        public Rectangle upperRight;
        public Rectangle lowerRight;
        public Rectangle input;

        public Adjustable_Spliter(Image image, int size, Point coordinates)
            : base(image, size, coordinates)
        {
            inFlow = 0;
            upOutFlow = 0;
            lowOutFlow = 0;

            upperRight = new Rectangle((base.rect.Right - (base.rect.Width / 2) + 10), base.rect.Bottom - base.rect.Height, 30, 27);
            lowerRight = new Rectangle((base.rect.Right - (base.rect.Width / 2) + 12), base.rect.Top + (base.rect.Height / 2), base.rect.Width / 2, (base.rect.Height / 2) + 1);
            input = new Rectangle(base.rect.Left, base.rect.Top, base.rect.Width / 2, base.rect.Height);
            //this.currentFlow = CurrentFlow;
        }

        public void setPercentage(int value)
        {
            percentage = value;
        }

        public void Split()
        {
           // input = base.currentFlow;
            this.lowOutFlow = inFlow * percentage / 100;
            this.upOutFlow = inFlow - lowOutFlow; 
        }

        public void Clear(Connection con)
        {
            if (con == this.Input)
            {
                counterIn = false;
                inFlow = 0;
                upOutFlow = 0;
                lowOutFlow = 0;
                Input = null;
            }
            else if (con == this.LowOutput)
            {
                counterLowOut = false;
                LowOutput = null;
            }
            else if (con == this.UpOutput)
            {
                counterUpOut = false;
                LowOutput = null;
            }
        }

        public void setInput(ref Connection conn)
        {
            if (counterIn)
            {
                conn = null;
                MessageBox.Show("You cannot have more than 1 Input");
            }
            else
            {
                this.Input = conn;
                this.inFlow = conn.flow;
                Split();
                counterIn = true;
            }
        }

        public void SetUpOutput(ref Connection conn)
        {
            if (!counterUpOut)
            {
                this.UpOutput = conn;
                Split();
                conn.flow = upOutFlow;
                counterUpOut = true;
            }
            else
            {
                conn = null;
                MessageBox.Show("You can not have more than 2 up Outputs");
            }
        }

        public void SetLowOutput(ref Connection con)
        {
            if (!counterLowOut)
            {
                this.LowOutput = con;
                Split();
                con.flow = lowOutFlow;
                counterLowOut = true;
            }
            else
            {
                con = null;
                MessageBox.Show("You can not have more than 2 low Outputs");
            }
        }

        public override Point getPosition()
        {
            return base.getPosition();
        }

        
    }
}
