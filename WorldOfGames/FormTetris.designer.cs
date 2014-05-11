namespace WorldOfGames
{
    partial class FormTetris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTetris));
            this.pbTetris = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pbSledno = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbBest = new System.Windows.Forms.Label();
            this.btnTopScorers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTetris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSledno)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTetris
            // 
            this.pbTetris.BackColor = System.Drawing.Color.Aquamarine;
            this.pbTetris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbTetris.Location = new System.Drawing.Point(12, 12);
            this.pbTetris.Name = "pbTetris";
            this.pbTetris.Size = new System.Drawing.Size(254, 504);
            this.pbTetris.TabIndex = 0;
            this.pbTetris.TabStop = false;
            this.pbTetris.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint);
            // 
            // Timer
            // 
            this.Timer.Interval = 250;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pbSledno
            // 
            this.pbSledno.BackColor = System.Drawing.Color.Aquamarine;
            this.pbSledno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSledno.Location = new System.Drawing.Point(279, 12);
            this.pbSledno.Name = "pbSledno";
            this.pbSledno.Size = new System.Drawing.Size(120, 80);
            this.pbSledno.TabIndex = 1;
            this.pbSledno.TabStop = false;
            this.pbSledno.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintSledno);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(279, 436);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(127, 30);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.TabStop = false;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Best Score:";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(278, 181);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(19, 20);
            this.lbScore.TabIndex = 5;
            this.lbScore.Text = "0";
            // 
            // lbBest
            // 
            this.lbBest.AutoSize = true;
            this.lbBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBest.Location = new System.Drawing.Point(278, 318);
            this.lbBest.Name = "lbBest";
            this.lbBest.Size = new System.Drawing.Size(19, 20);
            this.lbBest.TabIndex = 6;
            this.lbBest.Text = "0";
            // 
            // btnTopScorers
            // 
            this.btnTopScorers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopScorers.Location = new System.Drawing.Point(279, 484);
            this.btnTopScorers.Name = "btnTopScorers";
            this.btnTopScorers.Size = new System.Drawing.Size(127, 30);
            this.btnTopScorers.TabIndex = 7;
            this.btnTopScorers.TabStop = false;
            this.btnTopScorers.Text = "Top Scorers";
            this.btnTopScorers.UseVisualStyleBackColor = true;
            this.btnTopScorers.Click += new System.EventHandler(this.btnTopScorers_Click);
            // 
            // FormTetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 526);
            this.Controls.Add(this.btnTopScorers);
            this.Controls.Add(this.lbBest);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pbSledno);
            this.Controls.Add(this.pbTetris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTetris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            ((System.ComponentModel.ISupportInitialize)(this.pbTetris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSledno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTetris;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox pbSledno;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbBest;
        private System.Windows.Forms.Button btnTopScorers;
    }
}

