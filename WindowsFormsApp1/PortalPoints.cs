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

        public int portalOutParticleDirection = 0;
        public override void ImpactParticle(Particle particle)
        {
            double gX = X1 - particle.X;
            double gY = Y1 - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r < pointsD / 2 + particle.Radius)
            {
                float particleInX = particle.X - X1;
                float particleInY = particle.Y - Y1;

                float radius = pointsD / 2f;
                double rad = portalOutParticleDirection * Math.PI / 180.0;

                float angle = (float)Math.Atan2(particleInY, particleInX);

                double cos = Math.Cos(rad);
                double sin = Math.Sin(rad);

                double oldX = particle.SpeedX;
                double oldY = particle.SpeedY;

                particle.SpeedX = -(float)(oldX * cos - oldY * sin);
                particle.SpeedY = -(float)(oldX * sin + oldY * cos);


                float angleIn = (float)Math.Atan2(particleInY, particleInX);
                float angleOut = angleIn + portalOutParticleDirection * (float)(Math.PI / 180.0);
                particle.X = X2 + radius * (float)Math.Cos(angleOut);
                particle.Y = Y2 + radius * (float)Math.Sin(angleOut);

                particle.inRadar = false;
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
