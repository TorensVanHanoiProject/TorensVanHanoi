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
        
        ulong numberOfdiscs;
        ulong moves = 1;
        ulong totalSeconds = 0;
        ulong totalMinutes = 0;
        ulong totalHours = 0;
        ulong totalDays = 0;
        ulong totalYears = 0;
        ulong totalCenturies = 0;
        string userInput;

        public Recursive()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                userInput = amountDiscsTextbox.Text;
                numberOfdiscs = ulong.Parse(userInput);
                if (numberOfdiscs >= 1 && numberOfdiscs <= 64)
                {

                    moves = 1;
                    moves = count(0, 1, numberOfdiscs);

                    convertSecondsToTime();

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
                    MessageBox.Show("Je moet een getal tussen de 1 en 64 invoeren!");
                }
            }
            catch
            {
                MessageBox.Show("Je moet wel een nummer invoeren voordat je iets kan uitrekenen!(dus ook geen tekst)");
            }
            
               
            

              
        }

        static ulong count(ulong moves, ulong currentDiscs, ulong numberOfDiscs)
        {
            if(currentDiscs > numberOfDiscs)
            {
                return moves;
            }
            else
            {
                moves = moves * 2 + 1;
                ulong result = count(moves, currentDiscs + 1, numberOfDiscs);

                return result;
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