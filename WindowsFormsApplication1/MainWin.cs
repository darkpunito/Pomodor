using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WindowsFormsApplication1
{    

    public partial class MainWin : Form
    {


        public int timeLeftWork, timeLeftHoursWork,  timeLeftMinutesWork, timeLeftSecondsWork;
        public int timeLeftRest, timeLeftHoursRest, timeLeftMinutesRest, timeLeftSecondsRest;
        public int WorkSessionsLeft, WorkSessions;
        Form2 form;
        MainWin mainwin;

        public MainWin()

        {
            InitializeComponent();
            mainwin = this;
            form = new Form2(this);
            
            //Form2 form = new WindowsFormsApplication1.Form2(this);


        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // while (WorkSessions >= 0)

            if (timeLeftWork >= 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLabelRest.Text = "WORK!";   //show text in other label

                timeLeftHoursWork = timeLeftWork / 3600;
                //timeLeftMinutesWork = timeLeftWork / 60;
                //show remaining time
                timeLabelWork.Text = timeLeftWork / 3600 + ":" + (timeLeftWork / 60 - (timeLeftWork / 3600) * 60) + ":" + timeLeftWork % 60;
                timeLeftWork = timeLeftWork - 1;
                startButton.Enabled = false;
            }

            else
            {
                // If the session is over, stop the work timer and start rest timer
                //WorkSessions--;
                timer1.Stop();
                timer2.Enabled = true;
                timer2.Start();
                timer2_Tick(null, EventArgs.Empty);
                playSimpleSound(true);

            }

        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            //opening new form for options
            //if (form == null)
            //{
            //    form = new Form2();
            //}


            form.Show();
            this.Hide();

        }

        private void playSimpleSound(bool Play)
        {
            //MessageBox.Show(Environment.CurrentDirectory);
            string path = Path.Combine(Environment.CurrentDirectory, @"Sounds\", @"ChillingMusic.wav");
            SoundPlayer simpleSound = new SoundPlayer(path);//@"C:\Users\trion_000\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Sounds\ChillingMusic.wav");
            if (Play == true)
            {

                simpleSound.Play();
            }
            else
            {
                simpleSound.Stop();
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeftRest >= 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                //timeLabelWork.Text = "Rest";

                timeLeftHoursRest = timeLeftRest / 3600;
                timeLeftMinutesRest = timeLeftRest / 60;
                timeLabelRest.Text = timeLeftHoursRest + ":" + (timeLeftMinutesRest - timeLeftHoursRest * 60) + ":" + timeLeftRest % 60;
                timeLeftRest = timeLeftRest - 1;
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                //timer1.Stop();
                //timeLabelRest.Text = "Nice";
                timer2.Stop();
                //timer2.Enabled = true;

                timeLeftWork = timeLeftMinutesWork * 60 + timeLeftSecondsWork;
                timeLeftRest = timeLeftMinutesRest * 60 + timeLeftSecondsRest;
                WorkSessionsLeft = WorkSessionsLeft - 1;

                playSimpleSound(false);
                if (WorkSessionsLeft > 0)
                {



                    //startButton_Click(sender, e);
                    timer1.Enabled = true;
                    timer1.Start();
                    timer1_Tick(null, EventArgs.Empty);


                }
                else
                {
                    startButton.Enabled = true;
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

                   
        private void startButton_Click(object sender, EventArgs e)
        {
            timeLeftWork = timeLeftMinutesWork*60+timeLeftSecondsWork;
            timeLeftRest = timeLeftMinutesRest * 60 + timeLeftSecondsRest;
            WorkSessionsLeft = WorkSessions;
            
            timer1.Start();
            timer1_Tick(null, EventArgs.Empty);
            
        }
    }
}
