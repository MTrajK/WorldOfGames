namespace WorldOfGames
{
    partial class Form2048
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2048));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.tb0 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb15 = new System.Windows.Forms.TextBox();
            this.tb14 = new System.Windows.Forms.TextBox();
            this.tb13 = new System.Windows.Forms.TextBox();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.Best = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Vreme = new System.Windows.Forms.Timer(this.components);
            this.Animacija = new System.Windows.Forms.Timer(this.components);
            this.Poeni = new System.Windows.Forms.Label();
            this.Poen = new System.Windows.Forms.Timer(this.components);
            this.btnTopScorers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Score:";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(120, 39);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(120, 24);
            this.Score.TabIndex = 18;
            this.Score.Text = "0000000000";
            this.Score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb0
            // 
            this.tb0.Enabled = false;
            this.tb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb0.Location = new System.Drawing.Point(45, 85);
            this.tb0.Multiline = true;
            this.tb0.Name = "tb0";
            this.tb0.Size = new System.Drawing.Size(44, 38);
            this.tb0.TabIndex = 21;
            this.tb0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb1
            // 
            this.tb1.Enabled = false;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(95, 85);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(44, 38);
            this.tb1.TabIndex = 34;
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb3
            // 
            this.tb3.BackColor = System.Drawing.SystemColors.Window;
            this.tb3.Enabled = false;
            this.tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tb3.Location = new System.Drawing.Point(195, 85);
            this.tb3.Multiline = true;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(44, 38);
            this.tb3.TabIndex = 37;
            this.tb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb2
            // 
            this.tb2.Enabled = false;
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(145, 85);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(44, 38);
            this.tb2.TabIndex = 36;
            this.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb7
            // 
            this.tb7.Enabled = false;
            this.tb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb7.Location = new System.Drawing.Point(195, 129);
            this.tb7.Multiline = true;
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(44, 38);
            this.tb7.TabIndex = 41;
            this.tb7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb6
            // 
            this.tb6.Enabled = false;
            this.tb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6.Location = new System.Drawing.Point(145, 129);
            this.tb6.Multiline = true;
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(44, 38);
            this.tb6.TabIndex = 40;
            this.tb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb5
            // 
            this.tb5.Enabled = false;
            this.tb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb5.Location = new System.Drawing.Point(95, 129);
            this.tb5.Multiline = true;
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(44, 38);
            this.tb5.TabIndex = 39;
            this.tb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb4
            // 
            this.tb4.Enabled = false;
            this.tb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4.Location = new System.Drawing.Point(45, 129);
            this.tb4.Multiline = true;
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(44, 38);
            this.tb4.TabIndex = 38;
            this.tb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb15
            // 
            this.tb15.Enabled = false;
            this.tb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb15.Location = new System.Drawing.Point(195, 217);
            this.tb15.Multiline = true;
            this.tb15.Name = "tb15";
            this.tb15.Size = new System.Drawing.Size(44, 38);
            this.tb15.TabIndex = 49;
            this.tb15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb14
            // 
            this.tb14.Enabled = false;
            this.tb14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb14.Location = new System.Drawing.Point(145, 217);
            this.tb14.Multiline = true;
            this.tb14.Name = "tb14";
            this.tb14.Size = new System.Drawing.Size(44, 38);
            this.tb14.TabIndex = 48;
            this.tb14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb13
            // 
            this.tb13.Enabled = false;
            this.tb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb13.Location = new System.Drawing.Point(95, 217);
            this.tb13.Multiline = true;
            this.tb13.Name = "tb13";
            this.tb13.Size = new System.Drawing.Size(44, 38);
            this.tb13.TabIndex = 47;
            this.tb13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb12
            // 
            this.tb12.Enabled = false;
            this.tb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb12.Location = new System.Drawing.Point(45, 217);
            this.tb12.Multiline = true;
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(44, 38);
            this.tb12.TabIndex = 46;
            this.tb12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb11
            // 
            this.tb11.Enabled = false;
            this.tb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb11.Location = new System.Drawing.Point(195, 173);
            this.tb11.Multiline = true;
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(44, 38);
            this.tb11.TabIndex = 45;
            this.tb11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb10
            // 
            this.tb10.Enabled = false;
            this.tb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb10.Location = new System.Drawing.Point(145, 173);
            this.tb10.Multiline = true;
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(44, 38);
            this.tb10.TabIndex = 44;
            this.tb10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb9
            // 
            this.tb9.Enabled = false;
            this.tb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb9.Location = new System.Drawing.Point(95, 173);
            this.tb9.Multiline = true;
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(44, 38);
            this.tb9.TabIndex = 43;
            this.tb9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb8
            // 
            this.tb8.Enabled = false;
            this.tb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb8.Location = new System.Drawing.Point(45, 173);
            this.tb8.Multiline = true;
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(44, 38);
            this.tb8.TabIndex = 42;
            this.tb8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Best
            // 
            this.Best.AutoSize = true;
            this.Best.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Best.Location = new System.Drawing.Point(120, 9);
            this.Best.Name = "Best";
            this.Best.Size = new System.Drawing.Size(120, 24);
            this.Best.TabIndex = 51;
            this.Best.Text = "0000000000";
            this.Best.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Best:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Time:";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(138, 265);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(21, 24);
            this.Time.TabIndex = 53;
            this.Time.Text = "3";
            this.Time.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "sec";
            // 
            // Vreme
            // 
            this.Vreme.Interval = 1000;
            this.Vreme.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Animacija
            // 
            this.Animacija.Interval = 110;
            this.Animacija.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Poeni
            // 
            this.Poeni.AutoSize = true;
            this.Poeni.BackColor = System.Drawing.Color.Transparent;
            this.Poeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poeni.ForeColor = System.Drawing.Color.Red;
            this.Poeni.Location = new System.Drawing.Point(207, 72);
            this.Poeni.Name = "Poeni";
            this.Poeni.Size = new System.Drawing.Size(0, 15);
            this.Poeni.TabIndex = 55;
            this.Poeni.Visible = false;
            // 
            // Poen
            // 
            this.Poen.Interval = 50;
            this.Poen.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // btnTopScorers
            // 
            this.btnTopScorers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopScorers.Location = new System.Drawing.Point(157, 297);
            this.btnTopScorers.Name = "btnTopScorers";
            this.btnTopScorers.Size = new System.Drawing.Size(119, 26);
            this.btnTopScorers.TabIndex = 56;
            this.btnTopScorers.Text = "Top Scorers";
            this.btnTopScorers.UseVisualStyleBackColor = true;
            this.btnTopScorers.Click += new System.EventHandler(this.btnTopScorers_Click);
            // 
            // Form2048
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(288, 335);
            this.Controls.Add(this.btnTopScorers);
            this.Controls.Add(this.Poeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Best);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb15);
            this.Controls.Add(this.tb14);
            this.Controls.Add(this.tb13);
            this.Controls.Add(this.tb12);
            this.Controls.Add(this.tb11);
            this.Controls.Add(this.tb10);
            this.Controls.Add(this.tb9);
            this.Controls.Add(this.tb8);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tb0);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2048";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.upp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.TextBox tb0;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb15;
        private System.Windows.Forms.TextBox tb14;
        private System.Windows.Forms.TextBox tb13;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.Label Best;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Vreme;
        private System.Windows.Forms.Timer Animacija;
        private System.Windows.Forms.Label Poeni;
        private System.Windows.Forms.Timer Poen;
        private System.Windows.Forms.Button btnTopScorers;
    }
}

