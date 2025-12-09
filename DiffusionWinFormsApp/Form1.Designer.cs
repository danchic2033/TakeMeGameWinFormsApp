namespace DiffusionWinFormsApp
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
            blackLeftLabel = new Label();
            blueLeftLabel = new Label();
            blackTopLabel = new Label();
            blueTopLabel = new Label();
            blackRightLabel = new Label();
            blueRightLabel = new Label();
            blackDownLabel = new Label();
            blueDownLabel = new Label();
            SuspendLayout();
            // 
            // blackLeftLabel
            // 
            blackLeftLabel.AutoSize = true;
            blackLeftLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            blackLeftLabel.Location = new Point(11, 163);
            blackLeftLabel.Name = "blackLeftLabel";
            blackLeftLabel.Size = new Size(19, 21);
            blackLeftLabel.TabIndex = 0;
            blackLeftLabel.Text = "0";
            // 
            // blueLeftLabel
            // 
            blueLeftLabel.AutoSize = true;
            blueLeftLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            blueLeftLabel.ForeColor = SystemColors.MenuHighlight;
            blueLeftLabel.Location = new Point(15, 194);
            blueLeftLabel.Name = "blueLeftLabel";
            blueLeftLabel.Size = new Size(19, 21);
            blueLeftLabel.TabIndex = 1;
            blueLeftLabel.Text = "0";
            // 
            // blackTopLabel
            // 
            blackTopLabel.AutoSize = true;
            blackTopLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            blackTopLabel.Location = new Point(317, 10);
            blackTopLabel.Name = "blackTopLabel";
            blackTopLabel.Size = new Size(19, 21);
            blackTopLabel.TabIndex = 2;
            blackTopLabel.Text = "0";
            // 
            // blueTopLabel
            // 
            blueTopLabel.AutoSize = true;
            blueTopLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            blueTopLabel.ForeColor = SystemColors.MenuHighlight;
            blueTopLabel.Location = new Point(371, 14);
            blueTopLabel.Name = "blueTopLabel";
            blueTopLabel.Size = new Size(19, 21);
            blueTopLabel.TabIndex = 3;
            blueTopLabel.Text = "0";
            // 
            // blackRightLabel
            // 
            blackRightLabel.AutoSize = true;
            blackRightLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            blackRightLabel.Location = new Point(747, 160);
            blackRightLabel.Name = "blackRightLabel";
            blackRightLabel.Size = new Size(19, 21);
            blackRightLabel.TabIndex = 4;
            blackRightLabel.Text = "0";
            // 
            // blueRightLabel
            // 
            blueRightLabel.AutoSize = true;
            blueRightLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            blueRightLabel.ForeColor = SystemColors.MenuHighlight;
            blueRightLabel.Location = new Point(754, 195);
            blueRightLabel.Name = "blueRightLabel";
            blueRightLabel.Size = new Size(19, 21);
            blueRightLabel.TabIndex = 5;
            blueRightLabel.Text = "0";
            // 
            // blackDownLabel
            // 
            blackDownLabel.AutoSize = true;
            blackDownLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            blackDownLabel.Location = new Point(329, 418);
            blackDownLabel.Name = "blackDownLabel";
            blackDownLabel.Size = new Size(19, 21);
            blackDownLabel.TabIndex = 6;
            blackDownLabel.Text = "0";
            // 
            // blueDownLabel
            // 
            blueDownLabel.AutoSize = true;
            blueDownLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            blueDownLabel.ForeColor = SystemColors.MenuHighlight;
            blueDownLabel.Location = new Point(398, 421);
            blueDownLabel.Name = "blueDownLabel";
            blueDownLabel.Size = new Size(19, 21);
            blueDownLabel.TabIndex = 7;
            blueDownLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(blueDownLabel);
            Controls.Add(blackDownLabel);
            Controls.Add(blueRightLabel);
            Controls.Add(blackRightLabel);
            Controls.Add(blueTopLabel);
            Controls.Add(blackTopLabel);
            Controls.Add(blueLeftLabel);
            Controls.Add(blackLeftLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label blackLeftLabel;
        private Label blueLeftLabel;
        private Label blackTopLabel;
        private Label blueTopLabel;
        private Label blackRightLabel;
        private Label blueRightLabel;
        private Label blackDownLabel;
        private Label blueDownLabel;
    }
}
