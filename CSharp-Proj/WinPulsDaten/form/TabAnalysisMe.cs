using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using WinPulsDaten.data;
using WinPulsDaten.database;

namespace WinPulsDaten
{
    public partial class FrmMain
    {

        // Event: When this tab get's selected
        private async Task tabAnalysisMeSelect()
        {
            this.SetTabeable(false, this.anmeCbActivity);

            try
            {

                // Appends the activitys them to the combobox
                this.anmeCbActivity.LoadFromTable(await this.DB.SelectAsTableAsync(DBQuerys.select_activitys), Activity.Create);
            }catch(Exception e)
            {
                // TODO
                Console.WriteLine(e);
            }

            this.SetTabeable(true, this.anmeCbActivity);
        }

        // Event: When the user selects an activity for his analysis
        private async void OnAnmeActivityChanged(object sender, EventArgs e)
        {
            // Loads a datatable with x axis and the name
            void LoadDT(DataTable table, string xAxis, string tableName)
            {
                this.anmeChartDisplay.Series.Clear();
                this.anmeChartDisplay.DataBindTable(table.DefaultView, xAxis);

                // Gets the added series
                var series = this.anmeChartDisplay.Series[0];

                // Updates the values
                series.Name = tableName;
                series.ChartType = SeriesChartType.Spline;
            }

            this.SetTabeable(false, this.anmeCbActivity);

            try
            {
                // Gets the selected activity-id
                var actId = ((Activity)this.anmeCbActivity.SelectedItem).Id;

                // Loads the chart
                {
                    // Performs the request
                    var cmd = await this.DB.PrepareStatementAsync(DBQuerys.select_personPulseOverTime);

                    // Appends the parameters
                    cmd.Parameters.AddWithValue("@person",this.User.Id);
                    cmd.Parameters.AddWithValue("@activity", actId);
                    cmd.Prepare();

                    // Loads and updates the chart
                    LoadDT(await this.DB.SelectAsTableAsync(cmd), "time", "Puls over time");
                }

                // Loads the critical values
                {
                    var cmd = await this.DB.PrepareStatementAsync(DBQuerys.select_criticalPulses);

                    // Appends parameters
                    cmd.Parameters.AddWithValue("@person", this.User.Id);
                    cmd.Parameters.AddWithValue("@activity", actId);
                    cmd.Prepare();

                    // Loads the table
                    var tbl = await this.DB.SelectAsTableAsync(cmd);
                    tbl.Columns[0].ColumnName = "Value";
                    tbl.Columns[1].ColumnName = "Timestamp";

                    this.anmeGDVCriticalViews.DataSource = tbl;
                }
            }
            catch(Exception ex)
            {
                // TODO
                Console.WriteLine(ex);
            }

            this.SetTabeable(true, this.anmeCbActivity);
        }
    }
}
