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
    public partial class Recursive : Form
    {
        int incrementRecursion;
        ulong currentmoves = 1;
        ulong pastmoves = 1;

        ulong totalSeconds = 0;
        ulong totalMinutes = 0;
        ulong totalHours = 0;
        ulong totalDays = 0;
        ulong totalYears = 0;
        ulong totalCenturies = 0;

        public Recursive()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            incrementRecursion = 0;
            int limit = 0;
            currentmoves = 0;
            pastmoves =0;
            int.TryParse(amountDiscsTextbox.Text, out limit);
            {
                if(limit >= 1 && limit <= 64)
                {
                convertSecondsToTime();
                // message box
                string title = "Toren van Hanoi";
                string message = String.Format("Het aantal zetten is: {0}.\r\n" +
                                                "De tijd om dit te voltooien is: {1} eeuwen, {2} jaren, {3} dagen" +
                                                ", {4} uren, {5} minuten en {6} seconden"
                                                , currentmoves.ToString(), totalCenturies, totalYears,
                                                totalDays, totalHours, totalMinutes, totalSeconds);
                MessageBox.Show(message, title);
                }

                
                
                else
                {
                    MessageBox.Show("Het getal moet tussen de 1 en 64 zijn");
                }
            }
             void convertSecondsToTime()
            {
                totalSeconds = currentmoves;
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

}
