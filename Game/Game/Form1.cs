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
            //this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false; 
            //this.SetVisibleCore(false);
            this.Hide();
            Balony Gra = new Balony();
            
        }

        private void Wyniki_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores();
        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
