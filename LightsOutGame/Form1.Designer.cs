namespace LightsOutGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GameWindow = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numMovesText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bestScoreText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.Black;
            this.resetBtn.Location = new System.Drawing.Point(216, 383);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(96, 31);
            this.resetBtn.TabIndex = 0;
            this.resetBtn.Text = "New Game";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 147);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lights Out\r\n\r\nThe aim of the game is to turn all the lights out. \r\nWhen a light i" +
    "s clicked the four adjacent\r\nlights will toggle.\r\n \r\nTry and solve the puzzle in" +
    " as few moves as possible!";
            // 
            // GameWindow
            // 
            this.GameWindow.Location = new System.Drawing.Point(12, 67);
            this.GameWindow.Margin = new System.Windows.Forms.Padding(0);
            this.GameWindow.Name = "GameWindow";
            this.GameWindow.Size = new System.Drawing.Size(332, 303);
            this.GameWindow.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moves:";
            // 
            // numMovesText
            // 
            this.numMovesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMovesText.Location = new System.Drawing.Point(239, 29);
            this.numMovesText.Name = "numMovesText";
            this.numMovesText.Size = new System.Drawing.Size(73, 31);
            this.numMovesText.TabIndex = 4;
            this.numMovesText.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Best:";
            // 
            // bestScoreText
            // 
            this.bestScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestScoreText.Location = new System.Drawing.Point(61, 29);
            this.bestScoreText.Name = "bestScoreText";
            this.bestScoreText.Size = new System.Drawing.Size(69, 31);
            this.bestScoreText.TabIndex = 6;
            this.bestScoreText.TextChanged += new System.EventHandler(this.bestScoreText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(959, 522);
            this.Controls.Add(this.bestScoreText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMovesText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameWindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel GameWindow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numMovesText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bestScoreText;
    }
}

