using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //makes it so the regular expression can be used

namespace EduvosPlanner
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void b_OpenID_Click(object sender, EventArgs e)
        {

            

            if (T_Username.Text.EndsWith("@vossie.net")) // this will measure wether the end of a string will match the set condition 
                                                         /* https://learn.microsoft.com/en-us/dotnet/api/system.string.endswith?view=net-8.0 */
            {
                string input = T_Password.Text; //assign the password text box to a variable

                if (string.IsNullOrEmpty(input)) //isNullorEmpty tests wether a string is null or empty https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=net-8.0 
                {
                    MessageBox.Show("Please enter password");
                }
                else 
                {
                    Regex tPasswordRegex = new Regex("(?=.*[A-Z])(?=.*[a-z])(?=.*[^a-zA-Z0-9])(?=.{8,})"); //regex or regular expression checks for repeated occurences of words in strings, it will check through all occurences of lower case letters, upper case, numbers and wether there is a minimum of 8 characters

                    if (!tPasswordRegex.IsMatch(input)) //the !/not equal to operator will make so that if not all requirements are met the user will be prompted a textbox
                    {
                        MessageBox.Show("The password should contain at least one uppercase letter, one lowercase letter, one special character, and be at least 8 characters minimum");
                    }
                    else
                    {
                        new EduvosPlannerDashboard().Show(); //if conditions are met then the dashboard form will be shown
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("The username or password you have entered is incorrect. Please try again.");
            }
        }

        private void t_Username_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
