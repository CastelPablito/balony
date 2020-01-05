using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game

{   /// <summary>Powoduje inicjacje klasy Menu</summary>  
    public static class Program
    {
        /// <summary>Powoduje inicjacje klasy Menu</summary>  
        [STAThread]
        
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Menu menu = new Menu();
            Application.Run(menu);
        }
    }
}
