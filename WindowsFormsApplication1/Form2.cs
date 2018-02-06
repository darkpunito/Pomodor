using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
  
    public partial class Form2 : Form
    {
        MainWin okno;
        public Form2(MainWin mainwin)
        {
            InitializeComponent();
            okno = mainwin;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Form1.timeLeftMinutesWork = Convert.ToInt32(optionsworkminuteschoice.Value);
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void optionsButton_Click_1(object sender, EventArgs e) 
        {

            //MainWin okno = new Mainwin();
            //PreviousChoices proba = new PreviousChoices();
            //Properties.Settings
            //proba.timeLeftMinutesWork = Convert.ToInt32(optionsworkminuteschoice.Value);
           // proba.timeLeftSecondsWork = Convert.ToInt32(optionsworksecondschoice.Value);

           // proba.timeLeftMinutesRest = Convert.ToInt32(optionsrestminuteschoice.Value);
            //proba.timeLeftSecondsRest = Convert.ToInt32(optionsrestsecondschoice.Value);

            //proba.WorkSessions = Convert.ToInt32(optionsWorkSessionsChoice.Value);
           // optionsworkminuteschoice.Value = proba.timeLeftMinutesWork;

            okno.timeLeftMinutesWork = Convert.ToInt32(optionsworkminuteschoice.Value);
            okno.timeLeftSecondsWork = Convert.ToInt32(optionsworksecondschoice.Value);

            okno.timeLeftMinutesRest = Convert.ToInt32(optionsrestminuteschoice.Value);
            okno.timeLeftSecondsRest = Convert.ToInt32(optionsrestsecondschoice.Value);

            okno.WorkSessions = Convert.ToInt32(optionsWorkSessionsChoice.Value);


            this.Hide();
            okno.Show();
            //MainWin.Close();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //Form1.timeLeftSecondsWork = Convert.ToInt32(optionsworksecondschoice.Value);
        }

        private void optionsWorkSessionsChoice_ValueChanged(object sender, EventArgs e)
        {
            //Form1.WorkSessions = Convert.ToInt32(optionsWorkSessionsChoice.Value);
        }

        private void optionsrestminuteschoice_ValueChanged(object sender, EventArgs e)
        {
            //Form1.timeLeftMinutesRest = Convert.ToInt32(optionsrestminuteschoice.Value);
        }

        private void optionsrestsecondschoice_ValueChanged(object sender, EventArgs e)
        {
            //Form1.timeLeftSecondsRest = Convert.ToInt32(optionsrestsecondschoice.Value);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cos;
            cos = listBox1.SelectedItem.ToString();
            //MessageBox.Show((listBox1.SelectedItem).ToString());
            MessageBox.Show(cos);
           //PreviousChoices listbox1.SelectedItem.Tostring();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void choiceOptions_ValueChanged(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(choiceOptions.Value);
            MessageBox.Show(k.ToString());
            // int b = choiceOptions.Value;
           // int c = (choiceOptions)EventArgs.Equals;
           // PreviousChoices a = new PreviousChoices();
            //optionsworkminuteschoice.Value = proba.timeLeftMinutesWork;
        }
    }
}
