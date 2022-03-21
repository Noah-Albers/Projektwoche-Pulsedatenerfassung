using System;
using System.Windows.Forms;
using WinPulsDaten.database;

namespace WinPulsDaten
{
    public partial class FrmMain : Form
    {
        // Connection to the Database-Management-System-Server
        private readonly Database DB = new Database("localhost", "pulsdaten", "root", "");

        public FrmMain()
        {
            InitializeComponent();
            regCbGender.SelectedIndex = 0;
            regRadHPAuto.Checked = true;
            regNudHpMax.Enabled = false;
            regDpAge.MaxDate = DateTime.Now;
        }



        private void regLbKG_Click(object sender, EventArgs e)
        {

        }

        private void perLbTrainingHeartRade_Click(object sender, EventArgs e)
        {

        }

        private void tabRegister_Click(object sender, EventArgs e)
        {

        }

        private void tabRegisterSelect()
        {
            regesiterNewUser();
        }


        private void regesiterNewUser()
        {
            //TODO: select all gender from database
        }




        private void regBtnLogin_Click(object sender, EventArgs e)
        {
            PersonData pd = new PersonData(regTbFirstname.Text.ToString(), regTbLastname.Text.ToString(), regTbPassword.Text.ToString(), regTbPasswordConfirm.Text.ToString(), (float)regNudWight.Value, (float)regNutSize.Value, regCbGender.SelectedItem.ToString(), regDpAge.Value, (float)regNudHpMax.Value);


            /*
             * Validate Register form
             */

            if(pd.Firstname.Length <= 0)
            {
                MessageBox.Show("Firstname is requried");
                return;
            }

            if(pd.Lastname.Length <= 0)
            {
                MessageBox.Show("Lastname is requried");
                return;
            }

            if(pd.Password.Length <= 0)
            {
                MessageBox.Show("Password is required");
                return;
            }

            if(pd.ConfPassword.Length <= 0)
            {
                MessageBox.Show("Conf password is required");
                return;
            }

            if (!string.Equals(pd.Password, pd.ConfPassword))
            {
                MessageBox.Show("Password are not eqauls");
                return;
            }

            if(pd.Wight <= 0)
            {
                MessageBox.Show("Wight is requried");
                return;
            }

            if(pd.Size <= 0)
            {
                MessageBox.Show("Size is requried");
                return;
            }

            if (pd.Gender.Length <= 0)
            {
                MessageBox.Show("Gender is requried");
                return;
            }

            if (pd.Gender.Length <= 0)
            {
                MessageBox.Show("Gender is requried");
                return;
            }

            if(regRadHFManual.Checked)
            {
                MessageBox.Show("HF is requried");
                return;
            }



        }

        private void regRadHFManual_CheckedChanged(object sender, EventArgs e)
        {
            regNudHpMax.Enabled = true;
        }

        private void regRadHPAuto_CheckedChanged(object sender, EventArgs e)
        {
            regNudHpMax.Enabled = false;
        }

        private void calculateHFmax()
        {

        }



        #region Status (All)

        private void tabStatsAllSelect() => this.staCbMode.SelectedIndex = 0;

        // Event: When a different display mode get's selected
        private async void staCbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disables the mode selection
            this.staCbMode.Enabled = false;

            try
            {
                // Removes any previous elements
                this.staChartDisplay.Series.Clear();

                // Checks which display got selected
                switch (this.staCbMode.SelectedIndex)
                {
                    // Age over hp
                    case 0:
                        // Updates the chart
                        this.staChartDisplay.DataBindTable(this.DB.SelectAsTable(DBQuerys.select_HpOverAge).DefaultView, "age");
                        this.staChartDisplay.Series[0].Name = "MaxHP over Age";
                        break;

                    // Restpuls over weight
                    case 1:
                        // Updates the chart
                        this.staChartDisplay.DataBindTable(this.DB.SelectAsTable(DBQuerys.select_RestpulsOverWeight).DefaultView, "weight");
                        this.staChartDisplay.Series[0].Name = "Restpulse over weight";
                        break;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Database-connection error");
            }

            // Reenables the mode selection
            this.staCbMode.Enabled = true;
        }

        #endregion

        private void tabControll_TabIndexChanged(object sender, EventArgs e)
        {
            // Checks for the tab changes and executes their events


            if (this.tabControll.SelectedTab.Equals(this.tabStatsAll))
                this.tabStatsAllSelect();

            else if (this.tabControll.SelectedTab.Equals(this.tabRegister))
                this.tabRegisterSelect();
        }
    }
}
