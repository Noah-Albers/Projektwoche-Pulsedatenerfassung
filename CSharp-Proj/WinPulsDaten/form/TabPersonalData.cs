using System;
using System.Windows.Forms;
using WinPulsDaten.data;
using WinPulsDaten.database;

namespace WinPulsDaten
{
    public partial class FrmMain
    {
        // Event: When the tab gets switch to this view
        private async void OnTabPersonalDataSelect()
        {
            // Updates the views
            this.pdLbFirstname.Text = User.Firstname;
            this.pdLbLastname.Text = User.Lastname;
            this.pdLbSize.Text = User.Size.ToString() + " m";
            this.pdLbWeight.Text = User.Weight.ToString() + " kg";

            this.SetTabeable(false);

            try
            {
                // Requests the data from the database
                var tbl = await this.DB.SelectAsTableAsync(DBQuerys.select_activitysWithFactor);

                this.perCbActivity.LoadFromTable(tbl, Activity.Create);
            }
            catch (Exception ex)
            {
                this.tabControll.SelectedIndex = 0;
                MessageBox.Show(ex.Message, "Database-error");
            }

            this.SetTabeable(true);
        }

        // Event: When the activity is changed by the user
        private void OnPerActivityChanged(object sender, EventArgs e) => CalcuatePersonalTrainingHeartRate();

        // Event: When the user changes the restig-puls
        private void OnePerRestingPulsChange(object sender, EventArgs e) => CalcuatePersonalTrainingHeartRate();

        // Calculates the training heart-rate and update the form
        private void CalcuatePersonalTrainingHeartRate()
        {
            perNudTrainingHeartRade.Value = ((decimal)User.HfMax - perNudRestingPulse.Value) * (decimal)((Activity)perCbActivity.SelectedItem).Factor + perNudRestingPulse.Value;
        }


    }
}
