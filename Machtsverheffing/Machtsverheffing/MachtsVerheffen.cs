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

        ulong totalSeconds = 0;
        ulong totalMinutes = 0;
        ulong totalHours = 0;
        ulong totalDays = 0;
        ulong totalYears = 0;
        ulong totalCenturies = 0;

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

                    convertSecondsToTime();
                    // message box
                    string title = "Toren van Hanoi";
                    string message = String.Format("Het aantal zetten is: {0}.\r\n" +
                                                    "De tijd om dit te voltooien is: {1} eeuwen, {2} jaren, {3} dagen" +
                                                    ", {4} uren, {5} minuten en {6} seconden"
                                                    , totalMoves.ToString(), totalCenturies, totalYears,
                                                    totalDays, totalHours, totalMinutes, totalSeconds);
                    MessageBox.Show(message, title);
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
        public void convertSecondsToTime()
        {
            totalSeconds = totalMoves;
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
