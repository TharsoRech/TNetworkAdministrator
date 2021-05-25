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
    public partial class DeviceControl : UserControl
    {
        public DeviceControl(String statusText,Classes.Status status)

        {
            InitializeComponent();
            StatusText.Text = statusText;
            if(status == Classes.Status.Good) 
            {
                Backbackground.Inactive1= Color.DarkGreen;
                return;
            }
            if (status == Classes.Status.Slow)
            {
                Backbackground.Inactive1 = Color.Goldenrod;
              Image1.Image = imageList1.Images[1];

                return;
            }
            if (status == Classes.Status.Unreacheable)
            {
                Backbackground.Inactive1 = Color.DarkRed;
               Image1.Image = imageList1.Images[2];
                return;
            }
            if (status == Classes.Status.NotTested)
            {
                Backbackground.Inactive1 = Color.Gray;
                Image1.Image = imageList1.Images[3];
                return;
            }

        }

        private void Image1_Click(object sender, EventArgs e)
        {

        }
    }
}
