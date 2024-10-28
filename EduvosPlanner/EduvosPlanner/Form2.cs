using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduvosPlanner
{
    public partial class EduvosPlannerDashboard : Form
    {
     
        public EduvosPlannerDashboard()
        {
            InitializeComponent();
            menuStrip2.Enabled = false; //Setting the menu strip to false means that it cannot be interacted with
            menuStrip3.Enabled = false;

            progressBar1.Step = 25; //progress bar value was set to 75 each increment will get it to 75

        }

        private void tuitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bachelorsDegreeToolStripMenuItem1.Visible = true;
            honoursDegreeToolStripMenuItem1.Visible = true;
            higherCertificateToolStripMenuItem.Visible = true;
            honoursDegreeToolStripMenuItem1.Visible = true;
            higherCertificateToolStripMenuItem.Visible = true;
            bachelorsDegreeToolStripMenuItem1.Visible = true;
            // if any option were to be reselected for the type of degree all durations are made visible so that no options remain invisible
            // if this was not added all durations would be made invisible and none could be selected if the user were to change their  mind
        }

        private void bachelorsDegree65000PerYearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void higherCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void commerceAndLawToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void bachelorOfBusinessAdministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesMethod("55 000", "65 000", "50 000"); //called method and passed on values
        }

        private void bachelorOfCommerceLawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesMethod("55 000", "65 000", "50 000"); //called method and passed on values

        }

        private void bachelorOfScienceInBiomedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesMethod("60 000", "65 000", "70 000"); //called method and passed on values
        }

        private void bachelorOfScienceInBiotechnologyManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesMethod("60 000", "65 000", "70 000"); //called method and passed on values

        }

        private void bachelorOfScienceInComputerScienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesMethod("70 000", "65 000", "80 000"); //called method and passed on values
        }

        private void bachelorOfScienceInInformationTechnologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesMethod("70 000", "65 000", "80 000"); //called method and passed on values
        }

        private void bachelorOfArtsGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesMethod("40 000", "55 000", "60 000"); //called method and passed on values
        }

        private void bachelorOfArtsInGraphicDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesMethod("40 000", "55 000", "60 000"); //called method and passed on values
        }

        private void higherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void FeesMethod(string f1, string f2, string f3) //this method will assign a value to the fees menu item and enable the next tool strip and it will also icrement the progress bar when a faculty is selected
        {
            fees1Item.Text = f1; //the parameter will be assigned to the menu item
            fees2Item.Text = f2;
            fees3Item.Text = f3;
            menuStrip2.Enabled = true;
            progressBar1.PerformStep();
        }

        private void fees1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            higherDurationMethod(" Default 1 year Full Time", "Extended +1 more year Part Time");
        }
        
        public void higherDurationMethod(string duration1, string duration2)//this method assigns a duration to the time menu item as well as hides options that are not required (this is what the duration methods will do)
        {
            time1ToolStripMenuItem.Text = duration1;
            time2ToolStripMenuItem.Text = duration2;
            bachelorsDegreeToolStripMenuItem1.Visible = false; 
            honoursDegreeToolStripMenuItem1.Visible = false; // hides  the other options that are not relevant
            menuStrip3.Enabled = true;
            progressBar1.Value = 50;

        }

        private void fees2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bachelorsDurationMethod("Default 3 years Full Time", "Extended +1 more year Part Time");
        }
        
        public void bachelorsDurationMethod(string duration3, string duration4)
        {
            time3ToolStripMenuItem.Text = duration3;
            time4ToolStripMenuItem.Text = duration4;
            higherCertificateToolStripMenuItem.Visible = false;
            honoursDegreeToolStripMenuItem1.Visible = false;
            menuStrip3.Enabled = true;
            progressBar1.Value = 50;
        }

        private void fees3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            honoursDurationMethod("Default1 year Full Time", "Extended +1 more year Part Time");
        }

        public void honoursDurationMethod(string duration5, string duration6) //method to assign a duration to the time menu item as well as increment the progress bar
        {
            time5ToolStripMenuItem1.Text = duration5;
            time6ToolStripMenuItem.Text = duration6;
            higherCertificateToolStripMenuItem.Visible = false;
            bachelorsDegreeToolStripMenuItem1.Visible = false;
            menuStrip3.Enabled = true;
            progressBar1.Value = 50;
        }

        private void time1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBarMethod(); //called the method
        }

        private void time2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBarMethod();
        }

        private void time3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBarMethod();
        }

        private void time4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBarMethod();
        }

        private void time5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            progressBarMethod();
        }

        private void time6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBarMethod();
        }

        public void progressBarMethod()
        {
            progressBar1.PerformStep(); //method that increments the progrees bar whenever a duration/time is chosen
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            progressBar1.Value = 0; //resets progress bar whenever faculty is reselected
            menuStrip2.Enabled = false; //making the menu strips false once faculty is selected makes it so that the other 2 menus cannot be selected until faculty is
            menuStrip3.Enabled = false;
            bachelorsDegreeToolStripMenuItem1.Visible = true;
            honoursDegreeToolStripMenuItem1.Visible = true;
            higherCertificateToolStripMenuItem.Visible = true;
            honoursDegreeToolStripMenuItem1.Visible = true;
            higherCertificateToolStripMenuItem.Visible = true;
            bachelorsDegreeToolStripMenuItem1.Visible = true;
        }

        private void EduvosPlannerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void EduvosPlannerDashboard_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
            if (e.CloseReason == CloseReason.UserClosing) //if statement checks if user is closing the form and if the button used to close the form is "X" in the form, if the condition is met then the code is executed
            {
                e.Cancel = false; //setting the cancel property to false the form closing event isnt cancelled and the form will close from the close option
            }
        }
    }
}
