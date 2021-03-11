using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TNetworkAdministrator.SubFormas
{
    public partial class Inventory : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            for(int i =0;i<10;i++  )
            {
                Controls.Device dev1 = new Controls.Device();
                ListofDevices.Controls.Add(dev1);
            }
        }
    }
}
