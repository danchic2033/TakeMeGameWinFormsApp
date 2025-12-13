using Balls.Common;
using System;
using Timer = System.Windows.Forms.Timer;

namespace SalutWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<SalutBall> moveBalls = new List<SalutBall>();
        private Timer timer = new Timer();
        private bool FireWorkwsOnce = false;
        public MainForm()
        {
            InitializeComponent();
            //timer.Interval = 20;
            //timer.Tick += Timer_Tick;
        }

        //private void Timer_Tick(object? sender, EventArgs e)
        //{
        //    for (int i = moveBalls.Count - 1; i >= 0; i--)
        //    {
        //        var ball = moveBalls[i];
        //        ball.Update();

        //        if (ball.Flying() && FireWorkwsOnce != true)
        //        {
        //            var random = new Random();
        //            int countAllBalls = random.Next(1, 11);
        //            FireWorkwsOnce = true;
        //            int posX = (int)ball.GetPositionX();
        //            int posY = (int)ball.GetPositionY();

        //            for (int j = 0; j < countAllBalls; j++)
        //            {
        //                var newBall = new SalutBall(this, posX, posY);
        //                newBall.Start();
        //                moveBalls.Add(newBall);
        //            }
        //        }
        //    }

        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewBall();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < moveBalls.Count; i++)
            {
                if (moveBalls[i].ContainsPoint(e.X, e.Y))
                {
                    if (moveBalls[i].GetColor() == Color.Black)
                    {
                        MessageBox.Show("Вы проиграли");
                        Application.Restart();
                        // Тут можно добавить завершение игры или перезапуск
                    }
                    else
                    {
                        moveBalls[i].Stop();
                        moveBalls[i].Clear();
                        moveBalls.RemoveAt(i);
                        break;
                    }
                }
            }
            NewBall();
        }

        private void NewBall()
        {

            var random = new Random();
            int numberOfColor = random.Next(1, 3);
            if (numberOfColor == 1)
            {
                var salut = new SalutBall(this, ClientSize.Width / 2, ClientSize.Height * 1, Color.Aqua);
                salut.Start();
                timer.Start();
                moveBalls.Add(salut);
            }
            else
            {
                var salut = new SalutBall(this, ClientSize.Width / 2, ClientSize.Height * 1, Color.Black);
                salut.Start();
                timer.Start();
                moveBalls.Add(salut);
            }
        }
    }
}
