using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


// O2, N2, H2, CO2, CO,
namespace Game
{
    public class Balon
    {
        public static int szybkosc = 10;
        public static int count = 0;
        public int y = 0;
        public Point punkt;

        public Image balon = Properties.Resources.azot;

        public Balon(int y)
        {
            this.y = y;
        }

        public static void tworz(int x)
        {

        }

        public static void rysuj()
        {         
        }
    }


}
