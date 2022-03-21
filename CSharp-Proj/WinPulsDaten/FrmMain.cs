using System;
using System.Windows.Forms;
using WinDatabaseTest;
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
        }

        private void regLbKG_Click(object sender, EventArgs e)
        {

        }

        private void perLbTrainingHeartRade_Click(object sender, EventArgs e)
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


            if(this.tabControll.SelectedTab.Equals(this.tabStatsAll))
                this.tabStatsAllSelect();
        }
    }
}
