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

        // Event: When the user clicks the delete button
        private async void OnSetButtonDelteClicked(object sender, EventArgs e)
        {
            var withSup = this.setChbDeleteSuperUser.Checked;

            this.SetTabeable(false);

            try
            {
                // Sends the updates
                await this.DB.InsertAsync(DBQuerys.delete_Pulsdate);
                await this.DB.InsertAsync(withSup ? DBQuerys.delete_Person : DBQuerys.delete_WithoutSuperUser);

                // Checks if the user itself got deleted
                if (withSup)
                {
                    // Performs a logout
                    this.User = null;
                    this.UpdateTabs();
                }

                MessageBox.Show("All data successful deleted.");
            }
            catch(Exception ex)
            {
                this.tabControll.SelectedIndex = 0;
                MessageBox.Show(ex.Message, "Database-error");
            }

            this.SetTabeable(true);

        }

    }
}
