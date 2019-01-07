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
        ulong moves = 1;
        ulong totalSeconds = 0;
        ulong totalMinutes = 0;
        ulong totalHours = 0;
        ulong totalDays = 0;
        ulong totalYears = 0;
        ulong totalCenturies = 0;


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
                    moves = 1;
                    int i = int.Parse(userInput);

                    for (; i - 1 > 0; i--)
                    {
                        moves = 2 * moves + 1;
                    }

                    convertSecondsToTime();
                    // message box
                    string title = "Toren van Hanoi";
                    string message = String.Format("Het aantal zetten is: {0}.\r\n" +
                                                    "De tijd om dit te voltooien is: {1} eeuwen, {2} jaren, {3} dagen" +
                                                    ", {4} uren, {5} minuten en {6} seconden"
                                                    , moves.ToString(), totalCenturies, totalYears,
                                                    totalDays, totalHours, totalMinutes, totalSeconds);
                    MessageBox.Show(message, title);
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
        public void convertSecondsToTime()
        {
            totalSeconds = moves;
            totalMinutes = 0;
            totalHours = 0;
            totalDays = 0;
            totalYears = 0;
            totalCenturies = 0;

            if (totalSeconds < 60)
            {

            }
            else if (totalSeconds > 60)
            {
                totalMinutes = totalSeconds / 60; // calculates the number of minutes
                totalSeconds = totalSeconds % 60; // calculates the number of left over seconds

                if (totalMinutes > 60)
                {
                    totalHours = totalMinutes / 60; // calculates the number of hours
                    totalMinutes = totalMinutes % 60; // calculates the number of left over minutes

                    if (totalHours > 24)
                    {
                        totalDays = totalHours / 24; // calculates the number of days
                        totalHours = totalHours % 24;  // calculates the number of left over hours

                        if (totalDays > 365)
                        {
                            totalYears = totalDays / 365; // calculates the number of years
                            totalDays = totalDays % 365; // calculates the number of left over days

                            if (totalYears > 100)
                            {
                                totalCenturies = totalYears / 100; // calculates the number of centuries
                                totalYears = totalYears % 100; // calculates the number of left over years
                            }
                        }
                    }
                }
            }
        }
    }
}

    


