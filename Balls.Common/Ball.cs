using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls.Common
{
    public class Ball
    {
        protected Form form;
        private Timer timer;
        private Random rand = new Random();
        protected float vx;
        protected float vy;
        protected float centerX = 5;
        protected float centerY = 5;
        protected int radius;
        protected Color color;

        public Ball(Form form)
        {
            this.form = form;
            radius = rand.Next(15, 40);
            vx = (float)rand.NextDouble() * 10 - 5;
            vy = (float)rand.NextDouble() * 20 - 5;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public Ball(Form form, Color color) 
        {
            this.color = color;
            this.form = form;
            vx = (float)rand.NextDouble() * 10 - 5;
            vy = (float)rand.NextDouble() * 10 - 5;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        public Color GetColor()
        {
            return color;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }


        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public virtual void Show()
        {
            var brush = new SolidBrush(color);
            Draw(brush);
        }

        protected virtual void Go()
        {
            centerX += (int)vx;
            centerY += (int)vy;

            
        }
        public void Clear()
        {
            var brush = new SolidBrush(form.BackColor); // сравнять цвет с цветом формы
            Draw(brush);
        }

        public void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }

        public int LeftSide()
        {
            return radius;
        }

        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }

        public int TopSide()
        {
            return radius;
        }

        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public bool IsCaught()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }

        public bool ContainsPoint(int x, int y)
        {
            var dx = x - centerX;
            var dy = y - centerY;
            return dx * dx + dy * dy <= radius * radius;
        }
    }
}
