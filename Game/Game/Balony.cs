using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game
{
    public partial class Balony : Form
    {

        int speed = 5;    // szybkosc ruchu balonow
        int score = 0;    // licznik punktow

        int il_O2 = 21;   // poczatkowe zawartosci gazow
        int il_N2 = 78;
        int il_CO2 = 1;

        int top_min = 720; //ograniczania obszaru pojawiania sie balonow
        int top_max = 1800;
        int l_max = 680;
        int l_min = 5;

        List<int> zajete_wys = new List<int>();     // lista punktow w ktorych pojawily sie juz balony
        List<int> zajete_szer = new List<int>();
        int szer = 120;     // maksymalne wymiary balona
        int wys = 120;

        Random rand = new Random();


        public Balony()
        {
            InitializeComponent();
            reset_Game();           // rozpoczecie rozgrywki
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ShowDialog();
        }


        private void Wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();     // powrot do menu
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            punkty.Text = "" + score;

            foreach (Control x in GameSpace.Controls)
            {
                int i = 0;
                if (x is PictureBox)
                {
                    x.Top -= speed;         // zmiana pozycji elementu
                    if (x.Top + x.Height < 0)   // znikniecie z ekranu
                    {
                        i++;
                        ballon_spawn((PictureBox)x);    // pojawianie sie na nowo
                        if (i % 11 == 0)        // okresowe czyszczenie bufora
                        {
                            zajete_szer.Clear();
                            zajete_wys.Clear();
                        }
                    }
                }
            }

            // zmienne pomagajace obliczac procentowe zawartosci gazow
            int suma = il_O2 + il_N2 + il_CO2;
            double tlen_percent = (double)il_O2 * 100 / suma;
            double azot_percent = (double)il_N2 * 100 / suma;
            double co2_percent = (double)il_CO2 * 100 / suma;

            // wyswietlanie tych zawartosci
            O_label.Text = "Tlen : " + String.Format("{0:N2}", tlen_percent) + "%";
            N_label.Text = "Azot : " + String.Format("{0:N2}", azot_percent) + "%";
            CO2_label.Text = "CO2  : " + String.Format("{0:N2}", (double)il_CO2 * 100 / suma) + "%";

            // dodatkowy warunek konca gry
            if (co2_percent > 3)
                CO2_label.ForeColor = Color.Red;
            else
                CO2_label.ForeColor = Color.Black;
            if (co2_percent > 4)
                info(co2_info);

            // zmiana szybkosci obiektu wraz z postepem gracza
            if (score == 100)
                speed = 6;
            else if (score == 200)
                speed = 8;
            else if (score == 300)
                speed = 10;
            else if (score == 450)
                speed = 15;
            else if (score == 750)
                speed = 20;
        }

        private void reset_Game()
        {
            zajete_szer.Clear();        // czyszczenie bufora
            zajete_wys.Clear();

            foreach (Control x in GameSpace.Controls)   // generowanie balonow
            {
                if (x is PictureBox)
                {
                    ballon_spawn((PictureBox)x);
                }
            }

            // przywracanie wartosci poczatkowych
            il_O2 = 21;
            il_N2 = 78;
            il_CO2 = 1;
            speed = 5;
            score = 0;
            timer.Start();
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            reset_Game();
        }


        private void ballon_spawn(PictureBox x)
        {
            if (!zajete_wys.Any<int>() && !zajete_szer.Any<int>()) // dla pierwszego elementu
            {
                x.Top = rand.Next(top_min, top_max);
                x.Left = rand.Next(l_min, l_max);
                zajete_wys.Add(x.Top);
                zajete_szer.Add(x.Left);
            }
            else // dla elementow nastepnych
            {
                int top = rand.Next(top_min, top_max); // generowanie pozycji losowej
                int left = rand.Next(l_min, l_max);
                int i = 0;

                foreach (int sprawdz in zajete_wys) // porownywanie pozycji wygenerowanej z innymi
                {

                    if (top < sprawdz + wys && left < zajete_szer[i] + szer && top > sprawdz - wys && left > zajete_szer[i] - szer)
                    {
                        top = rand.Next(top_min, top_max); // jesli [top,left] znajduje sie w zabronionym obszarze
                        left = rand.Next(l_min, l_max);    // to generuj nowy punkt [top,left]           
                    }
                    else { }

                    i++;
                }

                x.Top = top;
                x.Left = left;
                zajete_szer.Add(x.Left);    // dodanie pozycji do bufora
                zajete_wys.Add(x.Top);
            }
        }

        // KOMUNIKATY

        string czad_info = "⚝ CO - tlenek węgla, potocznie nazywany czadem.\n" +
                           "⚝ Jest bezbarwnym i bezwonnym gazem powstającym w skutek spalania węgla w niedostatecznej ilości tlenu.\n" +
                           "⚝ W czasie zimy zdarzają się zatrucia tym gazem spowodowane nieprawidłowym korzystaniem z instalacji ciepłowniczych\n" +
                           "⚝ Zbyt duże stężenie tego gazu w powietrzu może powodować poważne zatrucie a nawet śmierć.\n";

        string wodor_info = "⚝ Wodór jest najczęściej występującym pierwiastkiem we wszechświecie.\n" +
                            "⚝ Stanowi on zdecydowaną większość masy słońca, mimo że jest najlżejszym z pierwiastków\n" +
                            "⚝ W naturze naczęściej występuje w postaci dwuatomowej\n" +
                            "⚝ W związku z jego lekkością był wykorzystywany między innymi w statkach powietrznych zwanych sterowcami\n" +
                            "⚝ Niestety, w reakcji z tlenem jest bardzo wybuchowy, co doprowadziło do katastrofy, która przekreśliła przyszłość sterowców\n" +
                            "⚝ Dzisiaj wykorzystywany jest jako wysokoenergetyczne paliwo\n";

        string siarkowodor_info = "⚝ Siarkowodór zapachem przypomina zapach zgniłych jaj.\n" +
                                  "⚝ Choć może wydać się to dziwne, ale to jego największa zaleta, gdyż gaz ten jest bardzo niebezpieczny\n" +
                                  "⚝ Siarkowodór działa toksycznie na układ oddechowy oraz nerwowy, zbyt duża jego ilość powoduje zatrzymanie oddechu, a w rezultacie śmierć\n" +
                                  "⚝ Gaz ten występuje naturalnie wydobywając się ze szczelin w okolicach wulkanu, jak i w beztlenowym rozkladzie białek\n" +
                                  "⚝ Co ciekawe ludzki organizm również potrafi produkować ten gaz (tak zwane bąki)\n";

        string chlor_info = "⚝ Chlor jest silnie trującym żółtozielonym gazem o nieprzyjemnym zapachu.\n" +
                            "⚝ Jego obecność w powietrzu może prowadzić do obrzęku płuc, a nawet do śmierci\n" +
                            "⚝ Podczas I Wojny Światowej był stosowany jako broń chemiczna\n" +
                            "⚝ Mimo jego okropnych właściwości jako gazu, chlor jest bardzo przydatnym pierwiastkiem\n" +
                            "⚝ Używa się go w celu uzdatniania wody\n" +
                            "⚝ Jest składnikiem soli kuchennej (NaCl)\n" +
                            "⚝ Oraz pomaga nam w trawieniu, gdyż kwas chlorowodorowy (HCl) znajduje się w naszym żołądku!\n";

        string cyjanowodor_info = "⚝ Cyjanowodór to silnie toksyczny gaz wchłaniający się przez płuca oraz skórę.\n" +
                                  "⚝ Zapachem przypomina gorzkie migdały.\n " +
                                  "⚝ Bardzo niewielka ilość może spowodować zgon.\n " +
                                  "⚝ W czasie II Wojny Światowej był stosowany do trucia więźniów w niemieckich obozach zagłady\n ";

        string metan_info = "⚝ Metan jest bezbawrnym i bezwonnym silnie wybuchowym gazem\n" +
                             "⚝ Jego obecność często świadczy o obecności prostego życia, gdyż jest on wydalany przez proste bakterie\n" +
                             "Górnicy schodząc do kopalni muszą uważać na stężenie tego gazu\n" +
                             "⚝ Jego obecność tam może prowadzić do wybuchu oraz zawalenia się kopalni\n" +
                             "⚝ Jest jednym ze składników gazu ziemnego\n" +
                             "⚝ Jest on gazem cieplarnianym, a więc zbyt duża jego obecność w atmosferze może przyczyniać się do niszczenia wartswy ozonowej\n";

        string co2_info = "⚝ Dwutlenek węgla powstaje między innymi w naszych płucach\n" +
                          "⚝ Dla rosnących roślin jest on niezbędny, tak jak tlen dla nas\n" +
                          "⚝ CO2 jest gazem cieplarnianym, co oznacza, że jego nadwyżka wpływa na wzrost temperatury\n" +
                          "⚝ Należy uważać, aby jego stężenie nie było zbyt wysokie, w innym przypadku w dalekiej przyszłości Ziemia może przypominać Wenus\n";

        // AKCJA

        private void tlen_Click(object sender, EventArgs e)
        {
            var balloon = (PictureBox)sender;
            ballon_spawn(balloon);
            score += 10;
            il_O2++;
        }

        private void azot_Click(object sender, EventArgs e)
        {
            var balloon = (PictureBox)sender;
            ballon_spawn(balloon);
            score += 10;
            il_N2++;
        }

        private void co2_Click(object sender, EventArgs e)
        {
            var balloon = (PictureBox)sender;
            ballon_spawn(balloon);
            score += 10;
            il_CO2++;
        }

        private void hel_Click(object sender, EventArgs e)
        {
            var balloon = (PictureBox)sender;
            ballon_spawn(balloon);
            score += 10;
        }

        private void czad_Click(object sender, EventArgs e)
        {
            info(czad_info);
        }

        private void wodor_Click(object sender, EventArgs e)
        {
            info(wodor_info);
        }

        private void siarkowodor_Click(object sender, EventArgs e)
        {
            info(siarkowodor_info);
        }

        private void chlor_Click(object sender, EventArgs e)
        {
            info(chlor_info);
        }

        private void cyjanowodor_Click(object sender, EventArgs e)
        {
            info(cyjanowodor_info);
        }

        private void metan_Click(object sender, EventArgs e)
        {
            info(metan_info);
        }

        void info(string x)
        {
            Scores.save_score(score); //zapisywanie wyniku
            timer.Stop(); // zatrzymanie czasu
            MessageBox.Show(x, "Koniec gry!"); // informacja o koncu gry i ciekawostka
        }

    }
}
