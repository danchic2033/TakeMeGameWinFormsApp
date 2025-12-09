namespace BilliardGameWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new BillyardBall(this);
                ball.OnHited += Ball_OnHited;
                ball.Start();
            }
        }

        private void Ball_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left: leftSideLabel.Text = (int.Parse(leftSideLabel.Text) + 1).ToString(); break;
                case Side.Right: rightSideLabel.Text = (int.Parse(rightSideLabel.Text) + 1).ToString(); break;
                case Side.Top: topSideLabel.Text = (int.Parse(topSideLabel.Text) + 1).ToString(); break;
                case Side.Down: downSideLabel.Text = (int.Parse(downSideLabel.Text) + 1).ToString(); break;
            }
        }
    }
}
