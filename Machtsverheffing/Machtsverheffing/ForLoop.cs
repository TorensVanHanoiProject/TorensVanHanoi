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
            userInput = amountDiscsTextbox.Text;
            numberOfDiscs = int.Parse(amountDiscsTextbox.Text);
            if (numberOfDiscs > 1)
            {
                ulong moves = 1;
                int i = int.Parse(userInput);

                for (; i - 1 > 0; i--)
                {
                    moves = 2 * moves + 1;
                }

                MessageBox.Show(moves.ToString());
            }
        }
    }
}
