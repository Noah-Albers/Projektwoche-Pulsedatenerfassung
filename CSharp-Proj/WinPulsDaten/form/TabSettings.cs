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

        private void tabSettingsSelect()
        {
            //regLoadData();
        }

        private async void setBtnDelte_Click(object sender, EventArgs e)
        {
            if (setChbDeleteSuperUser.Checked)
                // When checkbox is checked delete all user and pulsdate
                try
                {
                    await this.DB.InsertAsync(DBQuerys.delete_Pulsdate);
                    await this.DB.InsertAsync(DBQuerys.delete_Person);
                    User = null;
                    UpdateTabs();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    //TODO: handle error e
                }
            else
                // Delete no super user
                try
                {
                    await this.DB.InsertAsync(DBQuerys.delete_Pulsdate);
                    await this.DB.InsertAsync(DBQuerys.delete_WithoutSuperUser);
                    MessageBox.Show("All data successful deleted");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    //TODO: handle error e
                }
        }

    }
}
