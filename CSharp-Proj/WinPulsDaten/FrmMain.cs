using System;
using System.Windows.Forms;
using WinPulsDaten.data;

namespace WinPulsDaten
{
    public partial class FrmMain : Form
    {
        // Connection to the Database-Management-System-Server
        private readonly Database DB = new Database("localhost", "pulsdaten", "root", "");

        // Login in user (Optional, if logged out this will be null)
        private Person User = new Person
        {
            Firstname = "Billy",
            Lastname = "Butcher",
            isSup = true
        };

        // Random generator (Handy to have around)
        private readonly Random rdm = new Random();

        public FrmMain()
        {
            InitializeComponent();

            this.UpdateTabs();
        }

        /// <summary>
        /// Method to update the main tabcontrol and ensure that only the tabs that the user can access are visible.
        /// </summary>
        private void UpdateTabs()
        {
            // Removes all tab-pages
            this.tabControll.TabPages.Clear();

            // Short version to add a tab-page
            void add(params TabPage[] pages) => this.tabControll.TabPages.AddRange(pages);

            // Adds the defaults
            add(this.tabWelcome,this.tabStatsAll);
            
            // Checks if the user isn't logged in 
            if(this.User == default)
                add(this.tabRegister, this.tabLogin);
            else
            {
                add(this.tabAnalysisMe, this.tabPersonalData);

                // If the user is a superuser
                if (this.User.isSup)
                    add(this.tabSettings);
            }
        }

        // Event: When the main tab-control changes view (Used to executed further tab-select events for the different tabs)
        private async void tabControll_TabIndexChanged(object sender, EventArgs e)
        {
            // Ensures that there is a tab selected
            if (this.tabControll.SelectedTab == default)
                return;


            // Checks for the tab change and execute the change events if required

            if (this.tabControll.SelectedTab.Equals(this.tabStatsAll))
                this.tabStatsAllSelect();

            else if (this.tabControll.SelectedTab.Equals(this.tabRegister))
                this.tabRegisterSelect();

            else if (this.tabControll.SelectedTab.Equals(this.tabAnalysisMe))
                await this.tabAnalysisMeSelect();

            else if (this.tabControll.SelectedTab.Equals(this.tabSettings))
                this.tabSettingsSelect();
        }

        private void regRadHFManual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void regRadHPAuto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void regNutSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void regNudWight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void regCbTrainingCondition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void regCbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
