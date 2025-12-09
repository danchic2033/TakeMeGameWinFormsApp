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
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
