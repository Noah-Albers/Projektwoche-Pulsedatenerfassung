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

        private void tabRegisterSelect()
        {
            regCbGender.SelectedIndex = 0;
            regRadHPAuto.Checked = true;
            regDpBirth.MaxDate = DateTime.Now;
            regNewUser();
        }

          /*
           * @params:   null
           * @handle:   sql query from gender and training condition
           * @return:   void
           * @author:   Florian Keller <2022/03/21 12:40>
           */
        private async void regNewUser()
        {
            try
            {
                var tbl = await DB.SelectAsTableAsync(DBQuerys.select_AllGender);

                this.regCbGender.LoadFromTable(tbl, Gender.Create);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unerwarteter Fehler aufgetraucht");
            }
        }


        /*
         * @params: System
         * @handle: Regsiter new User with valdiation
         * @retrun: Void
         * @author: Florian Keller <2022/03/21 12:20>
         */
        private async void regBtnLogin_Click(object sender, EventArgs e)
        {

            /*
             * Create new pd refercenz
             */

            var fname = regTbFirstname.Text.ToString();
            var lname = regTbLastname.Text.ToString();
            var pwd = regTbPassword.Text.ToString();
            var weight = (float)regNudWight.Value;
            var size = (float)regNutSize.Value;
            var genderId = ((Gender)this.regCbGender.SelectedItem).ID;
            var birth = regDpBirth.Value;
            var hfmax = (float)regNudHpMax.Value;


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

            if (weight <= 0)
            {
                MessageBox.Show("Wight is requried");
                return;
            }

            if (size <= 0)
            {
                MessageBox.Show("Size is requried");
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
                cmd.Parameters.AddWithValue("@gender",genderId);
                cmd.Parameters.AddWithValue("@bodysize",size);
                cmd.Parameters.AddWithValue("@weight",weight);
                cmd.Parameters.AddWithValue("@condition",1); //TODO: Implement the dropdown here
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
    }

}
