using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();


        Emitter emitter;

        GravityPoint point1; // добавил поле под первую точку
        GravityPoint point2; // добавил поле под вторую точку

        PortalPoints portalPoints;

        RadarPoint radarPoint;
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 20,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 20,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter);

            point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };
            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            portalPoints = new PortalPoints
            {
                X1 = picDisplay.Width / 2 - 50,
                Y1=picDisplay.Height / 2,
                X2=picDisplay.Width / 2 +50,
                Y2=picDisplay.Height / 2
            };

            radarPoint = new RadarPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            // привязываем поля к эмиттеру
            //emitter.impactPoints.Add(point1);
            //emitter.impactPoints.Add(point2);

            emitter.impactPoints.Add(radarPoint);
            emitter.impactPoints.Add(portalPoints);
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }

            picDisplay.Invalidate();

        }


        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            radarPoint.X = e.X;
            radarPoint.Y = e.Y;

            //point2.X = e.X;
            //point2.Y = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
            point1.Power = tbGraviton1.Value;
        }

        private void tbGraviton2_Scroll(object sender, EventArgs e)
        {
            point2.Power = tbGraviton2.Value;
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (taskBox.Text=="Счётчик")
            {
                CounterPoint newCounter = new CounterPoint();
                newCounter.X = e.X;
                newCounter.Y = e.Y;
                emitter.impactPoints.Add(newCounter);
            }
            else if (taskBox.Text=="Порталы")
            {
                if (e.Button == MouseButtons.Left)
                {
                    portalPoints.X1 = e.X;
                    portalPoints.Y1 = e.Y;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    portalPoints.X2 = e.X;
                    portalPoints.Y2 = e.Y;
                }
            }

        }

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta>0)
            {
                radarPoint.pointD += 5;
            }
            else if (e.Delta<0)
            {
                radarPoint.pointD -= 5;
            }
        }
    }
}
