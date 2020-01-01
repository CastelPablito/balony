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
    public partial class Scores : Form
    {
        public Scores()
        {
           
            InitializeComponent();
            show_score();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ShowDialog();
            
           
            
           
            // Refresh();
        }

        private void scores_Load(object sender, EventArgs e)
        {

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

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

        public void show_score()
        {

           // int il_linii = 10;

            try
            {
                FileStream pliczek = new FileStream("wyniki.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter pliczek_write = new StreamWriter(pliczek);
                StreamReader pliczek_read = new StreamReader(pliczek);
                int i = 10;

                foreach (Control x in this.Controls) {
                    if (x is Label)
                    {
                        x.Text = i + ".     " + pliczek_read.ReadLine();
                        i--;
                    }
                }

                pliczek_read.Close();
                //string[] buf = new string[il_linii];
                //int[] ranking = new int[il_linii];

                //for (int i = 0; i < il_linii; i++)
                //{
                //    buf[i] = pliczek_read.ReadLine();
                //    ranking[i] = Int32.Parse(buf[i]);
                //}

                //for (int i = 0; i < il_linii; i++)
                //{
                //    for (int j = 0; j < il_linii - 1; j++)
                //    {
                //        if (ranking[j + 1] > ranking[j])
                //        {
                //            int tmp = ranking[j + 1];
                //            ranking[j + 1] = ranking[j];
                //            ranking[j] = tmp;
                //        }
                //    }
                //}


                //for (int i = 0; i < il_linii; i++)
                //{
                //    Console.WriteLine(il_linii);
                //    Console.WriteLine(ranking[i]);
                //}
                ////label1.Text = ranking[1].ToString();
                ////label1.Text = "dupa";
                
                //pliczek_write.Close();
                //pliczek_read.Close();
                //pliczek.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd" + e);
            }

        }
    }
}
