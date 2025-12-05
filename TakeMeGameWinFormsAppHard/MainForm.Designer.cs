
namespace TakeMeGameWinFormsAppHard
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
            createBallsButton = new Button();
            getBallsLabel = new Label();
            scoreBallsLabel = new Label();
            SuspendLayout();
            // 
            // createBallsButton
            // 
            createBallsButton.Location = new Point(713, 12);
            createBallsButton.Name = "createBallsButton";
            createBallsButton.Size = new Size(75, 23);
            createBallsButton.TabIndex = 0;
            createBallsButton.Text = "создать";
            createBallsButton.UseVisualStyleBackColor = true;
            createBallsButton.Click += this.createBallsButton_Click;
            // 
            // getBallsLabel
            // 
            getBallsLabel.AutoSize = true;
            getBallsLabel.Location = new Point(734, 54);
            getBallsLabel.Name = "getBallsLabel";
            getBallsLabel.RightToLeft = RightToLeft.No;
            getBallsLabel.Size = new Size(33, 15);
            getBallsLabel.TabIndex = 1;
            getBallsLabel.Text = "Счет";
            // 
            // scoreBallsLabel
            // 
            scoreBallsLabel.AutoSize = true;
            scoreBallsLabel.Location = new Point(775, 54);
            scoreBallsLabel.Name = "scoreBallsLabel";
            scoreBallsLabel.Size = new Size(13, 15);
            scoreBallsLabel.TabIndex = 2;
            scoreBallsLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreBallsLabel);
            Controls.Add(getBallsLabel);
            Controls.Add(createBallsButton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createBallsButton;
        private Label getBallsLabel;
        private Label scoreBallsLabel;
    }
}
