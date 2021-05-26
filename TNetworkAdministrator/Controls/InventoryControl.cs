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
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Controls.Device dev1 = new Controls.Device();
                ListofDevices.Controls.Add(dev1);
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
                SubFormas.GroupEdit newp = new GroupEdit();
                newp.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

     
    }
}
