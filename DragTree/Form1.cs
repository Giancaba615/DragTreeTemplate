using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragTree 
{
    public partial class Form1 : Form
    {

        int currentRow = 1;

        Stopwatch mywatch = new Stopwatch();


        // TODO - create a timer on the form called lightTimer (interval 400ms)
        // TODO - create the tick event for the lightTimer

        // place the following comments in the lighTimer tick event
        // TODO - create a switch block that checks currentRow. In each case
        // it will light up the appropriate lights, (labels). 

        // TODO - increment the currentRow value by 1

        public Form1()
        {


            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // TODO - start the timer
            startTimer.Enabled = true;


        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // TODO - stop the stopwatch

            // TODO - check if the ellapsed time in milliseconds is > 0. 
            // If yes show the time.
            // If no show "FOUL START"                       
            mywatch.Stop();


           timeLabel.Text = mywatch.Elapsed.ToString(@"m\:ss\:fff");
            if(mywatch.ElapsedMilliseconds > 0 )
            {
                mywatch.Start();
            }
            else
            {
                timeLabel.Text = "Foul Start";
            }


    
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // TODO - reset the stopwatch

            // TODO - put rows 1-3 colours back to DimGray and row 4 back to DarkOliveGreen

            // TODO - reset row value and timeLabel text
            mywatch.Reset();

          
            
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            if (currentRow == 1)
            {
                row1col1.BackColor = Color.Yellow;
                row1col2.BackColor = Color.Yellow;              
                currentRow = 2; 
                                           
            }
            else if (currentRow == 2)
            {
                row2col1.BackColor = Color.Yellow;
                row2col2.BackColor = Color.Yellow;
                currentRow = 3;
            }
            else if (currentRow == 3)
            {
                row3col1.BackColor = Color.Yellow;
                row3col2.BackColor = Color.Yellow;
                currentRow = 4;
            }
            else if (currentRow == 4)
            {
                row4col1.BackColor = Color.Green;
                row4col2.BackColor = Color.Green;
                
                mywatch.Start();                                        
            }


        }
    }
}
