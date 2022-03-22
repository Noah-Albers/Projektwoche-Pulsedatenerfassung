using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPulsDaten.data;
using WinPulsDaten.database;

namespace WinPulsDaten
{
    public partial class FrmMain
    {
        private void tabPersonalDataSelect()
        {
            prelod();
            
            //TODO: Add label for values
            this.pdLbFirstname.Text = User.Firstname;
            this.pdLbLastname.Text = User.Lastname;
            this.pdLbSize.Text = User.Size.ToString() + " m";
            this.pdLbWeight.Text = User.Weight.ToString() + " kg";
        }

        private async void prelod()
        {
            try
            {
                var tbl = await this.DB.SelectAsTableAsync(DBQuerys.select_activitysWithFactor);

                this.perCbActivity.LoadFromTable(tbl, Activity.Create);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private void perCbActivity_TextChanged(object sender, EventArgs e)
        {
            calcuateTrainingHeartRate();
        }

        private void perNudRestingPulse_ValueChanged(object sender, EventArgs e)
        {
            calcuateTrainingHeartRate();
        }
        private void calcuateTrainingHeartRate()
        {
            perNudTrainingHeartRade.Value = ((decimal)User.HfMax - perNudRestingPulse.Value) * (decimal)((Activity)perCbActivity.SelectedItem).Factor + perNudRestingPulse.Value;
        }


    }
}
