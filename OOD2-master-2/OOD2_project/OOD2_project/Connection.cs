using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOD2_project
{
    [Serializable]
    public class Connection
    {
        public Component startComponent;
        public Component endComponent;
        public Color color;
        public int flow;
        private int maxFlow;
        public Point[] curvePoints;

        public Connection(Component StartComp, Component EndComp, int MaxFlow, Point[] points)
        {
            this.startComponent = StartComp;
            this.endComponent = EndComp;
            this.maxFlow = MaxFlow;
            this.curvePoints = points;
        }



        /// <summary>
        /// Returns a string with the flow in this pipeline..
        /// </summary>
        public string setFlow()
        {
            return "Current flow is: " + flow;
        }

        /// <summary>
        /// Returns TRUE if current flow is over the maximum flow..
        /// </summary>
        public bool IsCriticalSection()
        {
            if (flow > maxFlow)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Drawing the connectinos between the components
        /// </summary>
        /// <param name="gr"></param>
        public void DrawConnection(Graphics gr)
        {
           // switch (startComponent)
            //{
                //case Sink:
                    //gr.DrawLines(new Pen(Brushes.Red, 5), curvePoints);
                    //break;
            //}
            
                if (IsCriticalSection())
                {
                    gr.DrawLines(new Pen(Brushes.Red, 5), curvePoints);
                    gr.DrawString(setFlow(), new Font(FontFamily.GenericSerif, 10, FontStyle.Regular), Brushes.Red, ((startComponent.getPosition().X + endComponent.getPosition().X) / 2), ((startComponent.getPosition().Y + endComponent.getPosition().Y) / 2));
                }
                else
                    gr.DrawLines(new Pen(Brushes.Green, 5), curvePoints);
                    gr.DrawString(setFlow(), new Font(FontFamily.GenericSerif, 10, FontStyle.Regular), Brushes.Green, ((startComponent.getPosition().X + endComponent.getPosition().X) / 2), ((startComponent.getPosition().Y + endComponent.getPosition().Y) / 2));
            
            
        }
    }
}
