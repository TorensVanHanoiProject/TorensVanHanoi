﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machtsverheffing
{
    public partial class TowerOfHanoi : Form
    {
        

        public TowerOfHanoi()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
          
        }

        private void machtsVerheffingButton_Click(object sender, EventArgs e)
        {
            MachtsVerheffen popup = new MachtsVerheffen();
            popup.ShowDialog();
        }
    }
}