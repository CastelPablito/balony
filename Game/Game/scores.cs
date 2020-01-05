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


namespace Game
{
    /// <summary>Klasa wyświetlająca okno z tabelą wyników</summary>  
    public partial class Scores : Form
    {
        /// <summary>konstruktor klasy</summary>  
        public Scores()
        {
            InitializeComponent();
            show_score();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ShowDialog();
        }

        /// <summary>powoduje powrót do menu</summary>  
        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();        // powrot do menu
        }

        /// <summary>zapisane wyniku do pliku tekstowego</summary>  
        public static void save_score(int x)
        {
            try
            {
                FileStream pliczek = new FileStream("wyniki.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter pliczek_write = new StreamWriter(pliczek);
                StreamReader pliczek_read = new StreamReader(pliczek);

                pliczek_read.ReadToEnd();
                pliczek_write.WriteLine(x);             // dopisywanie wyniku na koncu pliku
                pliczek_write.Close();
                pliczek_read.Close();
                pliczek.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystapił błąd");
            }
        }

        /// <summary>odczyt z pliku tekstowego, posortowanie i wyswietlenie zawartosci</summary>  
        public void show_score()
        {
            try
            {
                FileStream pliczek = new FileStream("wyniki.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter pliczek_write = new StreamWriter(pliczek);
                StreamReader pliczek_read = new StreamReader(pliczek);

                int i = 0;
                while (!pliczek_read.EndOfStream)       // liczenie ilosci linii
                {
                    string line = pliczek_read.ReadLine();
                    i++;
                }

                pliczek.Position = 0;
                int[] ranking = new int[i];

                int j = 0;
                while (!pliczek_read.EndOfStream)
                {
                    ranking[j] = Int32.Parse(pliczek_read.ReadLine());  // spisanie wszystkich dostepnych wartości do tablicy
                    j++;
                }

                for (int a = 0; a < i - 1; a++) // posortowanie malejąco
                {
                    for (int b = 0; b < i - 1; b++)
                    {
                        if (ranking[b] < ranking[b + 1])
                        {
                            int buf = ranking[b + 1];
                            ranking[b + 1] = ranking[b];
                            ranking[b] = buf;
                        }
                    }
                }

                // WYSWIETLANIE

                int l_nr = 1;
                int k = 0;

                foreach (Control x in this.Controls)        // wyswietlanie wynikow
                {
                    if (x is Label)
                    {
                        if (k < i)
                        {
                            x.Text = l_nr + ".     " + ranking[k];
                            l_nr++;
                            k++;
                        }

                    }
                }

                pliczek_read.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd\n\n" + e);
            }

        }
    }
}
