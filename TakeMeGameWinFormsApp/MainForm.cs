
using Balls.Common;

namespace TakeMeGameWinFormsApp
{
    public partial class MainForm : Form
    {
        List<Ball> balls;
        PointBall pointBall;
        private int count = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void createBallsButton_Click(object sender, EventArgs e)
        {
            balls = new List<Ball>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                balls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void stopAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                balls[i].Stop();
                if (balls[i].IsCaught())
                    count++;
            }
            MessageBox.Show($"Внутри формы {count} шаров");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
