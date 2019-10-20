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

            Image newImage1 = Image.FromFile("balloon_yellow.png");
            Image newImage2 = Image.FromFile("balloon_blue.png");
            Image newImage3 = Image.FromFile("balloon_red.png");
            Image newImage4 = Image.FromFile("balloon_green.png");
            Image newImage5 = Image.FromFile("balloon_purple.png");
            Point ulCorner = new Point(100 + count * 10, 100);
            Point u2Corner = new Point(600, 300 + count * 10);
            Point u3Corner = new Point(500, 500 - count * 10);
            Point u4Corner = new Point(300 - count * 10, 50);
            Point u5Corner = new Point(650, 50);

            g.DrawImage(newImage1, ulCorner);
            g.DrawImage(newImage2, u2Corner);
            g.DrawImage(newImage3, u3Corner);
            g.DrawImage(newImage4, u4Corner);
            g.DrawImage(newImage5, u5Corner);
            newImage1.Dispose();
            g.Dispose();
            

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //GameSpace.Update();
            GameSpace.Refresh();
           // GameSpace.Invalidate();
            count++;
        }
    }
}
