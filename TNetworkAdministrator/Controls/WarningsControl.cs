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
    public partial class WarningsControl : UserControl
    {
        public WarningsControl()
        {
            InitializeComponent();
        }

        private void enviarEmailDeAlertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado = Classes.InputBox.ShowDialog("Email", "Envie um alerta");
                if (resultado != "")
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
