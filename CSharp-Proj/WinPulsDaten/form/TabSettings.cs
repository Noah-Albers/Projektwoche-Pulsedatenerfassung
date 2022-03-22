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

                try
                {
                    await this.DB.InsertAsync(DBQuerys.truncate_PulsdateAndPerson);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    //TODO: handle error e
                }


                
            else
                Console.WriteLine("Todo");
            //todo

        }

    }
}
