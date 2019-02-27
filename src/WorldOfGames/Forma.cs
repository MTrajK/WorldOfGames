using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WorldOfGames
{
    /// <summary>
    /// Абстрактна класа од која ги извојувам сите 7 форми.
    /// </summary>
    abstract class Forma
    {
        public Color Boja;
        public List<Point> Koordinati;
        public List<Point> Proverka;
        public int Pozicija;
        public int ProverkaPoz;
        public bool SmeniPoz;       // ova go koristam za da znam koga da ja smenam pozicijata
                                    // zosto odkako ke ja svrtam i ne e validna ke se napravi cekor nadole i ke se smeni pozicijata, a ne treba

        /// <summary>
        /// Оваа метода е статична за да можам без креирање класа да ја повикувам.
        /// </summary>
        /// <param name="Broj"> Рандом бројот според која ја креирам формата. </param>
        /// <returns> Враќа нова истанца од наследената форма. </returns>
        public static Forma Odberi(int Broj)
        {
            if (Broj == 0)
                return new Forma1();
            if (Broj == 1)
                return new Forma2();
            if (Broj == 2)
                return new Forma3();
            if (Broj == 3)
                return new Forma4();
            if (Broj == 4)
                return new Forma5();
            if (Broj == 5)
                return new Forma6();
            return new Forma7();
        }

        /// <summary>
        /// Овој метод служи за да се добие наредната состојба со поместување на формата.
        /// </summary>
        /// <param name="Pravec">0- за надоле, 1- за лево, 2- за десно. </param>
        /// <returns> Враќа листа со координати на поместувањето. </returns>
        public List<Point> Pomesti(int Pravec)
        {
            Proverka = new List<Point>();
            int x = 0;
            int y = 0;

            if (Pravec == 0)
                y++;
            else if (Pravec == 1)
                x--;
            else if (Pravec == 2)
                x++;

            foreach (Point p in Koordinati)
                Proverka.Add(new Point(p.X + x, p.Y + y));

            SmeniPoz = false;

            return Proverka;
        }

        /// <summary>
        /// Овој метод служи за да се добие наредната состојба со вртење на формата.
        /// </summary>
        /// <returns> Враќа листа со координати на поместувањето. </returns>
        public abstract List<Point> Vrti();

        /// <summary>
        /// Овој метод се повикува кога новодобиените координати се валидни и финалните координати треба да ја добијат вредноста на пробните и финалната позиција да ја добие позицијата од проверката.
        /// </summary>
        public void Smeni()
        {
            Koordinati = new List<Point>();

            foreach (Point p in Proverka)
                Koordinati.Add(p);

            if (SmeniPoz)
                Pozicija = ProverkaPoz;
               
        }
    }

    /// <summary>
    /// Оваа форма е коцката.
    /// ##
    /// ##
    /// </summary>
    class Forma1 : Forma
    {
        public Forma1()
        {
            Boja = Color.Red;
            Koordinati = new List<Point>();
            Koordinati.Add(new Point(4, -1));
            Koordinati.Add(new Point(5, -1));
            Koordinati.Add(new Point(4, 0));
            Koordinati.Add(new Point(5, 0));
        }

        //kaj kockata nema vrtenje
        public override List<Point> Vrti()
        {
            Proverka = new List<Point>();

            foreach (Point p in Koordinati)
                Proverka.Add(p);

            return Proverka;
        }
    }

    /// <summary>
    /// Оваа форма е долгнавестото.
    /// ####
    /// </summary>
    class Forma2 : Forma
    {
        public Forma2()
        {
            Boja = Color.Orange;
            Koordinati = new List<Point>();
            Koordinati.Add(new Point(3, 0));
            Koordinati.Add(new Point(4, 0));
            Koordinati.Add(new Point(5, 0));
            Koordinati.Add(new Point(6, 0));
        }

        public override List<Point> Vrti()
        {
            Proverka = new List<Point>();
            
            if (Pozicija == 0)
            {
                ProverkaPoz = 1;
                Proverka.Add(new Point(Koordinati[0].X + 2, Koordinati[0].Y - 1));
                Proverka.Add(new Point(Koordinati[1].X + 1, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X, Koordinati[2].Y + 1));
                Proverka.Add(new Point(Koordinati[3].X - 1, Koordinati[3].Y + 2));
            }
            else if (Pozicija == 1)
            {
                ProverkaPoz = 2;
                Proverka.Add(new Point(Koordinati[0].X - 2, Koordinati[0].Y + 2));
                Proverka.Add(new Point(Koordinati[1].X - 1, Koordinati[1].Y + 1));
                Proverka.Add(new Point(Koordinati[2].X, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X + 1, Koordinati[3].Y - 1));
            }
            else if (Pozicija == 2)
            {
                ProverkaPoz = 3;
                Proverka.Add(new Point(Koordinati[0].X + 1, Koordinati[0].Y - 2));
                Proverka.Add(new Point(Koordinati[1].X, Koordinati[1].Y - 1));
                Proverka.Add(new Point(Koordinati[2].X - 1, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X - 2, Koordinati[3].Y + 1));
            }
            else
            {
                ProverkaPoz = 0;
                Proverka.Add(new Point(Koordinati[0].X - 1, Koordinati[0].Y + 1));
                Proverka.Add(new Point(Koordinati[1].X, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X + 1, Koordinati[2].Y - 1));
                Proverka.Add(new Point(Koordinati[3].X + 2, Koordinati[3].Y - 2));
            }

            SmeniPoz = true;

            return Proverka;
        }
    }

    /// <summary>
    /// Оваа форма е L со опавчето на лева страна.
    /// #
    /// ###
    /// </summary>
    class Forma3 : Forma
    {
        public Forma3()
        {
            Boja = Color.Purple;
            Koordinati = new List<Point>();
            Koordinati.Add(new Point(3, -1));
            Koordinati.Add(new Point(3, 0));
            Koordinati.Add(new Point(4, 0));
            Koordinati.Add(new Point(5, 0));
        }

      
        public override List<Point> Vrti()
        {
            Proverka = new List<Point>();

            if (Pozicija == 0)
            {
                ProverkaPoz = 1;
                Proverka.Add(new Point(Koordinati[0].X + 1, Koordinati[0].Y));
                Proverka.Add(new Point(Koordinati[1].X + 2, Koordinati[1].Y - 1));
                Proverka.Add(new Point(Koordinati[2].X, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X - 1, Koordinati[3].Y + 1));
            }
            else if (Pozicija == 1)
            {
                ProverkaPoz = 2;
                Proverka.Add(new Point(Koordinati[0].X - 1, Koordinati[0].Y + 1));
                Proverka.Add(new Point(Koordinati[1].X - 1, Koordinati[1].Y + 1));
                Proverka.Add(new Point(Koordinati[2].X + 1, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X + 1, Koordinati[3].Y));
            }
            else if (Pozicija == 2)
            {
                ProverkaPoz = 3;
                Proverka.Add(new Point(Koordinati[0].X + 1, Koordinati[0].Y - 1));
                Proverka.Add(new Point(Koordinati[1].X, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X - 2, Koordinati[2].Y + 1));
                Proverka.Add(new Point(Koordinati[3].X - 1, Koordinati[3].Y));
            }
            else
            {
                ProverkaPoz = 0;
                Proverka.Add(new Point(Koordinati[0].X - 1, Koordinati[0].Y));
                Proverka.Add(new Point(Koordinati[1].X - 1, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X + 1, Koordinati[2].Y - 1));
                Proverka.Add(new Point(Koordinati[3].X + 1, Koordinati[3].Y - 1));
            }

            SmeniPoz = true;

            return Proverka;
        }
    }

    /// <summary>
    /// Оваа форма е L со опавчето на десна страна.
    ///   #
    /// ###
    /// </summary>
    class Forma4 : Forma
    {
        public Forma4()
        {
            Boja = Color.Blue;
            Koordinati = new List<Point>();
            Koordinati.Add(new Point(5, -1));
            Koordinati.Add(new Point(3, 0));
            Koordinati.Add(new Point(4, 0));
            Koordinati.Add(new Point(5, 0));
        }

        public override List<Point> Vrti()
        {
            Proverka = new List<Point>();

            if (Pozicija == 0)
            {
                ProverkaPoz = 1;
                Proverka.Add(new Point(Koordinati[0].X - 1, Koordinati[0].Y));
                Proverka.Add(new Point(Koordinati[1].X + 1, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X, Koordinati[2].Y + 1));
                Proverka.Add(new Point(Koordinati[3].X, Koordinati[3].Y + 1));
            }
            else if (Pozicija == 1)
            {
                ProverkaPoz = 2;
                Proverka.Add(new Point(Koordinati[0].X - 1, Koordinati[0].Y + 1));
                Proverka.Add(new Point(Koordinati[1].X, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X + 1, Koordinati[2].Y - 1));
                Proverka.Add(new Point(Koordinati[3].X - 2, Koordinati[3].Y));
            }
            else if (Pozicija == 2)
            {
                ProverkaPoz = 3;
                Proverka.Add(new Point(Koordinati[0].X, Koordinati[0].Y - 1));
                Proverka.Add(new Point(Koordinati[1].X, Koordinati[1].Y - 1));
                Proverka.Add(new Point(Koordinati[2].X - 1, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X + 1, Koordinati[3].Y));
            }
            else
            {
                ProverkaPoz = 0;
                Proverka.Add(new Point(Koordinati[0].X + 2, Koordinati[0].Y));
                Proverka.Add(new Point(Koordinati[1].X - 1, Koordinati[1].Y + 1));
                Proverka.Add(new Point(Koordinati[2].X, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X + 1, Koordinati[3].Y - 1));
            }

            SmeniPoz = true;

            return Proverka;
        }
    }

    /// <summary>
    /// Оваа форма е T.
    ///  #
    /// ###
    /// </summary>
    class Forma5 : Forma
    {
        public Forma5()
        {
            Boja = Color.Yellow;
            Koordinati = new List<Point>();
            Koordinati.Add(new Point(4, -1));
            Koordinati.Add(new Point(3, 0));
            Koordinati.Add(new Point(4, 0));
            Koordinati.Add(new Point(5, 0));
        }

        public override List<Point> Vrti()
        {
            Proverka = new List<Point>();

            if (Pozicija == 0)
            {
                ProverkaPoz = 1;
                Proverka.Add(new Point(Koordinati[0].X, Koordinati[0].Y));
                Proverka.Add(new Point(Koordinati[1].X + 1, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X + 1, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X - 1, Koordinati[3].Y + 1));
            }
            else if (Pozicija == 1)
            {
                ProverkaPoz = 2;
                Proverka.Add(new Point(Koordinati[0].X - 1, Koordinati[0].Y + 1));
                Proverka.Add(new Point(Koordinati[1].X, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X, Koordinati[3].Y));
            }
            else if (Pozicija == 2)
            {
                ProverkaPoz = 3;
                Proverka.Add(new Point(Koordinati[0].X + 1, Koordinati[0].Y - 1));
                Proverka.Add(new Point(Koordinati[1].X - 1, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X - 1, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X, Koordinati[3].Y));
            }
            else
            {
                ProverkaPoz = 0;
                Proverka.Add(new Point(Koordinati[0].X, Koordinati[0].Y));
                Proverka.Add(new Point(Koordinati[1].X, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X + 1, Koordinati[3].Y - 1));
            }

            SmeniPoz = true;

            return Proverka;
        }
    }

    /// <summary>
    /// Оваа форма е Z.
    /// ##
    ///  ##
    /// </summary>
    class Forma6 : Forma
    {
        public Forma6()
        {
            Boja = Color.Green;
            Koordinati = new List<Point>();
            Koordinati.Add(new Point(3, -1));
            Koordinati.Add(new Point(4, -1));
            Koordinati.Add(new Point(4, 0));
            Koordinati.Add(new Point(5, 0));
        }

        public override List<Point> Vrti()
        {
            Proverka = new List<Point>();

            if (Pozicija == 0)
            {
                ProverkaPoz = 1;
                Proverka.Add(new Point(Koordinati[0].X + 2, Koordinati[0].Y));
                Proverka.Add(new Point(Koordinati[1].X, Koordinati[1].Y + 1));
                Proverka.Add(new Point(Koordinati[2].X + 1, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X - 1, Koordinati[3].Y + 1));
            }
            else if (Pozicija == 1)
            {
                ProverkaPoz = 2;
                Proverka.Add(new Point(Koordinati[0].X - 2, Koordinati[0].Y + 1));
                Proverka.Add(new Point(Koordinati[1].X, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X - 1, Koordinati[2].Y + 1));
                Proverka.Add(new Point(Koordinati[3].X + 1, Koordinati[3].Y));
            }
            else if (Pozicija == 2)
            {
                ProverkaPoz = 3;
                Proverka.Add(new Point(Koordinati[0].X + 1, Koordinati[0].Y - 1));
                Proverka.Add(new Point(Koordinati[1].X - 1, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X, Koordinati[2].Y - 1));
                Proverka.Add(new Point(Koordinati[3].X - 2, Koordinati[3].Y));
            }
            else
            {
                ProverkaPoz = 0;
                Proverka.Add(new Point(Koordinati[0].X - 1, Koordinati[0].Y));
                Proverka.Add(new Point(Koordinati[1].X + 1, Koordinati[1].Y - 1));
                Proverka.Add(new Point(Koordinati[2].X, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X + 2, Koordinati[3].Y - 1));
            }

            SmeniPoz = true;

            return Proverka;
        }
    }

    /// <summary>
    /// Оваа форма е Z обратно.
    ///  ##
    /// ##
    /// </summary>
    class Forma7 : Forma
    {
        public Forma7()
        {
            Boja = Color.Cyan;
            Koordinati = new List<Point>();
            Koordinati.Add(new Point(4, -1));
            Koordinati.Add(new Point(5, -1));
            Koordinati.Add(new Point(3, 0));
            Koordinati.Add(new Point(4, 0));
        }

        public override List<Point> Vrti()
        {
            Proverka = new List<Point>();

            if (Pozicija == 0)
            {
                ProverkaPoz = 1;
                Proverka.Add(new Point(Koordinati[0].X, Koordinati[0].Y));
                Proverka.Add(new Point(Koordinati[1].X - 1, Koordinati[1].Y + 1));
                Proverka.Add(new Point(Koordinati[2].X + 2, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X + 1, Koordinati[3].Y + 1));
            }
            else if (Pozicija == 1)
            {
                ProverkaPoz = 2;
                Proverka.Add(new Point(Koordinati[0].X, Koordinati[0].Y + 1));
                Proverka.Add(new Point(Koordinati[1].X + 1, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X - 2, Koordinati[2].Y + 1));
                Proverka.Add(new Point(Koordinati[3].X - 1, Koordinati[3].Y));
            }
            else if (Pozicija == 2)
            {
                ProverkaPoz = 3;
                Proverka.Add(new Point(Koordinati[0].X - 1, Koordinati[0].Y - 1));
                Proverka.Add(new Point(Koordinati[1].X - 2, Koordinati[1].Y));
                Proverka.Add(new Point(Koordinati[2].X + 1, Koordinati[2].Y - 1));
                Proverka.Add(new Point(Koordinati[3].X, Koordinati[3].Y));
            }
            else
            {
                ProverkaPoz = 0;
                Proverka.Add(new Point(Koordinati[0].X + 1, Koordinati[0].Y));
                Proverka.Add(new Point(Koordinati[1].X + 2, Koordinati[1].Y - 1));
                Proverka.Add(new Point(Koordinati[2].X - 1, Koordinati[2].Y));
                Proverka.Add(new Point(Koordinati[3].X, Koordinati[3].Y - 1));
            }

            SmeniPoz = true;

            return Proverka;
        }
    }
}
