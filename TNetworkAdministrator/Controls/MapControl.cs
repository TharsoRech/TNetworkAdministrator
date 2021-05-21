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
    public partial class MapControl : UserControl
    {
        public bool online { get; set; }
        public MapControl()
        {
            InitializeComponent();
        }

        private void StatusText_Click(object sender, EventArgs e)
        {

        }

        private void Online_CheckedChanged(object sender, EventArgs e)
        {
            if(Online.Checked == true)
            {
                Status(true);
            }
            else
            {
                Status(false);
            }
        }

        public void Status(bool st)
        {
            try
            {
                online = st; 
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
