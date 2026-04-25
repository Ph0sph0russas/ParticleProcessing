using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RadarPoint : IImpactPoint
    {
        public int pointD = 100;
        private int counterInRadar = 0;
        public override void ImpactParticle(Particle particle)
        {
            double gX = X - particle.X;
            double gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);

            
            if (particle.Radius + r < pointD / 2)
            {
                counterInRadar++;
                particle.inRadar = true;
            }
            
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                    new Pen(Color.Lime),
                    X - pointD / 2,
                    Y - pointD / 2,
                    pointD,
                    pointD
                );


            var stringFormat = new StringFormat(); // создаем экземпляр класса
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали

            g.DrawString(
                $"{counterInRadar}",
                new Font("Verdana", 20),
                new SolidBrush(Color.White),
                X,
                Y,
                stringFormat // передаем инфу о выравнивании
            );


            counterInRadar = 0;
            

        }
    }
}
