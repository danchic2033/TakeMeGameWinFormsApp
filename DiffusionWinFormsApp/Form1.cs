using Balls.Common;
using Timer = System.Windows.Forms.Timer;

namespace DiffusionWinFormsApp
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        private List<BillyardBall> balls = new List<BillyardBall>();
        int ballsCount = 20;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            ShowVerticalCentralLine();
            int leftOfCenterBlueCount = 0;
            int rightOfCenterBlueCount = 0;

            int leftOfCenterBlackCount = 0;
            int rightOfCenterBlackCount = 0;

            foreach (var ball in balls)
            {
                if (ball.LeftOfCenter())
                {
                    if (ball.GetColor() == Color.Blue)
                    {
                        leftOfCenterBlueCount++;
                    }
                    else
                    {
                        leftOfCenterBlackCount++;
                    }
                }
                if (ball.RightOfCenter())
                {
                    if (ball.GetColor() == Color.Blue)
                    {
                        rightOfCenterBlueCount++;
                    }
                    else
                    {
                        rightOfCenterBlackCount++;
                    }
                }
            }

            if (leftOfCenterBlueCount == leftOfCenterBlackCount && rightOfCenterBlackCount == rightOfCenterBlueCount && leftOfCenterBlueCount + leftOfCenterBlackCount + rightOfCenterBlackCount + rightOfCenterBlueCount == ballsCount)
            {
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ballsCount / 2; i++)
            {
                var ball = new BillyardBall(this, Color.Black);
                ball.OnHited += Ball_OnHitedBlack;
                ball.Start();
                balls.Add(ball);
            }

            for (int i = 0; i < ballsCount / 2; i++)
            {
                var ball = new BillyardBall(this, Color.Blue);
                ball.OnHited += Ball_OnHitedBlue;
                ball.Start();
                balls.Add(ball);
            }
        }

        private void ShowVerticalCentralLine()
        {
            var graphics = CreateGraphics();
            graphics.DrawLine(Pens.Gray, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
        }

        private void Ball_OnHitedBlack(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left: blackLeftLabel.Text = (int.Parse(blackLeftLabel.Text) + 1).ToString(); break;
                case Side.Right: blackRightLabel.Text = (int.Parse(blackRightLabel.Text) + 1).ToString(); break;
                case Side.Top: blackTopLabel.Text = (int.Parse(blackTopLabel.Text) + 1).ToString(); break;
                case Side.Down: blackDownLabel.Text = (int.Parse(blackDownLabel.Text) + 1).ToString(); break;
            }
        }
        private void Ball_OnHitedBlue(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left: blueLeftLabel.Text = (int.Parse(blueLeftLabel.Text) + 1).ToString(); break;
                case Side.Right: blueRightLabel.Text = (int.Parse(blueRightLabel.Text) + 1).ToString(); break;
                case Side.Top: blueTopLabel.Text = (int.Parse(blueTopLabel.Text) + 1).ToString(); break;
                case Side.Down: blueDownLabel.Text = (int.Parse(blueDownLabel.Text) + 1).ToString(); break;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ShowVerticalCentralLine();
        }
    }
}
