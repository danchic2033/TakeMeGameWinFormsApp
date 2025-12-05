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
            createBallsButton = new Button();
            stopAllButton = new Button();
            SuspendLayout();
            // 
            // createBallsButton
            // 
            createBallsButton.Location = new Point(504, 12);
            createBallsButton.Name = "createBallsButton";
            createBallsButton.Size = new Size(107, 40);
            createBallsButton.TabIndex = 0;
            createBallsButton.Text = "Создать";
            createBallsButton.UseVisualStyleBackColor = true;
            createBallsButton.Click += createBallsButton_Click;
            // 
            // stopAllButton
            // 
            stopAllButton.Location = new Point(617, 12);
            stopAllButton.Name = "stopAllButton";
            stopAllButton.Size = new Size(103, 40);
            stopAllButton.TabIndex = 1;
            stopAllButton.Text = "Остановить ";
            stopAllButton.UseVisualStyleBackColor = true;
            stopAllButton.Click += stopAllButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(stopAllButton);
            Controls.Add(createBallsButton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button createBallsButton;
        private Button stopAllButton;
    }
}
