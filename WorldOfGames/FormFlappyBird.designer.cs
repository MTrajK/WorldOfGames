namespace WorldOfGames
{
    partial class FormFlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlappyBird));
            this.pbIgra = new System.Windows.Forms.PictureBox();
            this.TimerPozadina = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbBest = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnTopScorers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbIgra)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIgra
            // 
            this.pbIgra.BackColor = System.Drawing.Color.Aquamarine;
            this.pbIgra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbIgra.Location = new System.Drawing.Point(12, 12);
            this.pbIgra.Name = "pbIgra";
            this.pbIgra.Size = new System.Drawing.Size(244, 364);
            this.pbIgra.TabIndex = 0;
            this.pbIgra.TabStop = false;
            this.pbIgra.Paint += new System.Windows.Forms.PaintEventHandler(this.Crta);
            // 
            // TimerPozadina
            // 
            this.TimerPozadina.Interval = 80;
            this.TimerPozadina.Tick += new System.EventHandler(this.TimerPozadina_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Best Score:";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(283, 95);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(17, 18);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "0";
            // 
            // lbBest
            // 
            this.lbBest.AutoSize = true;
            this.lbBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBest.Location = new System.Drawing.Point(283, 237);
            this.lbBest.Name = "lbBest";
            this.lbBest.Size = new System.Drawing.Size(17, 18);
            this.lbBest.TabIndex = 4;
            this.lbBest.Text = "0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(262, 305);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(106, 23);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnTopScorers
            // 
            this.btnTopScorers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopScorers.Location = new System.Drawing.Point(262, 334);
            this.btnTopScorers.Name = "btnTopScorers";
            this.btnTopScorers.Size = new System.Drawing.Size(106, 23);
            this.btnTopScorers.TabIndex = 6;
            this.btnTopScorers.Text = "Top Scorers";
            this.btnTopScorers.UseVisualStyleBackColor = true;
            this.btnTopScorers.Click += new System.EventHandler(this.btnTopScorers_Click);
            // 
            // FormFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(380, 389);
            this.Controls.Add(this.btnTopScorers);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lbBest);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbIgra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Skoka);
            ((System.ComponentModel.ISupportInitialize)(this.pbIgra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIgra;
        private System.Windows.Forms.Timer TimerPozadina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbBest;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnTopScorers;
    }
}

