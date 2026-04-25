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

            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            
            if (r + particle.Radius < pointD/2+r)
            {
                particle.Life = 0;
                counter++;
            }
        }

        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным pointD
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - pointD/2,
                   Y - pointD/2,
                   pointD,
                   pointD
                   );
            var stringFormat = new StringFormat(); // создаем экземпляр класса
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали

            g.DrawString(
                $"{counter}",
                new Font("Verdana", 10),
                new SolidBrush(Color.White),
                X,
                Y,
                stringFormat // передаем инфу о выравнивании
            );

        }
    }
}
