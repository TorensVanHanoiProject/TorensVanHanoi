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
    public partial class MachtsVerheffen : Form
    {
        ulong totalMoves;
        int numberOfDiscs = 0;

        public MachtsVerheffen()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ulong displayMoves = ulong.Parse(totalDiscsTextBox.Text.ToString());
                if (displayMoves >= 1 && displayMoves <= 64)
                {
                
                totalMoves = (ulong)(Math.Pow(2, displayMoves)) - 1;

                 totalMovesLabel.Text = "Total Moves: " + totalMoves.ToString();
                }
                else
                {
                    MessageBox.Show("Het getal moet tussen de 1 en 64 zijn!");
                }
                   

            }
            catch(FormatException)
            {
                MessageBox.Show("Je moet wel een nummer invoeren voordat je iets kan uitrekenen!(dus ook geen tekst)");
            }
            
        }
    }
}
