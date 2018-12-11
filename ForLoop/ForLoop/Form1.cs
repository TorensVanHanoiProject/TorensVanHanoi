using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void amountRingsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (amountRingsComboBox.SelectedItem.ToString() == "1")
            {
                for (int i = 0; i <= 8; i++)
                {
                    i = i + (2 * 1) - 1; 
                }
            }
        }
    }
}
