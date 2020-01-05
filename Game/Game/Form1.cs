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
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

     

        private void Start_Click(object sender, EventArgs e)
        {
            Balony Gra = new Balony();           // rozpoczecie rozgrywki
        }

        private void Wyniki_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores();          // przejscie do tabeli wynikow
        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();                 // zakonczenie programu
        }


    }
}
