using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNetworkAdministrator.Controls
{
    public partial class ConfigutacoesControl : UserControl
    {
        public ConfigutacoesControl()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        public bool login()
        {
            bool ok = false;
            try
            {
                string user = Email.Text;
                string pass = Password.Text;
                string server = Server.Text;
                ExchangeService service = new ExchangeService();
                service.Credentials = new WebCredentials(user, pass, Environment.UserDomainName);
                service.Url = new Uri(("https://"
                                + (server + "/ews/Exchange.asmx")));
                Folder rootfolder = Folder.Bind(service, WellKnownFolderName.MsgFolderRoot);
                rootfolder.Load();
                if (rootfolder.FindFolders(new FolderView(100)) is null == false)
                {
                    return ok;
                }
                ok = true;
                return ok;
            }
            catch (Exception)
            {
                return ok;
            }

        }



    }
}
