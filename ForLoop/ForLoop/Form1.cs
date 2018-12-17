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
        string userInput;
        int numberOfDiscs = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void amountRingsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            userInput = amountDiscsTextbox.Text;
            numberOfDiscs = int.Parse(amountDiscsTextbox.Text);
            if(numberOfDiscs > 1)
            {
                ulong moves = 1;
                int i = int.Parse(userInput);

                for (; i-1 > 0; i--)
                {
                    moves = 2 * moves + 1;
                }

                MessageBox.Show(moves.ToString());
            }
        }
    }
}
