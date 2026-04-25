using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   

    public class PortalPoints : IImpactPoint
    {
        private int pointsD = 50;

        public float X1;
        public float Y1;

        public float X2; 
        public float Y2;
        public override void ImpactParticle(Particle particle)
        {
            double gX = X1 - particle.X;
            double gY = Y1 - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r < pointsD / 2 + particle.Radius)
            {
                particle.X = X2;
                particle.Y= Y2;
              
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                    new Pen(Color.Red),
                    X1 - pointsD/2,
                    Y1 - pointsD/2,
                    pointsD,
                    pointsD
                );

            g.DrawEllipse(
                    new Pen(Color.Blue),
                    X2 -pointsD/2,
                    Y2 - pointsD / 2,
                    pointsD,
                    pointsD
                );
            g.DrawLine(
                    new Pen(Color.Green),
                    X1,
                    Y1,
                    X2,
                    Y2
                );
        }
    }
}
