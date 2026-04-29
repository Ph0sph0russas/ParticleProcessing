using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CounterPoint : IImpactPoint
    {
        private int counter = 0;
        public int pointD = 70;
        public override void ImpactParticle(Particle particle)
        {

            double gX = X - particle.X;
            double gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            
            if (r < pointD/2 + particle.Radius)
            {
                particle.Life = 0;
                particle.inRadar = false;
                counter++;
            }
        }

        public override void Render(Graphics g)
        {
           
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - pointD/2,
                   Y - pointD/2,
                   pointD,
                   pointD
                   );

            var stringFormat = new StringFormat(); 
            stringFormat.Alignment = StringAlignment.Center; 
            stringFormat.LineAlignment = StringAlignment.Center; 

            g.DrawString(
                $"{counter}",
                new Font("Verdana", 10),
                new SolidBrush(Color.White),
                X,
                Y,
                stringFormat
            );

        }
    }
}
