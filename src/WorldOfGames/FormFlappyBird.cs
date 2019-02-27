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
    public partial class FormFlappyBird : Form
    {

        PointRecords records;
        public string FileName { get; set; }

        // slikata ke mi bide matrica 24x36, polinjata ke bidat so golemina 10x10
        // igrata zapocnuva koga ke se pritisne Up kopceto (koga ke poleta pticata)

        #region Constructor and Variables

        List<Stolb> stolbovi;     // gi sodrzi koordinatite i visinite na stolbovite
        bool prvaKocka;
        int timerBrojac;
        Random random;
        Point ptica;
        bool skoknato;
        bool gameOver;
        bool crtaj;
        int score;
        int bestScore;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public FormFlappyBird()
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
        /// Притискање на копчето Up (единственото копче на играта, за скокање).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Skoka(object sender, KeyEventArgs e)
        {
            if (!gameOver)
                if (e.KeyCode == Keys.Up)
                {
                    crtaj = true;
                    ptica.Y -= 4;
                    skoknato = true;
                }
        }

        /// <summary>
        /// Методот за цртање кој се повикува преку методот на picture box pbIgra.Invalidate().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Crta(object sender, PaintEventArgs e)
        {
            if (!Validno())
                gameOver = true;

            if (ptica.Y == 34)
            {
                GameOver();
                ptica.Y -= 1;
            }

            // crtanje stolbovite

            bool brisiPrv = false;

            foreach (Stolb st in stolbovi)
            {
                int x = st.XKoord;        // i voedno se koordinatata ide levo
                if (!gameOver)
                    x = --st.XKoord;

                int dolnaVisina = st.Visina;
                int gornaVisina = st.GornaVisina;

                if (x == -4)
                {
                    brisiPrv = true;    // go brisam zatoa sto ne se gleda veke
                    continue;
                }

                // dolniot stolb
                for (int j = 0; j < dolnaVisina; j++)
                {
                    // tuka gi crta i onie nevidlivite koordinati (onie vo - ili nad 24, amaa nema potreba da go ogranicuvam zosto i onaka ne se gledaat gicrta na nevidni polinja
                    e.Graphics.FillRectangle(new SolidBrush(Color.Black), x * 10 - 3, (34 - j) * 10 - 3, 13, 13);   // crnoto od strana
                    
                    if (j == dolnaVisina - 1)           // gi crta cetirite krajni najgore
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), x * 10, (34 - j) * 10 - 3, 13, 13);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), (x + 1) * 10, (34 - j) * 10 - 3, 13, 13);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), (x + 2) * 10, (34 - j) * 10 - 3, 13, 13);
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), x * 10, (34 - j) * 10 - 1, 11, 11);
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), (x + 1) * 10, (34 - j) * 10 - 1, 11, 11);
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), (x + 2) * 10, (34 - j) * 10 - 1, 11, 11);
                    }

                   e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), x * 10, (34 - j) * 10, 10, 10);

                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), (x + 1) * 10, (34 - j) * 10, 10, 10);
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), (x + 2) * 10, (34 - j) * 10, 10, 10);

                    e.Graphics.FillRectangle(new SolidBrush(Color.Black), (x + 3) * 10, (34 - j) * 10 - 3, 13, 13);   // crnoto od strana
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), (x + 3) * 10, (34 - j) * 10 - 1, 11, 11);   // beloto
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), (x + 3) * 10, (34 - j) * 10, 10, 10);
                }

                // gorniot stolb
                for (int j = 0; j < gornaVisina; j++)
                {

                    // tuka gi crta i onie nevidlivite koordinati (onie vo - ili nad 24, amaa nema potreba da go ogranicuvam zosto i onaka ne se gledaat gicrta na nevidni polinja
                    e.Graphics.FillRectangle(new SolidBrush(Color.Black), x * 10 - 3, j * 10, 13, 13);   // crnoto od strana

                    if (j == gornaVisina - 1)           // gi crta cetirite krajni najgore
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), x * 10,  j * 10, 13, 13);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), (x + 1) * 10, j * 10, 13, 13);
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), (x + 2) * 10, j * 10, 13, 13);
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), x * 10, j * 10, 11, 11);
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), (x + 1) * 10, j * 10, 11, 11);
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), (x + 2) * 10, j * 10, 11, 11);
                    }

                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), x * 10, j * 10, 10, 10);

                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), (x + 1) * 10, j * 10, 10, 10);
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), (x + 2) * 10, j * 10, 10, 10);

                    e.Graphics.FillRectangle(new SolidBrush(Color.Black), (x + 3) * 10, j * 10, 13, 13);   // crnoto od strana
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), (x + 3) * 10, j * 10, 11, 11);   // beloto
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), (x + 3) * 10, j * 10, 10, 10);
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), x * 10, j * 10, 10, 10);
                }
            }

            if (brisiPrv)
                stolbovi.RemoveAt(0);       // za da ne mi se nasobiraat stolbovi gi brisam tie sto ke gi snema od vid


            // crtanje dolnata pateka
            Color[] boi = new Color[2];

            if (gameOver)               // ako e zavrsena igrata da ne se mrdaat kockite
                prvaKocka = !prvaKocka;

            if (prvaKocka)
            {
                boi[0] = Color.ForestGreen;
                boi[1] = Color.LightGreen;
            }
            else
            {
                boi[0] = Color.LightGreen;
                boi[1] = Color.ForestGreen;
            }

            prvaKocka = !prvaKocka;

            for (int i = 0; i < 24; i++)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), i * 10, 35 * 10 - 3, 10, 13);
                e.Graphics.FillRectangle(new SolidBrush(Color.White), i * 10, 35 * 10 - 1, 10, 11);
                e.Graphics.FillRectangle(new SolidBrush(boi[i % 2]), i * 10, 35 * 10, 10, 10);
            }


            // crtanje ptica
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), ptica.X * 10, ptica.Y * 10, 19, 19);
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), ptica.X * 10 + 2, ptica.Y * 10 + 2, 15, 15);
            e.Graphics.FillEllipse(new SolidBrush(Color.Yellow), ptica.X * 10 + 12, ptica.Y * 10 + 10, 6, 6);   // klunot
            e.Graphics.FillEllipse(new SolidBrush(Color.Blue), ptica.X * 10 + 10, ptica.Y * 10 + 5, 4, 4);   // oko
        }

        /// <summary>
        /// Тајмерот за движењето на столбовите.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerPozadina_Tick(object sender, EventArgs e)
        {
            if (crtaj)
            {
                if (timerBrojac == 0)
                    stolbovi.Add(new Stolb(25, random.Next(5, 15)));

                timerBrojac = (timerBrojac + 1) % 13;

                if (!skoknato)
                    ptica.Y ++;
                else
                    skoknato = false;
            }

            if (Pominato() && !gameOver)
            { 
                score++;
                lbScore.Text = score.ToString();

                if (score > bestScore)
                {
                    bestScore = score;
                    lbBest.Text = bestScore.ToString();
                }
           
            }

            pbIgra.Invalidate();
        }

        /// <summary>
        /// Стартување нова игра, доколку тековната не е завршена се поставува прашање дали да се прекине тековната игра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (gameOver ||
                MessageBox.Show("Really?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                newGame();
        }

        #endregion

        #region Logic
		
        /// <summary>
        /// Креирање нова игра. Ресетирање на вредностите.
        /// </summary>
        private void newGame()
        {
            btnTopScorers.Enabled = false;
            if (records.players.Count > 0)
            {
                lbBest.Text = records.players[0].Points.ToString();
            }
            timerBrojac = 0;
            score = 0;
            lbScore.Text = score.ToString();
            prvaKocka = false;
            skoknato = false;
            gameOver = false;
            crtaj = false;
            stolbovi = new List<Stolb>();
            ptica = new Point(8, 17);
            TimerPozadina.Start();
        }

        /// <summary>
        /// Завршување на играта.
        /// </summary>
        private void GameOver()
        {
            btnTopScorers.Enabled = true;
            gameOver = true;
            TimerPozadina.Stop();

            records.addPlayer(new PlayerWithPoints(MainForm.name, score));
            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, records);
            strm.Close();

            MessageBox.Show("Score: "+score, "Game Over", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Метод за проверка дали полето е валидно (дали птицата удрлиа во земја или во столб).
        /// </summary>
        /// <returns></returns>
        private bool Validno()
        {
            foreach (Stolb s in stolbovi)
                if (s.sudir(ptica))
                    return false;

            return true;
        }

        /// <summary>
        /// Метод за да се провери дали столбот не е важен веќе (дали се изгубил налево).
        /// </summary>
        /// <returns></returns>
        private bool Pominato()
        {
            foreach (Stolb s in stolbovi)
                if (s.XKoord == ptica.X)
                    return true;

            return false;
        }
	    #endregion

        #region Deserialization

        private void deserijalizacijaRekorderi()
        {
            try
            {
                FileName = "flappyBirdRecords.rk";
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                records = (PointRecords)fmt.Deserialize(strm);
                strm.Close();
            }
            catch (Exception e) { }
        }

        #endregion

        private void btnTopScorers_Click(object sender, EventArgs e)
        {
            MessageBox.Show(records.ToString(), "Top Scorers");
        }
    }

    public class Stolb
    {
        #region Constructor and Variables

        public int XKoord;
        public int Visina;
        public int GornaVisina;

        /// <summary>
        /// Креирање на столб.
        /// </summary>
        /// <param name="_XKoord"></param>
        /// <param name="_Visina"></param>
        public Stolb(int _XKoord, int _Visina)
        {
            XKoord = _XKoord;
            Visina = _Visina;
            GornaVisina = 28 - Visina;
        }

        #endregion

        #region Collision Check

        /// <summary>
        /// Се проверува дали птицата удрила во столбот (дали координатата на птицата се наоѓа во полето на столбот).
        /// </summary>
        /// <param name="ptica"></param>
        /// <returns></returns>
        public bool sudir(Point ptica)
        {
            int pticaX1 = ptica.X;
            int pticaX2 = ptica.X + 1;
            int pticaY1 = ptica.Y;
            int pticaY2 = ptica.Y + 1;

            if (ptica.Y+1 > 34)     // znaci udrilo vo zemja
                return true;

            if (ptica.X + 2 >= XKoord && ptica.X + 2 <= XKoord + 4 && ptica.Y >= 34 - Visina)      // udrila vo dolniot stolb
                return true;

            if (ptica.X + 2 >= XKoord && ptica.X + 2 <= XKoord + 4 && ptica.Y < GornaVisina)      // udrila vo gorniot stolb
                return true;
           
            return false;
        }

        #endregion
    }


}

