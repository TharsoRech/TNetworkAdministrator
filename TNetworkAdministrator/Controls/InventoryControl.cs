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
            try
            {
                int count = Form1.GetCount("Device");
                if (count > 0)
                {
                    
                    List<string> values = Form1.GetInfoFrom("Device", new List<string>() { "Id", "Ip", "Name", "Group" });
                    int i = 0;
                 while( i < 4 * count)
                    {
                        Controls.Device dev1 = new Controls.Device();
                        dev1.ID = values[i];
                        i = i + 1;
                        dev1.Ip.Text = values[i];
                        i = i + 1;
                        dev1.DeviceText.Text = values[i];
                        i = i + 1;
                        dev1.Group.Text = values[i];
                        i = i + 1;
                        ListofDevices.Controls.Add(dev1);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

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

                
            }
        }

     
    }
}
