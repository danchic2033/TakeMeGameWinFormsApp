namespace TakeMeGameWinFormsAppHard
{
    public partial class MainForm : Form
    {
        List<MoveBall> moveBalls;
        PointBall pointBall;
        private int count = 0;
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < moveBalls.Count; i++)
            {
                if (moveBalls[i].ContainsPoint(e.X, e.Y))
                {
                    moveBalls[i].Stop();
                    count++;
                    break;
                }
            }
            scoreBallsLabel.Text = count.ToString();
        }
    }
}
