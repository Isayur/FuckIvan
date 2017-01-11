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
    public class Spliter : Component
    {
        public int upOutFlow;
        public int lowOutFlow;
        public int inFlow;
        private Connection Input;
        public Connection UpOutput;
        public Connection LowOutput;
        private bool counterIn = false;
        private bool counterUpOut = false;
        private bool counterLowOut = false;

        public Rectangle upperRight;
        public Rectangle lowerRight;
        public Rectangle input;


        public Spliter(Image image, int size, Point coordinates)
            : base(image, size, coordinates)
        {
            this.lowOutFlow = 0;
            this.upOutFlow = 0;
            this.inFlow = 0;
            upperRight = new Rectangle((base.rect.Right - (base.rect.Width / 2)+10), base.rect.Bottom - base.rect.Height, 30, 27);
            lowerRight = new Rectangle((base.rect.Right - (base.rect.Width / 2)+12), base.rect.Top + (base.rect.Height / 2), base.rect.Width / 2, (base.rect.Height / 2) + 1);
            input = new Rectangle(base.rect.Left, base.rect.Top, base.rect.Width / 2, base.rect.Height);

            //upperRight = new Rectangle(base.rect.Left + (base.rect.Width / 2), base.rect.Top + (base.rect.Width / 2), base.rect.Width / 2, base.rect.Height / 2);
            //lowerRight = new Rectangle(base.rect.Left + (base.rect.Width / 2), base.rect.Top + (base.rect.Height / 2), base.rect.Width / 2, base.rect.Height / 2);
            //input = new Rectangle(base.rect.Left, base.rect.Top, base.rect.Width / 2, base.rect.Height);
        }

        public void Split()
        {
           // input = base.currentFlow;
            this.upOutFlow = inFlow / 2;
            this.lowOutFlow = inFlow / 2;
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

        public void setInput( ref Connection conn)
        {
            if (counterIn)
            {
                MessageBox.Show("You cannot have more than 1 Input");
                conn = null;
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
                MessageBox.Show("You can not have more than 2 up Outputs");
                conn = null;
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
                MessageBox.Show("You can not have more than 2 low Outputs");
                con = null;
            }
        }

        public override Point getPosition()
        {
            return base.getPosition();
        }


    }
    
}
