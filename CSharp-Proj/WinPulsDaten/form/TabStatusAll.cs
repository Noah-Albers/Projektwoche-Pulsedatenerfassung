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
        // Event: When this tab get's selected
        private void tabStatsAllSelect() => this.staCbMode.SelectedIndex = 0;

        // Event: When a different display mode get's selected
        private async void staCbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Loads a datatable with x axis and the name
            void LoadDT(DataTable table, string xAxis, string tableName)
            {
                this.staChartDisplay.DataBindTable(table.DefaultView, xAxis);
                this.staChartDisplay.Series[0].Name = tableName;
            }

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
                        LoadDT(
                            await this.DB.SelectAsTableAsync(DBQuerys.select_HpOverAge),
                            "age",
                            "MaxHP over Age"
                        );
                        break;

                    // Restpuls over weight
                    case 1:
                        // Updates the chart
                        LoadDT(
                            await this.DB.SelectAsTableAsync(DBQuerys.select_RestpulsOverWeight),
                            "weight",
                            "Restpulse over weight"
                        );
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
