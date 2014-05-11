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
    public partial class Form2048 : Form
    {

        #region Constructor and Variables

        PointRecords records;
        public string FileName { get; set; }

        private int [,] mat;
        private int slobodni;           // za da znam kolku slobodni polinja ima
        private Random random;
        private List<TextBox> lista;    // tuka gi cuvam podredeni text polinjata
        private long score;             
        private bool zavrsena;          // ja koristam za da znam dali treba da pecatam porakata na 2048
        private int time;               // za tajmerot
        private long best;              // za najdobriot skor
        private List<TextBox> prPolinja;// site spoeni i novododadeni polinja
        private int momentalen;
       
        /// <summary>
        /// Default constructor.
        /// Полињата може и динамички да се креираат, но бидејќи се малку ги креирав преку едиторот и тука само ги внесувам во листа.
        /// </summary>
        public Form2048()
        {
            InitializeComponent();

            prPolinja = new List<TextBox>();
            random = new Random();

            lista = new List<TextBox>();
            lista.Add(tb0);
            lista.Add(tb1);
            lista.Add(tb2);
            lista.Add(tb3);
            lista.Add(tb4);
            lista.Add(tb5);
            lista.Add(tb6);
            lista.Add(tb7);
            lista.Add(tb8);
            lista.Add(tb9);
            lista.Add(tb10);
            lista.Add(tb11);
            lista.Add(tb12);
            lista.Add(tb13);
            lista.Add(tb14);
            lista.Add(tb15);

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
        /// Евент за клик на копче, во кој правец да се движат формите.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upp(object sender, KeyEventArgs e)
        {
            if (zavrsena)
                return;

            isklucuvanje();
            if (e.KeyCode == Keys.Down)
                moveDown();
            if (e.KeyCode == Keys.Up)
                moveUp();
            if (e.KeyCode == Keys.Left)
                moveLeft();
            if (e.KeyCode == Keys.Right)
                moveRight();
        }

        /// <summary>
        /// Започнување на нова игра. Доколку не е завршена теквната тогаш се појавува порака дали да ја прекине сегашната игра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!zavrsena)
            {
                if (MessageBox.Show("Really?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    newGame();
            }
            else
                newGame();
        }

        /// <summary>
        /// Тајмер од 3 секунди. Доколку не се направи валиден потег во период од 3 секунди тогаш се додава нова коцка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            momentalen = 0;

            if (--time == 0)
                if (slobodni == 0)
                {
                    Time.Text = time.ToString();
                    GameOver();
                    MessageBox.Show("Time is up. Score: " + Score.Text, "Game Over", MessageBoxButtons.OK);
                }
                else
                {
                    time = 3;
                    create();
                    popolni();
                }

            Time.Text = time.ToString();
            if (time == 1)
                label2.ForeColor = label5.ForeColor = Time.ForeColor = Color.Red;
            else
                label2.ForeColor = label5.ForeColor = Time.ForeColor = Color.Black;
        }

        /// <summary>
        /// Тајмер за намалување на зголемената форма, доколкуку не се направи потег за дадениот период тогаш автоматски се намалува формата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            isklucuvanje();
        }

        /// <summary>
        /// Тајмер за движењето на плус поените.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (Poeni.Location.Y < 60)
            {
                Poeni.Visible = false;
                Poen.Stop();
            }
            else
                Poeni.Location = new Point(191, Poeni.Location.Y - 3);

        }
        #endregion

        #region Move Logics

        /// <summary>
        /// Движење нагоре.
        /// </summary>
        private void moveUp()
        {
            momentalen = 0;
            bool najden = false;

            for (int j = 0; j < 4; j++)
            {
                int prazni = 0;
                bool[] spoeni = new bool[4];

                for (int i = 0; i < 4; i++)
                    if (mat[i, j] == 0)
                        prazni++;
                    else
                    {
                        // premestuvanje
                        if (prazni != 0)
                        {
                            mat[i - prazni, j] = mat[i, j];
                            mat[i, j] = 0;
                            najden = true;  // dokolku se napravi premestuvanje znaci potegot e validen
                        }

                        // spojuvanje
                        if (i - prazni - 1 >= 0)
                            if (!spoeni[i - prazni - 1])
                                if (mat[i - prazni - 1, j] == mat[i - prazni, j])
                                {
                                    najden = true;          // ili pak dokolku se napravi spojuvanje togas potegot e validen
                                    spoeni[i - prazni - 1] = true;

                                    prPolinja.Add(lista.ElementAt((i - prazni - 1)*4+j));      // se dodava text poleto vo listata za animiranje
                                    mat[i - prazni - 1, j] *= 2;
                                    mat[i - prazni, j] = 0;

                                    momentalen += mat[i - prazni - 1, j];
                                    score += mat[i - prazni - 1, j];
                                    slobodni++;
                                    prazni++;
                                }
                    }
            }

            if (najden)
            {
                time = 3;
                Time.Text = time.ToString();
                label2.ForeColor = label5.ForeColor = Time.ForeColor = Color.Black;
                Vreme.Stop();
                Vreme.Start();

                create();
                popolni();
            }
            else
                isOver();
        }

        /// <summary>
        /// Движење надолу.
        /// </summary>
        private void moveDown()
        {
            momentalen = 0;
            bool najden = false;

            for (int j = 0; j < 4; j++)
            {
                int prazni = 0;
                bool[] spoeni = new bool[4];

                for (int i = 3; i >= 0; i--)
                    if (mat[i, j] == 0)
                        prazni++;
                    else
                    {
                        // premestuvanje
                        if (prazni != 0)
                        {
                            mat[i + prazni, j] = mat[i, j];
                            mat[i, j] = 0;
                            najden = true;  // dokolku se napravi premestuvanje znaci potegot e validen
                        }

                        // spojuvanje
                        if (i + prazni + 1 < 4)
                            if (!spoeni[i + prazni + 1])
                                if (mat[i + prazni + 1, j] == mat[i + prazni, j])
                                {
                                    najden = true;          // ili pak dokolku se napravi spojuvanje togas potegot e validen
                                    spoeni[i + prazni + 1] = true;

                                    prPolinja.Add(lista.ElementAt((i + prazni + 1) * 4 + j));      // se dodava text poleto vo listata za animiranje
                                    mat[i + prazni + 1, j] *= 2;
                                    mat[i + prazni, j] = 0;

                                    momentalen += mat[i + prazni + 1, j];
                                    score += mat[i + prazni + 1, j];
                                    slobodni++;
                                    prazni++;
                                }
                    }
            }

            if (najden)
            {
                time = 3;
                Time.Text = time.ToString();
                label2.ForeColor = label5.ForeColor = Time.ForeColor = Color.Black;
                Vreme.Stop();
                Vreme.Start();

                create();
                popolni();
            }
            else
                isOver();
        }

        /// <summary>
        /// Движење налево.
        /// </summary>
        private void moveLeft()
        {
            momentalen = 0;
            bool najden = false;

            for (int i = 0; i < 4; i++)
            {
                int prazni = 0;
                bool[] spoeni = new bool[4];

                for (int j = 0; j < 4; j++)
                    if (mat[i, j] == 0)                  
                        prazni++;
                    else
                    {
                        // premestuvanje
                        if (prazni != 0)
                        {
                            mat[i, j - prazni] = mat[i, j];
                            mat[i, j] = 0;
                            najden = true;  // dokolku se napravi premestuvanje znaci potegot e validen
                        }

                        // spojuvanje
                        if (j - prazni - 1 >= 0)
                            if (!spoeni[j - prazni - 1])
                                if (mat[i, j - prazni - 1] == mat[i, j - prazni])
                                {
                                    najden = true;          // ili pak dokolku se napravi spojuvanje togas potegot e validen
                                    spoeni[j - prazni - 1] = true;

                                    prPolinja.Add(lista.ElementAt(i* 4 + (j - prazni - 1)));      // se dodava text poleto vo listata za animiranje
                                    mat[i, j - prazni - 1] *= 2;
                                    mat[i, j - prazni] = 0;

                                    momentalen += mat[i, j - prazni - 1];
                                    score += mat[i, j - prazni - 1];
                                    slobodni++;
                                    prazni++;
                                }
                    }
            }

            if (najden)
            {
                time = 3;
                Time.Text = time.ToString();
                label2.ForeColor = label5.ForeColor = Time.ForeColor = Color.Black;
                Vreme.Stop();
                Vreme.Start();

                create();
                popolni();
            }
            else
                isOver();
        }

        /// <summary>
        /// Движење надесно.
        /// </summary>
        private void moveRight()
        {
            momentalen = 0;
            bool najden = false;

            for (int i = 0; i < 4; i++)
            {
                int prazni = 0;
                bool[] spoeni = new bool[4];

                for (int j = 3; j >= 0; j--)
                    if (mat[i, j] == 0)
                        prazni++;
                    else
                    {
                        // premestuvanje
                        if (prazni != 0)
                        {
                            mat[i, j + prazni] = mat[i, j];
                            mat[i, j] = 0;
                            najden = true;  // dokolku se napravi premestuvanje znaci potegot e validen
                        }

                        // spojuvanje
                        if (j + prazni + 1 < 4)
                            if (!spoeni[j + prazni + 1])
                                if (mat[i, j + prazni + 1] == mat[i, j + prazni])
                                {
                                    najden = true;          // ili pak dokolku se napravi spojuvanje togas potegot e validen
                                    spoeni[j + prazni + 1] = true;

                                    prPolinja.Add(lista.ElementAt(i * 4 + (j + prazni + 1)));      // se dodava text poleto vo listata za animiranje
                                    mat[i, j + prazni + 1] *= 2;
                                    mat[i, j + prazni] = 0;

                                    momentalen += mat[i, j + prazni + 1];
                                    score += mat[i, j + prazni + 1];
                                    slobodni++;
                                    prazni++;
                                }
                    }
            }

            if (najden)
            {
                time = 3;
                Time.Text = time.ToString();
                label2.ForeColor = label5.ForeColor = Time.ForeColor = Color.Black;
                Vreme.Stop();
                Vreme.Start();

                create();
                popolni();
            }
            else
                isOver();
        }
        #endregion

        #region Other Logics

        /// <summary>
        /// Креирање на нова коцка (бројка).
        /// </summary>
        private void create()
        {        
                int rand = random.Next(slobodni--);
                int br;
                int brRandom = random.Next(100);

                if (brRandom < 20)
                    br = 4;
                else
                    br = 2;

                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        if (mat[i, j] == 0)
                            if (rand-- == 0)
                            {
                                mat[i, j] = br;
                                prPolinja.Add(lista.ElementAt(i*4+j));  // se dodava vo listata za animiranje noviot
                                return;
                            }
        }

        /// <summary>
        /// После секој потег или истечен тајмер се "црта" изгледот на играта. Се полната лабелите и текст полињата.
        /// </summary>
        private void popolni()
        {
            if (momentalen != 0)
            {
                Poen.Start();
                Poeni.BackColor = Color.Transparent;
                Poeni.Location = new Point(191, 72);
                Poeni.Text = "+" + momentalen.ToString();
                Poeni.Visible = true;
            }

            int br = 0;
            
             for (int i=0; i<4; i++)
                    for (int j=0; j<4; j++)
                    {
                        if (mat[i, j] == 0)
                            lista.ElementAt(br).Text = "";
                        else
                            lista.ElementAt(br).Text = mat[i, j].ToString();

                        oboi(lista.ElementAt(br++) , mat[i,j]);
                    }
             if (score > best)
             {
                 Best.Text = string.Format("{0:0000000000}", score);
                 best = score;
             }
             Score.Text = string.Format("{0:0000000000}", score);

             vklucuvanje();     // se vklucuva i potoa koa ke istecat 50 milisekundi se isklucuva
             Animacija.Start();    // se startuva zgolemuvanjeto
        }

        /// <summary>
        /// Во зависност од вредноста на полето, текст полето се бои во соодветна боја.
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="br"></param>
        private void oboi(TextBox tb, int br)
        {
            if (br == 0)
                tb.BackColor = Color.White;
           
            if (br == 2)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFE4C4");
               
            if (br == 4)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#DEB887");
           
            if (br == 8)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFA500");
               
            if (br == 16)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF6347");
             
            if (br == 32)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF4500");
              
            if (br == 64)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
            
            if (br == 128)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFD700");
           
            if (br == 256)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFCC00");
             
            if (br == 512)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFF00");
              
            if (br == 1024)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#9ACD32");
            
            if (br == 2048)
            { 
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#00FF7F");
                if (!zavrsena)
                {
                    zavrsena = true;
                    Vreme.Stop();

                    records.addPlayer(new PlayerWithPoints(MainForm.name, score));
                    System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    fmt.Serialize(strm, records);
                    strm.Close();

                    MessageBox.Show("Честички стигнавте до 2048.", "Честички!", MessageBoxButtons.OK);
                    Vreme.Start();
                }
            }

            if (br == 4096)
                tb.BackColor = System.Drawing.ColorTranslator.FromHtml("#008080");

            if (br > 999)
                tb.Font = new Font(tb.Font.FontFamily, 11, FontStyle.Bold);
            else
                tb.Font = new Font(tb.Font.FontFamily, 12, FontStyle.Bold);
            
        }

        /// <summary>
        /// Метод за проверка дали е завршена играта.
        /// </summary>
        private void isOver()
        {
            if (slobodni != 0)
                return;

            // dokolku nema slobodni proveruvam vo site 4 nasoki dali moze da se spoi

            // gore
            for (int i = 0; i < 4; i++)
                for (int j = 1; j < 4; j++)
                    if (mat[j - 1, i] == mat[j, i] && mat[j, i] != 0)
                        return;

            // dole
            for (int i = 0; i < 4; i++)
                for (int j = 2; j >= 0; j--)
                    if (mat[j + 1, i] == mat[j, i] && mat[j, i] != 0)
                        return;

            // levo
            for (int i = 0; i < 4; i++)
                for (int j = 1; j < 4; j++)
                    if (mat[i, j - 1] == mat[i, j] && mat[i, j] != 0)
                        return;

            // desno
            for (int i = 0; i < 4; i++)
                for (int j = 2; j >= 0; j--)
                    if (mat[i, j + 1] == mat[i, j] && mat[i, j] != 0)
                        return;

            // a dokolku ne najde nitu edno spojuvanje togas treba da zavrsi igrata
            GameOver();
            MessageBox.Show("Score: " + Score.Text, "Game Over", MessageBoxButtons.OK);
        }
      
        /// <summary>
        /// Метод за рестартирање на вредностите и започнување нова игра.
        /// </summary>
        private void newGame()
        {
            btnTopScorers.Enabled = false;
            if (records.players.Count > 0)
            {
                Best.Text = string.Format("{0:0000000000}", records.players[0].Points);
                best = records.players[0].Points;
            }
            mat = new int[4, 4];
            slobodni = 16;
            score = 0;
            zavrsena = false;
            time = 3;
            Time.Text = time.ToString();
            label2.ForeColor = label5.ForeColor = Time.ForeColor = Color.Black;
            Vreme.Stop();
            Vreme.Start();
            create();
            create();
            popolni();
        }

        /// <summary>
        /// Метод за завршување на играта.
        /// </summary>
        private void GameOver()
        {
            Vreme.Stop();
            btnTopScorers.Enabled = true;
            records.addPlayer(new PlayerWithPoints(MainForm.name, score));
            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            fmt.Serialize(strm, records);
            //fmt.Serialize(strm, BestScore);
            strm.Close();

            zavrsena = true;
        }

        /// <summary>
        /// Метод за зголемување на текст полето кога ќе се соедини со друго.
        /// </summary>
        private void vklucuvanje()
        {
            // se zgolemuvaat i odat malce nagore i levo
            foreach (TextBox tb in prPolinja)
            {
                tb.Size = new Size(54, 48);
                tb.Location = new Point(tb.Location.X - 5, tb.Location.Y - 5);
            }
        }

        /// <summary>
        /// Метод за намалување на текст полето кога ќе заврши зголемувањето.
        /// </summary>
        private void isklucuvanje()
        {
            // se vrakaat vo prvobitna golemina i lokacija , se prazni listata i se stopira tajmerot
            foreach (TextBox tb in prPolinja)
            {
                tb.Size = new Size(44, 38);
                tb.Location = new Point(tb.Location.X + 5, tb.Location.Y + 5);
            }
            
            prPolinja.Clear();
            Animacija.Stop();
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
                FileName = "records2048.rk";
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

#region Old Algorithm
/*
    //Stariot algoritam, so poveke funkcii i 3 pati pogolema slozenost O(3*n^2) a noviot else O(n^2) , ama vo ovoj slucaj n e malo(4) taka da nema nekoja si golema razlika

        private void moveUp()
        {
            /// 1. spojuvanje, da se izbrisat praznite mesta
           int br =  mergeUp();

            /// 2. sobiranje na sosednite, prv so vtor, vtor so tret...
            
            for (int i = 0; i < 4; i++)
               for (int j = 1; j<4; j++)
                   if (mat[j - 1, i] == mat[j, i] && mat[j, i] != 0)
                   {
                       mat[j - 1, i] *= 2;
                       score += mat[j - 1, i];
                       mat[j, i] = 0;
                       slobodni++;
                       br++;
                   }
                   
            
            /// 3. pak spojuvanje za da se izbrisat praznite mesta
            mergeUp();

            if (br != 0)
            {
                time = 3;
                Time.Text = time.ToString();
                timer1.Stop();
                timer1.Start();
                create();
                popolni();
            }
            else
                isOver();
        }

        private int mergeUp()
        {
            int br = 0;

            for (int i = 0; i < 4; i++)
            {
                int prazni = 0;

                for (int j = 0; j<4; j++)
                {
                     if (mat[j, i] == 0)
                         prazni++;
                     else if (prazni != 0)
                     {
                         br++;
                         mat[j-prazni, i] = mat[j,i];
                         mat[j, i] = 0;
                     }
                }
            }

            return br;
        }

        private void moveDown()
        {
            /// 1. spojuvanje, da se izbrisat praznite mesta
            int br = mergeDown();

            /// 2. sobiranje na sosednite, prv so vtor, vtor so tret...

            for (int i = 0; i < 4; i++)
                for (int j = 2; j >= 0; j--)
                    if (mat[j + 1, i] == mat[j, i] && mat[j, i] != 0)
                    {
                        mat[j + 1, i] *= 2;
                        score += mat[j + 1, i];
                        mat[j, i] = 0;
                        slobodni++;
                        br++;
                    }


            /// 3. pak spojuvanje za da se izbrisat praznite mesta
            mergeDown();

            if (br != 0)
            {
                time = 3;
                Time.Text = time.ToString();
                timer1.Stop();
                timer1.Start();
                create();
                popolni();
            }
            else
                isOver();
        }

        private int mergeDown()
        {
            int br = 0;

            for (int i = 0; i < 4; i++)
            {
                int prazni = 0;

                for (int j = 3; j >= 0; j--)
                {
                    if (mat[j, i] == 0)
                        prazni++;
                    else if (prazni != 0)
                    {
                        br++;
                        mat[j + prazni, i] = mat[j, i];
                        mat[j, i] = 0;
                    }
                }
            }

            return br;
        }

        private void moveLeft()
        {
            /// 1. spojuvanje, da se izbrisat praznite mesta
            int br = mergeLeft();

            /// 2. sobiranje na sosednite, prv so vtor, vtor so tret...
            for (int i = 0; i < 4; i++)
                for (int j = 1; j < 4; j++)
                    if (mat[i, j-1] == mat[i, j] && mat[i, j] != 0)
                    {
                        br++;
                        mat[i, j-1] *= 2;
                        score += mat[i, j-1];
                        mat[i, j] = 0;
                        slobodni++;
                    }

            /// 3. pak spojuvanje za da se izbrisat praznite mesta
            mergeLeft();

            if (br != 0)
            {
                time = 3;
                Time.Text = time.ToString();
                timer1.Stop();
                timer1.Start();
                create();
                popolni();
            }
            else
                isOver();
        }

        private int mergeLeft()
        {
            int br = 0;
            for (int i = 0; i < 4; i++)
            {
                int prazni = 0;

                for (int j = 0; j < 4; j++)
                {
                    if (mat[i,j] == 0)
                        prazni++;
                    else if (prazni != 0)
                    {
                        br++;
                        mat[i , j-prazni] = mat[i, j];
                        mat[i ,j] = 0;
                    }
                }
            }

            return br;
        }

        private void moveRight()
        {
            /// 1. spojuvanje, da se izbrisat praznite mesta
            int br = mergeRight();

            /// 2. sobiranje na sosednite, prv so vtor, vtor so tret...
            for (int i = 0; i < 4; i++)
                for (int j = 2; j >= 0; j--)
                    if (mat[i, j + 1] == mat[i, j] && mat[i, j] != 0)
                    {
                        br++;
                        mat[i, j + 1] *= 2;
                        score += mat[i, j + 1];
                        mat[i, j] = 0;
                        slobodni++;
                    }

            /// 3. pak spojuvanje za da se izbrisat praznite mesta
            mergeRight();

            if (br != 0)
            {
                time = 3;
                Time.Text = time.ToString();
                timer1.Stop();
                timer1.Start();
                create();
                popolni();
            }
            else
                isOver();
        }
    
        private int mergeRight()
        {
            int br = 0;
            for (int i = 0; i < 4; i++)
            {
                int prazni = 0;

                for (int j = 3; j >= 0; j--)
                {
                    if (mat[i, j] == 0)
                        prazni++;
                    else if (prazni != 0)
                    {
                        br++;
                        mat[i, j + prazni] = mat[i, j];
                        mat[i, j] = 0;
                    }
                }
            }

            return br;
        }
*/
#endregion