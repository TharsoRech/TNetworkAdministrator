using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TNetworkAdministrator.Controls
{
    public partial class Device : UserControl
    {
        public Device()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubFormas.DeviceEdit newp = new SubFormas.DeviceEdit();
            newp.SaveButton.Text = "Atualizar";
            newp.Show();
            
           
        }
    }
}
