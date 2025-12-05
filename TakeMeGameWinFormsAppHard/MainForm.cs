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


    }
}
