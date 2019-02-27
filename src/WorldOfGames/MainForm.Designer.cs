namespace WorldOfGames
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.play2048 = new System.Windows.Forms.Button();
            this.playFlappyBird = new System.Windows.Forms.Button();
            this.playSnake = new System.Windows.Forms.Button();
            this.playMinesweeper = new System.Windows.Forms.Button();
            this.playTetris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // play2048
            // 
            this.play2048.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play2048.Location = new System.Drawing.Point(258, 53);
            this.play2048.Name = "play2048";
            this.play2048.Size = new System.Drawing.Size(145, 42);
            this.play2048.TabIndex = 0;
            this.play2048.Text = "2048";
            this.play2048.UseVisualStyleBackColor = true;
            this.play2048.Click += new System.EventHandler(this.play2048_Click);
            // 
            // playFlappyBird
            // 
            this.playFlappyBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playFlappyBird.Location = new System.Drawing.Point(258, 103);
            this.playFlappyBird.Name = "playFlappyBird";
            this.playFlappyBird.Size = new System.Drawing.Size(145, 42);
            this.playFlappyBird.TabIndex = 1;
            this.playFlappyBird.Text = "Flappy Bird";
            this.playFlappyBird.UseVisualStyleBackColor = true;
            this.playFlappyBird.Click += new System.EventHandler(this.playFlappyBird_Click);
            // 
            // playSnake
            // 
            this.playSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playSnake.Location = new System.Drawing.Point(258, 206);
            this.playSnake.Name = "playSnake";
            this.playSnake.Size = new System.Drawing.Size(145, 42);
            this.playSnake.TabIndex = 3;
            this.playSnake.Text = "Snake";
            this.playSnake.UseVisualStyleBackColor = true;
            this.playSnake.Click += new System.EventHandler(this.playSnake_Click);
            // 
            // playMinesweeper
            // 
            this.playMinesweeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playMinesweeper.Location = new System.Drawing.Point(258, 156);
            this.playMinesweeper.Name = "playMinesweeper";
            this.playMinesweeper.Size = new System.Drawing.Size(145, 42);
            this.playMinesweeper.TabIndex = 2;
            this.playMinesweeper.Text = "Minesweeper";
            this.playMinesweeper.UseVisualStyleBackColor = true;
            this.playMinesweeper.Click += new System.EventHandler(this.playMinesweeper_Click);
            // 
            // playTetris
            // 
            this.playTetris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playTetris.Location = new System.Drawing.Point(258, 257);
            this.playTetris.Name = "playTetris";
            this.playTetris.Size = new System.Drawing.Size(145, 42);
            this.playTetris.TabIndex = 4;
            this.playTetris.Text = "Tetris";
            this.playTetris.UseVisualStyleBackColor = true;
            this.playTetris.Click += new System.EventHandler(this.playTetris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to World Of Games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(267, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose Game:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(15, 103);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 24);
            this.tbName.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 323);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playTetris);
            this.Controls.Add(this.playSnake);
            this.Controls.Add(this.playMinesweeper);
            this.Controls.Add(this.playFlappyBird);
            this.Controls.Add(this.play2048);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Of Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play2048;
        private System.Windows.Forms.Button playFlappyBird;
        private System.Windows.Forms.Button playSnake;
        private System.Windows.Forms.Button playMinesweeper;
        private System.Windows.Forms.Button playTetris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbName;
    }
}

