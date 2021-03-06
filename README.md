# World Of Games

**_[Преземи ја апликацијата (само за Windows OS)](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/dist/World%20Of%20Games.exe)_**




# 1. Краток опис на апликацијата


Целта на овој проект беше да се создаде Windows Form апликација составена од неколку од најпопуларните мали игри.

Со оваа апликација се опфатени три од "историски" најпопуларните игри (_стари преку 30 години_), кои иако се толку стари сè уште го привлекуваат вниманието на играчот: **_[Minesweeper](#23-minesweeper)_**, **_[Snake](#24-snake)_**, **_[Tetris](#25-tetris)_**.

Исто така и двете најпоуларни игри во денешницата (_помалку од една година стари_), за кои нема потреба многу да се објаснува бидејќи нема човек кој што не ги играл: **_[2048](#21-2048)_**, **_[Flappy Bird](#22-flappy-bird)_**.

Заедничко за сите игри е тоа што имаат серилизација (_се чуваат најдобрите резултати посебно за секоја од петте игри_).

![alt text](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/images/world_of_games.png "Start Window")




## 2. Опис на игрите


### 2.1 2048

Целта на ***[2048](https://en.wikipedia.org/wiki/2048_(video_game))*** е со помош на соединување на блоковите со бројки да се стигне до блокот 2048.

Оваа игра е идеја на [Gabriele Cirulli](https://github.com/gabrielecirulli) и е многу популарна на паметните телефони со повеќе верзии од кои најпревземаната е со околу 50 милиони превземања.

Два блока можат да се соединат само доколку содржат ист број и притоа доколку меѓу нив нема друг блок, истите можат да се соединат во 4-те правци.

Доколку се соединат два блока се добива еден блок кој има вредност еднаква на збирот на двата блока (_ако се соединат 2 и 2 ќе се добие 4, 4+4=8 итн_).

При секој нов потег се додава блок 2 или 4 (_4 се додава со помала веројатност_) на некоја од празните позиции.

Блоковите се движаат со помош на 4-те копчиња со стрелки: горе (**↑**), десно (**→**), доле (**↓**) и лево (**←**).

Во оваа верзија на 2048 додадени се две нови работи:

* Играта не завршува кога ќе се добие блокот 2048, продолжува понатаму се додека има уште валидни потези.

* И доколку за 3 секунди не се направи потег се додава нов блок.

![alt text](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/images/2048.png "2048")

**_[Преземи ја само 2048 (само за Windows OS)](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/dist/2048.exe)_**

---

### 2.2 Flappy Bird

***[Flappy Bird](https://en.wikipedia.org/wiki/Flappy_Bird)*** е едноставна игричка во која играчот управува со птица.

Исто така и оваа игра е многу популарна на паметните телефони. Нејзиниот сопственит пред некое време ја тргна од маркетите, но и покрај тоа оваа игра доби многу други верзии кои се превземени над 100 милиони пати.

Целта е при скокање да не се удри птицата во некој од столбовите или да не падне на земја.

Доколку удри во некој столб или падне птицата на земја играта завршува.

Птицата скока (_полетува_) со помош на копчето со стрелката горе (**↑**).

Во оваа верзија на Flappy Bird нема некакви промени, концептот е ист како оргиналната игра.

![alt text](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/images/flappy_bird.png "Flappy Bird")

**_[Преземи ја само Flappy Bird (само за Windows OS)](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/dist/FlappyBird.exe)_**

---

### 2.3 Minesweeper

***[Minesweeper](https://en.wikipedia.org/wiki/Minesweeper_(video_game))*** е играта од која што беа "заразени" скоро сите корисници на OS Windows. Бидејќи кај постарите верзии на Windows кога ќе се инсталираше оперативниот систем се инсталираше и оваа игра.

Концептот на играта е едноставен. Треба да се откријат каде се поставени 15-те мини и за таа цел во секое поле е испишана бројка која што означува со колку мини е опкружено тоа поле.

Доколку се сомневам во некое поле дека има мина, тогаш тоа поле го маркирам со десен клик (_не можам да го отворам тоа поле се додека не стиснам повторно десен клик на маусот_).

Играта завршува доколку "нагазам" на мина или пак доколку ги откријам сите 15 мини.

И играта се игра со помош на маусот. Лево копче за отварање поле и десно копче за маркирање (_ставање знаменце_) на поле.

![alt text](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/images/minesweeper.png "Minesweeper")

**_[Преземи ја само Minesweeper (само за Windows OS)](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/dist/Minesweeper.exe)_**

---

### 2.4 Snake

Иако ***[Snake](https://en.wikipedia.org/wiki/Snake_(video_game))*** е многу стара нашата генерација се запозна со оваа игра кога искочија првите мобилни телефони на Nokia каде што самата игра беше вградена.

Играта преставува една структура која најмногу наликува на змија и се однесува како змија (_колку повеќе јаде, толку поголема станува_).

Целта на играта е да се "изедат" (_соберат_) што е можно повеќе форми.

Секоја форма се разликува по бојата и секоја боја носи различни бодови (_што повеќе бодови носи тоа со помала веројатност се појавува_):
* Црвена форма: 5 бода
* Жолта форма: 10 бода
* Портокалова форма: 15 бода
* Кафеава форма: 20 бода
* А сината форма не дава бодови туку го скратува телото на змијата за 50% и се појавува со ептен мала веројатност.

На секои 150 поени се зголемува брзината на змијата за 10%.

Играта завршува кога ќе се судри змијата со своето тело или пак кога ќе се судри со некој ѕид (_горе, десно, доле, лево_).

Правецот на змијата се задава со помош на 4-те копчиња со стрелки: горе (**↑**), десно (**→**), доле (**↓**) и лево (**←**).

![alt text](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/images/snake.png "Snake")

**_[Преземи ја само Snake (само за Windows OS)](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/dist/Snake.exe)_**

---

### 2.5 Tetris

***[Tetris](https://en.wikipedia.org/wiki/Tetris)*** е една од игрите која се популаризира со помош на [нинтендото](https://en.wikipedia.org/wiki/Nintendo).

Играта се состои од 7 форми (_сите составени од по 4 блока_) кои паѓаат од врвот кон дното.

Во оваа верзија е имплементиран [оргиналниот алгоритам](https://upload.wikimedia.org/wikipedia/commons/0/0d/Tetris_gravity_%28simple%29.png) кој што е имплементиран во првата верзија на тетрис од русинот [Alexey Pajitnov](https://en.wikipedia.org/wiki/Alexey_Pajitnov). Оргиналната верзија се разликува од [модерната верзија](https://upload.wikimedia.org/wikipedia/commons/1/1b/Tetris_gravity_%28natural%29.png) во тоа што ако се поништи некој ред и доколку има дупка формите не ја пополнуваат дупката туку само се спуштаат во поништениот ред.

На секои 500 добиени поени се зголемува брзината на паѓање за 10%.

Играта завршува доколку се пополни средното поле и при тоа не може да се појави нова форма.

Играта се игра со помош на 4-те копчиња со стрелки. Со копчето горе (**↑**) се врти формата, со копчињата десно (**→**) и лево (**←**) се поместува формата на соодветната страна и со копчето доле (**↓**) се забрзува падот на формата.

![alt text](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/images/tetris.png "Tetris")

**_[Преземи ја само Tetris (само за Windows OS)](https://raw.githubusercontent.com/MTrajK/WorldOfGames/master/dist/Tetris.exe)_**




## 3. Опис на метод

Сите класи во оваа апликација се поделени во региони за подобра прегледност на кодот.

Исто така над секоја класа, секој метод и некои од глобалните променливи има објаснувања (_резиме-summary_) со што би се олеснила прегледноста кога би го гледал кодот некој што не бил вклучен во проектот.

Оваа апликација има многу интересни методи исто така и интересни алгоритми. Кога би издвоиле некои тоа би биле:

* Мрдањето на блоковите во играта **_[2048](#21-2048)_** (_кое е решено на два различни начини, исто така во кодот е оставен и стариот алгоритам како коментар и објаснување за разликите и комплексностите на двата алгоритми_).
* Отварањето на полињата во играта **_[Minesweeper](#23-minesweeper)_**, кое на прв поглед би се чинело много сложено, но се решава на едноставен начин со помош на *[BFS (Breadth-first search)](https://en.wikipedia.org/wiki/Breadth-first_search)*.
* И како најинтересен метод би го издвоиле вртењето на формите во играта **_[Tetris](#25-tetris)_** чии што проблем е решен со помош на апстрактна класа, бидејќи има 7 различни форми, а тие 7 форми имаат некои различни и некои сосема исти методи. Во продолжение подетално за овој метод.

#### Класата _[Forma.cs](https://github.com/MTrajK/WorldOfGames/blob/master/src/WorldOfGames/Forma.cs)_ и методите `public abstract List<Point> Vrti()` и `public List<Point> Pomesti(int Pravec)`

```c#
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
```

Секоја форма е составена од 4 блока, затоа за секоја форма се чува листа од 4 точки кои ги означуваат моменталните позиции на формата, дополнително се чува и една листа која ги означува идните позиции на формата (_бидејќи доколку се мрдне формата не значи дека ќе биде валидна позицијата, може да се судри со ѕид или пак со некој друг блок_).

За таа цел се чува за секоја форма дополнителна променлива bool која означува дали е валидна променливата.

Исто така се чуваат и една променлива за да се знае која е бојата на формата и една променлива за моменталната позиција на формата (_колку пати е свртена од почетната позиција_).

Во оваа класа има и еден статичен метод со чија помош креирам нова инстанца на форма `public static Forma Odberi(int Broj)` како аргумент го прима редниот број на формата.

За сите 7 форми поместувањето лево, десно и доле е исто, затоа има само еден метод во super класата преку која се мењаат сите форми `public List<Point> Pomesti(int Pravec)`. Доколку некоја форма се мрда лево, тогаш се намалува X координатата на сите 4 форми за еден, доколку се мрда десно тогаш X координатата на сите 4 форми се намалува за еден и доколку се мрда надоле Y координатите се зголемуваат за еден (_бидејќи координатниот систем во програмските јазици е обратен во поглед на Y оската во однос на математичката Y оска_).

И доколку поместената форма е валидна (_поместена лево, десно, доле или пак свретена_) преку методот `public void Smeni()` се мењаат старите координати со новите.

И за на крај методот `public List<Point> Vrti()` е различен во сите  7 форми бидејќи секоја форма на свој начин се врти.

**_Еве пример од вртењето на долгнавестото._**

```c#
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
```

Зависно од која позиција е (_колку пати е свртена формата_) формата се местат координатите на 4-те блока. Формата никогаш не се врти околу еден блок, бидејќи не би било рамномерно движењето, за таа цел при секое вртење се мењаат координатите на блоковите на различен начин.
