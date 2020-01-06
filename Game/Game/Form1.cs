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
    /// <summary>Klasa wyświetlająca okno zawierające menu główne gry</summary>  
    public partial class Menu : Form
    {
        /// <summary>Konstruktor klasy</summary>  
        public Menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        /// <summary>Powoduje wywołanie klasy Balony</summary> 
        /// <param name="sender"> przycisk startu </param>
        /// <param name="e">zdarzenie .</param>
        private void Start_Click(object sender, EventArgs e)
        {
            Balony Gra = new Balony();           // rozpoczecie rozgrywki
        }
        /// <summary>Powoduje wywołanie klasy Scores</summary>  
        /// <param name="sender"> przycisk przekierowywujący do wyników </param>
        /// <param name="e">zdarzenie .</param>
        private void Wyniki_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores();          // przejscie do tabeli wynikow
        }
        /// <summary>Powoduje zakończenie procesu</summary>  
        /// <param name="sender"> przycisk wyjście </param>
        /// <param name="e">zdarzenie .</param>
        private void Wyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();                 // zakonczenie programu
        }


    }
}
