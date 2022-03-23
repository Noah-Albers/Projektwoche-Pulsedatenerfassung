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
        /// <summary>
        /// UI-Function to try to login the user.
        /// This does affect UI-elements and should be awaited.
        /// Tabs may be disabled and ui-elements may be unusable for a portion of time.
        /// </summary>
        /// <param name="fname">User's firstname</param>
        /// <param name="lname">User's lastname</param>
        /// <param name="passwd">User's password</param>
        /// <returns>If the user got logged in successfully</returns>
        private async Task<bool> TryLoginUser(string fname, string lname, string passwd)
        {
            // Checks if the element are given
            if (fname.Trim().Length <= 0 || lname.Trim().Length <= 0)
            {
                MessageBox.Show("Please specify a name.", "Error");
                return false;
            }

            if (passwd.Length <= 0)
            {
                MessageBox.Show("Please specify a password.", "Error");
                return false;
            }

            this.SetTabeable(false);

            try
            {
                // Prepares the statement and the values
                var cmd = await this.DB.PrepareStatementAsync(DBQuerys.select_loginUser);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@passwd", passwd);
                cmd.Prepare();

                // Tries to get a result
                var tbl = await this.DB.SelectAsTableAsync(cmd);

                // Checks if the login failed
                if (tbl.Rows.Count <= 0)
                {
                    MessageBox.Show("Failed to login. Wrong Username or Password or Sql-Query.", "Login error");
                    this.SetTabeable(true);
                    return false;
                }

                // Gets the user
                this.User = Person.Create(tbl.Rows[0]);

                // Updates the tabControl for the logged in user
                this.UpdateTabs();

                this.SetTabeable(true);
                return true;
            }
            catch (Exception ex)
            {
                this.tabControll.SelectedIndex = 0;
                MessageBox.Show(ex.Message, "Database-error");

                this.SetTabeable(true);
                return false;
            }

        }


        // Event: When the user clicks the login button
        private async void OnLogLoginClicked(object sender, EventArgs e)
        => await TryLoginUser(
            this.logTbFirstname.Text,
            this.logTbLastname.Text,
            this.logTbPassword.Text
        );

    }
}
