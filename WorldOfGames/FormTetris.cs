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
    public partial class FormTetris : Form
    {
        // boja na pozadina na forma ActiveCaption, MaximizeBox = false, MinimizeBox = false, FormBorderStyle = Fixed3D (za da ima border 3D), KeyPreview = True;
        // boja na pictureBox Aquamarine, BorderStyle = Fixed3D
        // ima 10x20 kocki
        // golemina na pozadina na kocka e 25x25 i pocnuva od nejzinite koordinati
        // a goleminata na vnatresnosta e 21x21 i pocnuva od nejzinite koordinat+2
        // pictureBox go zgolemiv za 4 piksela zaradi ramkata
        // Intervalot ke mi bide cetvrtina sekunda 250 milisekundi
        // Default kaj Color e Color.Empty
        // za sekoja unistena linija se dobivaat random poeni od 23 do 28, no dokolku vo eden cekor se unistat poveke togas za sekoja  naredna linija se dobiva plus random poenite od prethodnata linija
        // a za sekoja padnata forma se dobivaat random poeni od 3 do 8
        // na sekoi pominati 500 poeni se namaluva intervalot na tajmerot za 10% (pobrzo se dvizat formite)

        #region Constructor And Variables

        PointRecords records;
        public string FileName { get; set; }

        private Color [,] matrica;
        private Forma forma;
        private Forma sledna;
        private Random random;
        private bool gameOver;
        private int Score;
        private int BestScore;
        private int Nadminato;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public FormTetris()
        {
            InitializeComponent();
            random = new Random();

            records = new PointRecords();//Goran
            deserijalizacijaRekorderi();
            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, records);
            strm.Close();

            newGame();
        }
        #endregion

        #region Events

        /// <summary>
        /// Цртањето на тетрисот.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paint(object sender, PaintEventArgs e)
        {
            // crtanje na formata
            foreach (Point p in forma.Koordinati)
                if (p.Y != -1)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(p.X * 25-1, p.Y * 25-1, 27, 27));       // -1 i +27 pravam za da celo vreme crnite linii bidat 6 piksela
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(p.X * 25 + 2, p.Y * 25 + 2, 22, 22));       // a ovoj beliot del go stavam za senkata
                    e.Graphics.FillRectangle(new SolidBrush(forma.Boja), new Rectangle(p.X * 25 + 2, p.Y * 25 + 2, 21, 21));
                }

            // crtanje na matricata
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 20; j++)
                    if (matrica[i,j] != Color.Empty)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(i * 25-1, j * 25-1, 27, 27));
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(i * 25 + 2, j * 25 + 2, 22, 22));
                        e.Graphics.FillRectangle(new SolidBrush(matrica[i, j]), new Rectangle(i * 25 + 2, j * 25 + 2, 21, 21));
                    }
        }

        /// <summary>
        /// Цртање на следната фигура.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaintSledno(object sender, PaintEventArgs e)
        {
            int x = 10 , y = 0;

            if (sledna is Forma2)      // za da bide dolgnavestoto vo sredina
                y = -10;
            if (sledna is Forma1 || sledna is Forma2)   // za da bidat tie so po 3 dolzina vo sredina
                x = 0;
           
            foreach (Point p in sledna.Koordinati)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle((p.X - 2) * 20 + x - 1, (p.Y + 2) * 20 + y - 1, 22, 22));
                e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle((p.X - 2) * 20 + 2 + x, (p.Y + 2) * 20 + 2 + y, 17, 17));
                e.Graphics.FillRectangle(new SolidBrush(sledna.Boja), new Rectangle((p.X - 2) * 20 + 2 + x, (p.Y + 2) * 20 + 2 + y, 16, 16));
            }
        }

        /// <summary>
        /// Со секое отчукување се движи формата надолу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            Pomesti(0);
        }

        /// <summary>
        /// Се наоѓа кое копче е стиснато, не го правам со евентот KeyDown, KeyUp... бидејќи pictureBox што нема такви евенти, а ако го ставам на формата, тогаш копчето ги превзема тие евенти.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (gameOver)
                return base.ProcessCmdKey(ref msg, keyData);

            if (keyData == Keys.Down)
                Pomesti(0);
            else if (keyData == Keys.Left)
                Pomesti(1);
            else if (keyData == Keys.Right)
                Pomesti(2);
            else if (keyData == Keys.Up)
                Pomesti(3);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Се креира нова игра, но доколку не е завршена се прашува дали да ја прекине оваа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (MessageBox.Show("New Game", "Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    newGame();
            }
            else
                newGame();
        }
        #endregion
        
        #region Logic

        /// <summary>
        /// Се креира нова игра, се ресетираат сите вредности.
        /// </summary>
        private void newGame()
        {
            btnTopScorers.Enabled = false;
            matrica = new Color[10, 20];
            sledna = Forma.Odberi(random.Next(7));
            gameOver = false;
            Score = 0;
            Nadminato = 500;
            lbScore.Text = "0";
            NovaForma();
            Timer.Start();
            if (records.players.Count == 0)
            {
                lbBest.Text = "0";
            }
            else
            {
                lbBest.Text = records.players[0].Points.ToString();
            }

            pbTetris.Invalidate();
        }

        /// <summary>
        /// Крај на играта, го стопира тајмерот и се појавува MessageBox.
        /// </summary>
        private void GameOver()
        {
            gameOver = true;
            Timer.Stop();
            btnTopScorers.Enabled = true;
            BestScore = Math.Max(BestScore, Score);
            records.addPlayer(new PlayerWithPoints(MainForm.name, Score));
            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, records);
            fmt.Serialize(strm, BestScore);
            strm.Close();

            MessageBox.Show("Score: "+Score, "Game Over", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Се генерира нова форма.
        /// </summary>
        public void NovaForma()
        {
            forma = sledna;
            sledna = Forma.Odberi(random.Next(7));
            pbSledno.Invalidate();

            if (!Validno(forma.Koordinati))
                GameOver();
            else
                pbTetris.Invalidate();
        }

        /// <summary>
        /// Овде се вршат сите проверки на движења и дали да се креира нова форма.
        /// </summary>
        /// <param name="broj"> 0- надоле, 1- лево, 2- десно, 3- врти.</param>
        public void Pomesti(int broj)
        {
            List<Point> lista;

            if (broj == 3)
                lista = forma.Vrti();
            else
                lista = forma.Pomesti(broj);

            if (Validno(lista))
            {
                forma.Smeni();
                pbTetris.Invalidate();
            }
            else if (broj == 0) // dokolku dolnoto dvizenje ne e validno togas, treba da se zacuvaat koordinatite vo matricata i da se generira nova forma i dokolku nekoja linija e polna se ponistuva
            {
                if (Validno(forma.Koordinati))
                {
                    foreach (Point p in forma.Koordinati)
                        if (p.Y != -1) matrica[p.X, p.Y] = forma.Boja;

                    Ponistuvanje();
                    NovaForma();
                }
                else
                    GameOver();
            }
        }

        /// <summary>
        /// Проверува дали е валидна новата позиција (дали полињата од матрицата се слободни, а слободно е ако е empty обоено) и ако е надвор од границите, но и ако Y е -1 и тоа е валидно.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public bool Validno(List<Point> lista)
        {
            foreach (Point p in lista)
                if (p.X < 0 || p.X > 9 || p.Y > 19 || (p.Y > -1 && matrica[p.X, p.Y] != Color.Empty))
                    return false;   
                    
            return true;
        }

        /// <summary>
        /// Доколку некоја редица е полна со коцки, тогаш ја поништувам така пто ги спуштам редиците за една се до таа редица. Но исто така со овој метод се поставуваат скоровите и се намалува интервалот на тајмерот.
        /// </summary>
        private void Ponistuvanje()
        {
            int BrLinii = 0;

            for (int j = 19; j >= 0; j--)
            {
                bool ponisti = true;

                for (int i = 0; i < 10; i++)
                    if (matrica[i,j] == Color.Empty)
                    {
                        ponisti = false;
                        break;
                    }
                
                if (ponisti)
                {
                    BrLinii++;

                    for (int i = 0; i < 10; i++)        // gi spustam redicite za edno nadole
                        for (int o = j; o > 0; o-- )
                            matrica[i, o] = matrica[i, o-1];

                    for (int i = 0; i < 10; i++)        // prvata redica ja pravam prazna
                        matrica[i, 0] = Color.Empty;

                    j++;
                }

            }

            int rand = random.Next(3, 8);
            Score += rand;         // plus 5 za padnatoto delce

            if (BrLinii > 0)    // dokolku barem edna linija se ponistila
                Score += ((BrLinii * (BrLinii + 1)) / 2) * (20 + rand);    // tuka ja koristam formulata za suma n*(n+1)/2 и по 10 бода за линиите
          
            lbScore.Text = Score.ToString();

            if (Score > BestScore)      // vaka pravam za da ne se pisuva celo vreme rezultatot na best (zosto nema smisla ako pocnam nova igra, celo vreme ke bide pomal i treba toj da si ostane)
            {
                BestScore = Score;
                lbBest.Text = BestScore.ToString();
            }

            // namaluvanje na intervalot
            if (Score > Nadminato)
            {
                Timer.Interval -= (Timer.Interval / 10);
                Nadminato += 500;
            }
        }
        #endregion

        private void btnTopScorers_Click(object sender, EventArgs e)
        {
            MessageBox.Show(records.ToString(), "Top Scorers");
        }

        #region Deserialization

        private void deserijalizacijaRekorderi()
        {
            try
            {
                FileName = "tetrisRecords.rk";
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                records = (PointRecords)fmt.Deserialize(strm);

                strm.Close();
            }
            catch (Exception e) { }
        }

        #endregion

       
        
    }
}
