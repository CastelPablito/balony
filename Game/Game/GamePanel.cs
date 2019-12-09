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
    public class GamePanel : System.Windows.Forms.Panel
    {
        public GamePanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.SetStyle(
               ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.UserPaint |
                    ControlStyles.DoubleBuffer,
    true);

        }


    }
}
