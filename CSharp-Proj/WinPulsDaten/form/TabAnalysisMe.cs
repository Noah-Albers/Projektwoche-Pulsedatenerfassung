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
            this.anmeCbActivity.Enabled = false;
            try
            {
                // Gets the activitys
                var tbl = await this.DB.SelectAsTableAsync(DBQuerys.select_activitys);

                // Appends them to the combobox
                this.anmeCbActivity.LoadFromTable(tbl, Activity.Create);
            }catch(Exception e)
            {
                // TODO
                Console.WriteLine(e);
            }

            this.anmeCbActivity.Enabled = true;
        }


        // Event: When the user selects an activity for his analysis
        private async void anmeCbActivity_SelectedIndexChanged(object sender, EventArgs e)
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

            this.anmeCbActivity.Enabled = false;

            try
            {
                // Performs the request
                var cmd = await this.DB.PrepareStatementAsync(DBQuerys.select_personPulseOverTime);

                // Appends the parameters
                cmd.Parameters.AddWithValue("@person",this.User.Id);
                cmd.Parameters.AddWithValue("@activity", ((Activity)this.anmeCbActivity.SelectedItem).Id);
                cmd.Prepare();

                // Executes the query
                var tbl = await this.DB.SelectAsTableAsync(cmd);

                // Updates the chart
                LoadDT(tbl, "time", "Puls over time");
            }
            catch(Exception ex)
            {
                // TODO
                Console.WriteLine(ex);
            }

            this.anmeCbActivity.Enabled = true;
        }
    }
}
