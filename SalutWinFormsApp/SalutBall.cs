using Balls.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalutWinFormsApp
{
    public class SalutBall : MoveBall
    {
        private float g = 0.2f;
        public float PreviousVy = 0;
        public bool HasSplit = false;
        public SalutBall(Form form, int centerX, int centerY) : base(form)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            vy = -Math.Abs(vy);
        }
        public override void Show()
        {
            base.Show();
            var brush = new SolidBrush(Color.Black);
            Draw(brush);
        }
        public void ShowColor()
        {
            var brush = new SolidBrush((Color)Color.Blue);
            Draw(brush);
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }

        public bool Flying()
        {
            return vy >= 0;
        }

        public float GetPositionX()
        {
            return centerX;
        }

        public float GetPositionY()
        {
            return centerY;
        }

        public void Update()
        {
            // Например, добавляем гравитацию
            vy += g; // gravity - константа, например, 0.1f
            centerX += vx;
            centerY += vy;

            PreviousVy = vy;
        }
    }
}
