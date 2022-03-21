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
            this.tabControll_TabIndexChanged();
        }



        private void regLbKG_Click(object sender, EventArgs e)
        {

        }

        private void perLbTrainingHeartRade_Click(object sender, EventArgs e)
        {

        }


        private void tabControll_TabIndexChanged(object sender = null, EventArgs e = null)
        {
            // Checks for the tab changes and executes their events


            if (this.tabControll.SelectedTab.Equals(this.tabStatsAll))
                this.tabStatsAllSelect();

            else if (this.tabControll.SelectedTab.Equals(this.tabRegister))
                this.tabRegisterSelect();
        }
    }
}
