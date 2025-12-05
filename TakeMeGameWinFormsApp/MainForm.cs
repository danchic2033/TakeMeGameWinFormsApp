
namespace TakeMeGameWinFormsApp
{
    public partial class MainForm : Form
    {
        List<MoveBall> moveBalls;
        PointBall pointBall;
        public MainForm()
        {
            InitializeComponent();
        }

        private void createBallsButton_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var randomSizeAndPointBall = new MoveBall(this);
                moveBalls.Add(randomSizeAndPointBall);
                randomSizeAndPointBall.Start();
            }
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void goBallsButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void movePointBall_Click(object sender, EventArgs e)
        {
            pointBall.Move();
        }

        private void stopAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                moveBalls[i].Stop();
            }
        }
    }
}
