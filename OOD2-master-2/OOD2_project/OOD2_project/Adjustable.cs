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
    public class Adjustable : Splitter
    {
        private double percentage;

        public Rectangle upperRight;
        public Rectangle lowerRight;
        public Rectangle input;

        public Adjustable(Image image, int size, Point coordinates)
            : base(image, size, coordinates)
        {
            inFlow = 0;
            upperOutFlow = 0;
            lowOutFlow = 0;

            upperRight = new Rectangle((base.rect.Right - (base.rect.Width / 2) + 10), base.rect.Bottom - base.rect.Height, 30, 27);
            lowerRight = new Rectangle((base.rect.Right - (base.rect.Width / 2) + 12), base.rect.Top + (base.rect.Height / 2), base.rect.Width / 2, (base.rect.Height / 2) + 1);
            input = new Rectangle(base.rect.Left, base.rect.Top, base.rect.Width / 2, base.rect.Height);
            //this.currentFlow = CurrentFlow;
        }

        public void setPercentage(double value)
        {
            percentage = value;
            this.Split();
        }

        public override void Split()
        {
            this.upperOutFlow = inFlow * percentage / 100;
            this.lowOutFlow = inFlow * (100 - percentage) / 100;
        }


    }
}
