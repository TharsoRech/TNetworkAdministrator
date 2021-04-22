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
                BackColor = Color.DarkGreen;
                return;
            }
            if (status == Classes.Status.Slow)
            {
                BackColor = Color.Goldenrod;
               Image1.Image= imageList1.Images[1];
                return;
            }
            if (status == Classes.Status.Disconnected)
            {
                BackColor = Color.DarkRed;
                Image1.Image = imageList1.Images[2];
                return;
            }
            if (status == Classes.Status.Unreacheable)
            {
                BackColor = Color.IndianRed;
                Image1.Image = imageList1.Images[3];
                return;
            }
            if (status == Classes.Status.NotTested)
            {
                BackColor = Color.Gray;
                Image1.Image = imageList1.Images[4];
                return;
            }

        }

    }
}
