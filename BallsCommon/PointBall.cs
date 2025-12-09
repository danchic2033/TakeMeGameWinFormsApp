using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeGameWinFormsAppHard
{
    public class PointBall : Ball
    {
        public PointBall(MainForm form, int x, int y) : base(form)
        {
            this.x = x;
            this.y = y;
        }
    }
}
