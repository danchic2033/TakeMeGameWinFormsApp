namespace BilliardGameWinFormsApp
{
    partial class Form1
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
            leftSideLabel = new Label();
            topSideLabel = new Label();
            rightSideLabel = new Label();
            downSideLabel = new Label();
            SuspendLayout();
            // 
            // leftSideLabel
            // 
            leftSideLabel.AutoSize = true;
            leftSideLabel.Location = new Point(8, 184);
            leftSideLabel.Name = "leftSideLabel";
            leftSideLabel.Size = new Size(13, 15);
            leftSideLabel.TabIndex = 0;
            leftSideLabel.Text = "0";
            // 
            // topSideLabel
            // 
            topSideLabel.AutoSize = true;
            topSideLabel.Location = new Point(369, 9);
            topSideLabel.Name = "topSideLabel";
            topSideLabel.Size = new Size(13, 15);
            topSideLabel.TabIndex = 1;
            topSideLabel.Text = "0";
            // 
            // rightSideLabel
            // 
            rightSideLabel.AutoSize = true;
            rightSideLabel.Location = new Point(775, 184);
            rightSideLabel.Name = "rightSideLabel";
            rightSideLabel.Size = new Size(13, 15);
            rightSideLabel.TabIndex = 2;
            rightSideLabel.Text = "0";
            // 
            // downSideLabel
            // 
            downSideLabel.AutoSize = true;
            downSideLabel.Location = new Point(369, 426);
            downSideLabel.Name = "downSideLabel";
            downSideLabel.Size = new Size(13, 15);
            downSideLabel.TabIndex = 3;
            downSideLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(downSideLabel);
            Controls.Add(rightSideLabel);
            Controls.Add(topSideLabel);
            Controls.Add(leftSideLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftSideLabel;
        private Label topSideLabel;
        private Label rightSideLabel;
        private Label downSideLabel;
    }
}
