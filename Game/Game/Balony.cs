using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace Game
{
    public partial class Balony : Form
    {
        int count = 0;
        //int speed = 5;
        int score = 0;

        Balon balonik = new Balon(600);

        public Balony()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ShowDialog();
            
        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void GameSpace_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = GameSpace.CreateGraphics();
            g.DrawImage(balonik.balon, new Point(0, balonik.y));


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //   GameSpace.Update();
            GameSpace.Refresh();
            // GameSpace.Invalidate();
            count++;
            punkty.Text = ""+score;
            if (count >= 1)
            {
                balonik.y--;
              //  score += 10;
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
