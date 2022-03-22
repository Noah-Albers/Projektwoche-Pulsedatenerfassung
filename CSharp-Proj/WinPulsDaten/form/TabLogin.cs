using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPulsDaten.data;
using WinPulsDaten.database;

namespace WinPulsDaten
{
    public partial class FrmMain
    {

        // Event: When the user clicks the login button
        private async void logBtnLogin_Click(object sender, EventArgs e)
        {

            // Gets the values
            var fname = this.logTbFirstname.Text;
            var lname = this.logTbLastname.Text;
            var pwd = this.logTbPassword.Text;

            // Checks if the element are given
            if(fname.Trim().Length <= 0 || lname.Trim().Length <= 0)
            {
                MessageBox.Show("Please specify a name.","Error");
                return;
            }

            if(pwd.Length <= 0)
            {
                MessageBox.Show("Please specify a password.","Error");
                return;
            }

            try
            {

                // Prepares the statement and the values
                var cmd = await this.DB.PrepareStatementAsync(DBQuerys.select_loginUser);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@passwd", pwd);
                cmd.Prepare();

                // Tries to get a result
                var tbl = await this.DB.SelectAsTableAsync(cmd);

                // Checks if the login failed
                if(tbl.Rows.Count <= 0)
                {
                    MessageBox.Show("Failed to login. Wrong Username or Password or Sql-Query.","Login error");
                    return;
                }

                // Gets the user
                this.User = Person.Create(tbl.Rows[0]);

                // Updates the tabControl for the logged in user
                this.UpdateTabs();

                MessageBox.Show($"Welcome {this.User.Firstname} {this.User.Lastname} born on {this.User.Birth}", "Login successfull");
            }
            catch(Exception ex)
            {
                // TODO
                Console.WriteLine(ex);
            }

        }

    }
}
