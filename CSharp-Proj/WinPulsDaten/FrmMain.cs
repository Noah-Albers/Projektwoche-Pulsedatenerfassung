using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinDatabaseTest;

namespace WinPulsDaten
{
    public partial class FrmMain : Form
    {
        private Database Db = new Database("localhost", "pulsdatenbank", "root", "");
        
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

        private void tabControll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControll.SelectedIndex == 0) regesiterNewUser();
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
    }
}
