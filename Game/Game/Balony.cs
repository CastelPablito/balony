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
            for (int i = 0; i < 10; i++)
            {
                // g.DrawEllipse(new Pen(Color.Black), 50+i*10, 50, 10, 10);
                // g.DrawEllipse(new Pen(Color.Black), 0, 100, 10, 10);
                // g.DrawEllipse(new Pen(Color.Black), 50, 0, 10, 10);
                // g.DrawEllipse(new Pen(Color.Black), 0, 0, 10, 10);
                // Task.Delay(2000);
                //// //g.Clear(Color.White);
                // Invalidate();
                // Update();
                Image newImage = Image.FromFile("ballo0n_blue1.png");
                Image newImage2 = Image.FromFile("balloon_blue2.png");
                Point ulCorner = new Point(100, 100);
                Point u2Corner = new Point(600, 300);
                Point u3Corner = new Point(500, 500);

                g.DrawImage(newImage2, ulCorner);
                g.DrawImage(newImage, u2Corner);
                g.DrawImage(newImage2, u3Corner);


            }

        }
    }
}
