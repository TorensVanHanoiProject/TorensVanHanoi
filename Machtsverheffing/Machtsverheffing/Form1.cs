using System;
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
    public partial class Form1 : Form
    {
        ulong totalMoves;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            ulong displayMoves = ulong.Parse(totalDiscsTextBox.Text.ToString());

            totalMoves = (ulong)(Math.Pow(2, displayMoves)) -1;

            totalMovesLabel.Text = "Total Moves: " + totalMoves.ToString();
        }
    }
}
