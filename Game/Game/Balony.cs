﻿using System;
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
    public partial class Balony : Form
    {
        public Balony()
        {
            InitializeComponent();
        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            
        }
    }
}