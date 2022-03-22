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
            this.pdLbWight.Text = User.Weight.ToString() + " kg";
        }

        private async void prelod()
        {
            var tbl = await this.DB.SelectAsTableAsync(DBQuerys.select_activitys);

            this.perCbActivity.LoadFromTable(tbl, Activity.Create);

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
            if (((Activity)perCbActivity.SelectedItem).Factor == null)
                perNudTrainingHeartRade.Value = ((decimal)User.HpMax - perNudRestingPulse.Value) * 0 + perNudRestingPulse.Value;
            else
                perNudTrainingHeartRade.Value = ((decimal)User.HpMax - perNudRestingPulse.Value) * (decimal)((Activity)perCbActivity.SelectedItem).Factor + perNudRestingPulse.Value;
        }


    }
}
