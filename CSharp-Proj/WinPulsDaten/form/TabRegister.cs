using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPulsDaten.database;

namespace WinPulsDaten
{


    public partial class FrmMain
    {

        private void tabRegisterSelect()
        {
            regCbGender.SelectedIndex = 0;
            regRadHPAuto.Checked = true;
            regNudHpMax.Enabled = false;
            regDpAge.MaxDate = DateTime.Now;
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

                this.regCbGender.Items.Clear();

                foreach(DataRow row in tbl.Rows)
                    this.regCbGender.Items.Add(Gender.Create(row));

                tbl = await DB.SelectAsTableAsync(DBQuerys.select_AllTrainingCondition);

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
        private void regBtnLogin_Click(object sender, EventArgs e)
        {

            /*
             * Create new pd refercenz
             */
            PersonData pd = new PersonData(regTbFirstname.Text.ToString(), regTbLastname.Text.ToString(), regTbPassword.Text.ToString(), regTbPasswordConfirm.Text.ToString(), (float)regNudWight.Value, (float)regNutSize.Value, ((Gender)this.regCbGender.SelectedItem).ID, regDpAge.Value, (float)regNudHpMax.Value);

            /*
             * Validate Register form
             */
            if (pd.Firstname.Length <= 0)
            {
                MessageBox.Show("Firstname is requried");
                return;
            }

            if (pd.Lastname.Length <= 0)
            {
                MessageBox.Show("Lastname is requried");
                return;
            }

            if (pd.Password.Length <= 0)
            {
                MessageBox.Show("Password is required");
                return;
            }

            if (pd.ConfPassword.Length <= 0)
            {
                MessageBox.Show("Conf password is required");
                return;
            }

            if (!string.Equals(pd.Password, pd.ConfPassword))
            {
                MessageBox.Show("Password are not eqauls");
                return;
            }

            if (pd.Wight <= 0)
            {
                MessageBox.Show("Wight is requried");
                return;
            }

            if (pd.Size <= 0)
            {
                MessageBox.Show("Size is requried");
                return;
            }

            if (pd.Gender <= 0)
            {
                MessageBox.Show("Gender is requried");
                return;
            }

            if (regRadHFManual.Checked)
            {
                MessageBox.Show("HF is requried");
                return;
            }
            /*
             * Validate end
             */


        }

        /*
         * @params: System
         * @handle: Enable HPmax textbox
         * @retrun: Void
         * @author: Florian Keller <2022/03/21 12:18>
         */
        private void regRadHFManual_CheckedChanged(object sender, EventArgs e)
        {
            regNudHpMax.Enabled = true;
        }

        /*
         * @params: System
         * @handle: Disable HPmax textbox
         * @retrun: Void
         * @author: Florian Keller <2022/03/21 12:17>
         */
        private void regRadHPAuto_CheckedChanged(object sender, EventArgs e)
        {
            regNudHpMax.Enabled = false;
        }

        /*
         * @params: NULL
         * @handle: Calcuate max HF 
         * @retrun: Void
         * @author: Florian Keller <2022/03/21 12:22>
         */
        private void calculateHFmax()
        {

        }
    }

}
