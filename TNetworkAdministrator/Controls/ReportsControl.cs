using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNetworkAdministrator.SubFormas;

namespace TNetworkAdministrator.Controls
{
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SubFormas.Report rp = new Report();
                rp.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
