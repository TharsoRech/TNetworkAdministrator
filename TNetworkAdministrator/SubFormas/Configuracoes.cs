using Microsoft.Exchange.WebServices.Data;
using Microsoft.Exchange.WebServices.Autodiscover;
using System;
using System.Linq;



namespace TNetworkAdministrator.SubFormas
{
    public partial class Configuracoes : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void Configuracoes_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
