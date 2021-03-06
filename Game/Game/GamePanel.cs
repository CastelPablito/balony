﻿using System;
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
    /// <summary>Klasa pomagająca optymalizować wyświetlanie elementów</summary>  
    public class GamePanel : System.Windows.Forms.Panel
    {
        /// <summary>Ustawia parametry panela</summary>  
        /// <example>
        ///  public GamePanel()
        ///{
        /// <code>
        ///  DoubleBuffered = true;
        ///  SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        ///
        ///     this.SetStyle(
        ///        ControlStyles.AllPaintingInWmPaint |
        ///        ControlStyles.UserPaint |
        ///        ControlStyles.DoubleBuffer,
        ///        true);
        ///}
        /// </code>
        /// </example>
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
