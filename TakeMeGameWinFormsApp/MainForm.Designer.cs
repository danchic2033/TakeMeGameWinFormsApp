namespace TakeMeGameWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            createBallsButton = new Button();
            stopAllButton = new Button();
            goBallsButton = new Button();
            movePointBall = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // createBallsButton
            // 
            createBallsButton.Location = new Point(504, 12);
            createBallsButton.Name = "createBallsButton";
            createBallsButton.Size = new Size(107, 40);
            createBallsButton.TabIndex = 0;
            createBallsButton.Text = "много шариков";
            createBallsButton.UseVisualStyleBackColor = true;
            createBallsButton.Click += createBallsButton_Click;
            // 
            // stopAllButton
            // 
            stopAllButton.Location = new Point(617, 12);
            stopAllButton.Name = "stopAllButton";
            stopAllButton.Size = new Size(103, 40);
            stopAllButton.TabIndex = 1;
            stopAllButton.Text = "Остановить все";
            stopAllButton.UseVisualStyleBackColor = true;
            stopAllButton.Click += stopAllButton_Click;
            // 
            // goBallsButton
            // 
            goBallsButton.BackColor = SystemColors.Control;
            goBallsButton.Location = new Point(388, 12);
            goBallsButton.Name = "goBallsButton";
            goBallsButton.Size = new Size(89, 40);
            goBallsButton.TabIndex = 2;
            goBallsButton.Text = "Двигать";
            goBallsButton.UseVisualStyleBackColor = false;
            goBallsButton.Click += goBallsButton_Click;
            // 
            // movePointBall
            // 
            movePointBall.Location = new Point(392, 72);
            movePointBall.Name = "movePointBall";
            movePointBall.Size = new Size(153, 37);
            movePointBall.TabIndex = 3;
            movePointBall.Text = "двигать pointBall";
            movePointBall.UseVisualStyleBackColor = true;
            movePointBall.Click += movePointBall_Click;
            // 
            // timer
            // 
            timer.Interval = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(movePointBall);
            Controls.Add(goBallsButton);
            Controls.Add(stopAllButton);
            Controls.Add(createBallsButton);
            Name = "MainForm";
            Text = "Form1";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button createBallsButton;
        private Button stopAllButton;
        private Button goBallsButton;
        private Button movePointBall;
        private System.Windows.Forms.Timer timer;
    }
}
