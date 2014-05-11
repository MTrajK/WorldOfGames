using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfGames
{
    public partial class FormMinesweeper : Form
    {
        #region Variables And Constructor

        TimeRecords records;
        public string FileName { get; set; }

        private Button[,] pole;
        private int[,] vrednosti;
        private List<Point> bombi;
        private Random random;
        private int slobodni;
        private int best;
        private int vreme;
        private bool over;

        /// <summary>
        /// Default constructor. Само кога ќе се уклучи играта ги креирам копчињата (полињата) а не при секоја нова игра (не би било ни така проблем, не би кочело амаа нема потреба од такви креирања).
        /// </summary>
        public FormMinesweeper()
        {
            InitializeComponent();
            best = 999;
            pole = new Button[10, 10];

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    pole[i, j] = new Button();
                    pole[i, j].Location = new Point(-i + 20 + 25 * i, -j + 50 + 25 * j);
                    pole[i, j].Size = new Size(25, 25);
                    pole[i, j].Text = "";
                    pole[i, j].TabIndex = i * 10 + j + 1;
                    pole[i, j].BackColor = Color.WhiteSmoke;
                    pole[i, j].Font = new Font(pole[i, j].Font.FontFamily, 11, FontStyle.Bold);
                    pole[i, j].MouseDown += new MouseEventHandler(MausKlik);    // na sekoe kopcce mu go dodavam eventot za klik (so MouseDown se fakaat eventi i od lev i od desen klik)
                    Controls.Add(pole[i, j]);                         // dodava na formata                  
                }
            records = new TimeRecords();//Goran
            deserijalizacijaRekorderi();
            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, records);
            strm.Close();

            newGame();
        }

        #endregion

        #region Start And End Game

        /// <summary>
        /// Нова игра, се ресетираат вредностите, се ставаат бомби и се креира матрицата со вредностите на полињата(колку бомби има околу тоа поле).
        /// </summary>
        private void newGame()
        {
            btnTopScorers.Enabled = false;
            vrednosti = new int[10, 10];
            bombi = new List<Point>();
            random = new Random();
            over = false;
            slobodni = 100;
            vreme = 0;
            timer.Start();

            Score.Text = vreme.ToString();
            BestScore.Text = records.players[0].Time.ToString();

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    pole[i, j].Text = "";
                    pole[i, j].BackColor = Color.WhiteSmoke;
                }

            for (int br = 0; br < 15; br++) 
            {
                int i = random.Next(10), j = random.Next(10);
                Point p = new Point(i, j);

                if (bombi.Contains(p))  // ako postoi baraj drugo
                {
                    br--;
                    continue;
                }

                bombi.Add(p);

                // polnenje na tabelata so vrednosti (kolku mini ima vo okolina na sekoe pole)
                if (i > 0)
                {
                    vrednosti[i - 1, j]++;

                    if (j > 0)
                        vrednosti[i - 1, j - 1]++;

                    if (j < 9)
                        vrednosti[i - 1, j + 1]++;
                }

                if (i < 9)
                {
                    vrednosti[i + 1, j]++;

                    if (j > 0)
                        vrednosti[i + 1, j - 1]++;

                    if (j < 9)
                        vrednosti[i + 1, j + 1]++;
                }

                if (j > 0)
                    vrednosti[i, j - 1]++;

                if (j < 9)
                    vrednosti[i, j + 1]++;
            }
        }

        /// <summary>
        /// Крај на игра, се споредуваат скоровите (доколку е успешно завршена играта).
        /// </summary>
        private void gameOver()
        {
            btnTopScorers.Enabled = true;
            timer.Stop();
            over = true;

            if (slobodni == 15 && vreme < best) // ako se najdeni site bombi
                best = vreme;

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    oboi(new Point(i, j));

            if (slobodni == 15) {
                MessageBox.Show("Time: " + vreme.ToString(), "Congratulations!", MessageBoxButtons.OK);
                records.addPlayer(new PlayerWithTime(MainForm.name, vreme));
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, records);
                strm.Close();
            }
            else
                MessageBox.Show("Booooomb!", "Game Over", MessageBoxButtons.OK);
        }

        #endregion

        #region Event

        /// <summary>
        /// Тајмер за времето (скорот).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            vreme++;
            Score.Text = vreme.ToString();

            if (vreme == 999)
                gameOver();
        }

        /// <summary>
        /// Евент за нова игра, доколку во тек е игра тогаш се поставува прашање.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!over && MessageBox.Show("Really?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                newGame();
            else if (over)
                newGame();
        }

        /// <summary>
        /// Евент за клик со маус на некое од копчињата (лев или десен клик).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MausKlik(object sender, MouseEventArgs e)
        {
            Button Kliknato = (Button)sender;

            if (over)                                 // dali e zavrsena (a i ne mora da stoi ova)
                return;

            if (e.Button == MouseButtons.Right)
                desenKlik(Kliknato);
            else
                levKlik(Kliknato);
        }

        private void btnTopScorers_Click(object sender, EventArgs e)//Goran
        {
            MessageBox.Show(records.ToString());
        }

        #endregion

        #region Game Logics
        
        /// <summary>
        /// Десен клик на копче (поставување знаменце).
        /// </summary>
        /// <param name="b"></param>
        private void desenKlik(Button b)
        {
            if (b.BackColor == Color.Gainsboro) // dali e otvoreno
                return;

            if (b.BackColor == Color.Red)
                b.BackColor = Color.WhiteSmoke;
            else
                b.BackColor = Color.Red;
        }

        /// <summary>
        /// Лев клик на копче (отварање поле).
        /// </summary>
        /// <param name="b"></param>
        private void levKlik(Button b)
        {
           Point p = najdiKoor(b);

           DFS(p);
        }

        /// <summary>
        /// Метод за барање на позицијата на копчето во матрицата од копчиња.
        /// </summary>
        /// <param name="button"></param>
        /// <returns></returns>
        private Point najdiKoor(Button button)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (button.Equals(pole[i, j]))
                        return new Point(i, j);
            return new Point();
        }

        /// <summary>
        /// Отварањето на поле/иња со ДФС (може и со БФС нема разлика во комплексност).
        /// Доколку полето има вредност 0 (нема бомби околу) тогаш се проверуваат и околните 8 полиња дали се празни и доколку се се отвараат.
        /// Како што секој ДФС (рекурзија) мора да има крај, крајот на овој метод е ако полето има вредност поголема од 0, ако е бомба или пак ако има поставено знаменце.
        /// </summary>
        /// <param name="p"></param>
        private void DFS(Point p)
        {
            int i = p.X, j = p.Y;

            if (pole[i, j].BackColor == Color.Red || pole[i, j].BackColor == Color.Gainsboro)   // krajot na dfs (granicata) ili znamence ili otvoreno
                return;

            if (bombi.Contains(p))  // najdeno e bomba zavrsuva igrata
            {
                gameOver();
                return;
            }

            oboi(p);
            slobodni--;

            if (slobodni == 15) // zavrsila igrata site se najdeni bombi
            {
                gameOver();
                return;
            }

            if (vrednosti[i, j] != 0)
                return;

            // dfs

            if (i > 0) 
            {
                DFS(new Point(i - 1, j));

                if (j > 0)
                    DFS(new Point(i - 1, j - 1));

                if (j < 9)
                    DFS(new Point(i - 1, j + 1));
            }

            if (i < 9) 
            {
                DFS(new Point(i + 1, j));

                if (j > 0)
                    DFS(new Point(i + 1, j - 1));

                if (j < 9)
                    DFS(new Point(i + 1, j + 1));
            }

            if (j > 0)
                DFS(new Point(i, j - 1));

            if (j < 9)
                DFS(new Point(i, j + 1));
        }

        /// <summary>
        /// Се бои (и се впишува вредност во полето) при секој клик.
        /// </summary>
        /// <param name="p"></param>
        private void oboi(Point p)
        {
            if (bombi.Contains(p))
            {
                pole[p.X, p.Y].BackColor = Color.Black;
                return;
            }

            pole[p.X, p.Y].BackColor = Color.Gainsboro;

            if (vrednosti[p.X, p.Y] == 0)
                pole[p.X, p.Y].Text = "";
            else
                pole[p.X, p.Y].Text = vrednosti[p.X, p.Y].ToString();

            switch (vrednosti[p.X, p.Y])
            {
                case 1:
                    pole[p.X, p.Y].ForeColor = Color.Blue;
                    break;
                case 2:
                    pole[p.X, p.Y].ForeColor = Color.Green;
                    break;
                case 3:
                    pole[p.X, p.Y].ForeColor = Color.Red;
                    break;
                case 4:
                    pole[p.X, p.Y].ForeColor = Color.Purple;
                    break;
                case 5:
                    pole[p.X, p.Y].ForeColor = Color.Orange;
                    break;
                case 6:
                    pole[p.X, p.Y].ForeColor = Color.DarkGreen;
                    break;
                case 7:
                    pole[p.X, p.Y].ForeColor = Color.Cyan;
                    break;
                case 8:
                    pole[p.X, p.Y].ForeColor = Color.Yellow;
                    break;
            }
        }

        #endregion

        #region Deserialization

        private void deserijalizacijaRekorderi()
        {
            try
            {
                FileName = "mineSweeperRecords.rk";
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                records = (TimeRecords)fmt.Deserialize(strm);
                strm.Close();
            }
            catch (Exception e) { }
        }

        #endregion

        
    }
}