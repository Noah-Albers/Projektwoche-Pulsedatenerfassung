using System;
using System.Collections.Generic;
using System.Data;
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

        // Event: Whenever an element that is required to calculate the hf-max get's changed
        private void OnRegHFValueChange(object _1 = null, EventArgs _2 = null)
        {
            // Checks if the calculation is disabled
            if (this.regRadHFManual.Checked)
                return;

            // Checks if the trainingcondition hasn't been loaded
            if (this.regCbTrainingCondition.SelectedIndex == -1)
                return;

            // Gets the values important to calculate
            var isMale = this.regCbGender.SelectedIndex == 0;
            var condition = ((Trainingcondition)this.regCbTrainingCondition.SelectedItem);

            // Gets the persons age
            int age = (int)(DateTime.Now.Subtract(this.regDpBirth.Value).TotalDays / 356);

            // Gets the caluator function and executes it
            int hfmax = HillsCalculations.GetCalculationFunction(isMale, condition)(age);

            // Updates the ui
            this.regNudHfMax.Value = hfmax;
        }

        // Event: When this tab gets selected
        private async void tabRegisterSelect()
        {
            regRadHfAuto.Checked = true;
            regDpBirth.MaxDate = DateTime.Now;
            regCbGender.SelectedIndex = 0;

            this.SetTabeable(false);

            try
            {
                // Updates the form
                this.regCbTrainingCondition.LoadFromTable(await DB.SelectAsTableAsync(DBQuerys.select_AllTrainingCondition), Trainingcondition.Create);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unerwarteter Fehler aufgetraucht");
            }

            this.SetTabeable(true);
        }

       // Event: When the user clicks the register button
        private async void OnRegRegisterClicked(object sender, EventArgs e)
        {

            // Ensures that values got loaded from the database
            if(this.regCbGender.SelectedIndex == -1 || this.regCbTrainingCondition.SelectedIndex == -1)
            {
                MessageBox.Show("Please wait until the datbase-values have been loaded.","Error");
                return;
            }

            /*
             * Create new pd refercenz
             */

            var fname = regTbFirstname.Text.ToString();
            var lname = regTbLastname.Text.ToString();
            var pwd = regTbPassword.Text.ToString();
            var weight = (float)regNudWight.Value;
            var size = (float)regNudSize.Value;
            var isMale = this.regCbGender.SelectedIndex == 0;
            var conditionId = ((Trainingcondition)this.regCbTrainingCondition.SelectedItem).ID;
            var birth = regDpBirth.Value;
            var hfmax = (float)regNudHfMax.Value;


            /*
             * Validate Register form
             */

            if (fname.Length <= 0)
            {
                MessageBox.Show("Firstname is requried");
                return;
            }

            if (lname.Length <= 0)
            {
                MessageBox.Show("Lastname is requried");
                return;
            }

            if (pwd.Length <= 0)
            {
                MessageBox.Show("Password is required");
                return;
            }

            if (!string.Equals(pwd, this.regTbPasswordConfirm.Text))
            {
                MessageBox.Show("Password are not eqauls");
                return;
            }

            if (hfmax <= 0)
            {
                MessageBox.Show("HF is requried");
                return;
            }

            /*
             * Validate end
             */




            // Generates a random salt (32 Bytes)
            byte[] b = new byte[32];
            this.rdm.NextBytes(b);
            var salt = Encoding.UTF8.GetString(b);
            try
            {
                // Registers the user
                var cmd = await this.DB.PrepareStatementAsync(DBQuerys.insert_createUser);

                // Appends the values
                cmd.Parameters.AddWithValue("@fname",fname);
                cmd.Parameters.AddWithValue("@lname",lname);
                cmd.Parameters.AddWithValue("@birth",birth);
                cmd.Parameters.AddWithValue("@gender",isMale);
                cmd.Parameters.AddWithValue("@bodysize",size);
                cmd.Parameters.AddWithValue("@weight",weight);
                cmd.Parameters.AddWithValue("@condition", conditionId);
                cmd.Parameters.AddWithValue("@hfmax",hfmax);
                cmd.Parameters.AddWithValue("@passwd",pwd);
                cmd.Parameters.AddWithValue("@salt",salt);
                cmd.Parameters.AddWithValue("@isSup",false);

                // Prepares and executes the query
                cmd.Prepare();

                // Inserts
                await this.DB.InsertAsync(cmd);

                // TODO: Handle stuff
                MessageBox.Show("You have successfully registered","Successfully registered");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                // TODO: Handle error
            }

        }

        // Event: When the caulation gets changed to manual
        private void OnRegSelectMangualHF(object sender, EventArgs e)
        {
            this.regNudHfMax.Enabled = true;
            this.OnRegHFValueChange();
        }

        // Event: When the caulation gets changed to auto
        private void regRadHfAuto_CheckedChanged(object sender, EventArgs e)
        {
            this.regNudHfMax.Enabled = false;
            this.OnRegHFValueChange();
        }

        // Event: When the info-icon get's clicked
        private void regBtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "The HF-Max value is your maximum puls.\n" +
                "It can be inserted when obtained from a" + 
                "doctor or calculated by this equation:\n" + 
                "base - (factor * age)\n\n" + 
                "The base and factor are values which are based\n" + 
                "on your training condition and if your male or female.\n" + 
                "Factor is between 0.5 and 0.8\n" + 
                "Base is between 220 and 200.", "Infos about the HF-Max-Value",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }

}
