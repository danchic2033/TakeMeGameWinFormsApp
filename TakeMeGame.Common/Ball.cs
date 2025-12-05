using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeGameWinFormsApp
{
    public class Ball
    {
        private MainForm form;
        private Random rand = new Random();
        private int vx;
        private int vy;
        protected int x = 150;
        protected int y = 150;
        protected int size = 70;
        public Ball(MainForm form) 
        {
            this.form = form;
            vx = rand.Next(-5, 6);
            vy = rand.Next(-5, 6);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public void Show()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Black;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        private void Go()
        {
            x += vx;
            y += vy;
        }
        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White; // сравнять цвет с цветом формы
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public bool IsCaught()
        {
            return x >= 0 && y >= 0 && (x + size) <= form.ClientSize.Width && (y + size) <= form.ClientSize.Height;
        }
    }
}
