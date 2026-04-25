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
        List<ParticleColorful> colorfulParticles= new List<ParticleColorful>();
        public override void ImpactParticle(Particle particle)
        {
            double gX = X - particle.X;
            double gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);

            

            if (particle.Radius + r < pointD / 2)
            {

                ParticleColorful detectedParticle = new ParticleColorful();


                detectedParticle.X=particle.X;
                detectedParticle.Y=particle.Y;

                detectedParticle.Radius = particle.Radius;

                detectedParticle.SpeedX= particle.SpeedX;
                detectedParticle.SpeedY= particle.SpeedY;

                detectedParticle.Life= particle.Life;

                detectedParticle.FromColor = Color.Lime;
                detectedParticle.ToColor=Color.Lime;

                colorfulParticles.Add(detectedParticle);
                
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
                $"{colorfulParticles.Count()}",
                new Font("Verdana", 10),
                new SolidBrush(Color.White),
                X,
                Y,
                stringFormat // передаем инфу о выравнивании
            );


            foreach(var particle in colorfulParticles)
            {
                particle.Draw(g);
            }
            

        }
    }
}
