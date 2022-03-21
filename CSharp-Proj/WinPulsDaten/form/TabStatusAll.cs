using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPulsDaten.database;

namespace WinPulsDaten
{
    public partial class FrmMain
    {
        // Event: When this tab get's selected
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
            catch (Exception ex)
            {
                // Sends the user to the welcome page and shows an error
                this.tabControll.SelectedIndex = 0;
                MessageBox.Show(ex.Message, "Database-connection error");
            }

            // Reenables the mode selection
            this.staCbMode.Enabled = true;
        }
    }
}
