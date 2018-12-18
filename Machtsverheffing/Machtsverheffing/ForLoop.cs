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
    public partial class ForLoop : Form
    {

        string userInput;
        int numberOfDiscs = 0;
        public ForLoop()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
            userInput = amountDiscsTextbox.Text;
            numberOfDiscs = int.Parse(amountDiscsTextbox.Text);
                if (numberOfDiscs >= 1 && numberOfDiscs <= 64)
                {
                    ulong moves = 1;
                    int i = int.Parse(userInput);

                    for (; i - 1 > 0; i--)
                    {
                        moves = 2 * moves + 1;
                    }

                    MessageBox.Show(moves.ToString());
                }
                else
                {
                    MessageBox.Show("Het getal moet tussen de 1 en 64 zijn!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Je moet wel een nummer invoeren voordat je iets kan uitrekenen!(dus ook geen tekst)");
            }
            
        }
    }
}
