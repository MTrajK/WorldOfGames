namespace WorldOfGames
{
    partial class FormSnake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSnake));
            this.Slika = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbScore = new System.Windows.Forms.Label();
            this.LbBest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TimerHrana = new System.Windows.Forms.Timer(this.components);
            this.btnTopScorers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Slika)).BeginInit();
            this.SuspendLayout();
            // 
            // Slika
            // 
            this.Slika.BackColor = System.Drawing.Color.Aquamarine;
            this.Slika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Slika.Location = new System.Drawing.Point(12, 34);
            this.Slika.Name = "Slika";
            this.Slika.Size = new System.Drawing.Size(404, 304);
            this.Slika.TabIndex = 0;
            this.Slika.TabStop = false;
            this.Slika.Paint += new System.Windows.Forms.PaintEventHandler(this.Slika_Paint);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Best Score:";
            // 
            // LbScore
            // 
            this.LbScore.AutoSize = true;
            this.LbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScore.Location = new System.Drawing.Point(79, 9);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(19, 20);
            this.LbScore.TabIndex = 3;
            this.LbScore.Text = "0";
            // 
            // LbBest
            // 
            this.LbBest.AutoSize = true;
            this.LbBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBest.Location = new System.Drawing.Point(325, 9);
            this.LbBest.Name = "LbBest";
            this.LbBest.Size = new System.Drawing.Size(19, 20);
            this.LbBest.TabIndex = 4;
            this.LbBest.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(83, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.button1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.button1_PreviewKeyDown);
            // 
            // TimerHrana
            // 
            this.TimerHrana.Interval = 1000;
            this.TimerHrana.Tick += new System.EventHandler(this.TimerHrana_Tick);
            // 
            // btnTopScorers
            // 
            this.btnTopScorers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopScorers.Location = new System.Drawing.Point(235, 344);
            this.btnTopScorers.Name = "btnTopScorers";
            this.btnTopScorers.Size = new System.Drawing.Size(109, 23);
            this.btnTopScorers.TabIndex = 6;
            this.btnTopScorers.Text = "Top Scorers";
            this.btnTopScorers.UseVisualStyleBackColor = true;
            this.btnTopScorers.Click += new System.EventHandler(this.btnTopScorers_Click);
            this.btnTopScorers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnTopScorers_KeyDown);
            // 
            // FormSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 379);
            this.Controls.Add(this.btnTopScorers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbBest);
            this.Controls.Add(this.LbScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Slika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSnake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.Slika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Slika;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbScore;
        private System.Windows.Forms.Label LbBest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer TimerHrana;
        private System.Windows.Forms.Button btnTopScorers;

    }
}

