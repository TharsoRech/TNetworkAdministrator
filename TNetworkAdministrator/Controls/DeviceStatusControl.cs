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
    public partial class DeviceStatusControl : UserControl
    {
        public DeviceStatusControl(string ip,string devicename,string status)
        {
            InitializeComponent();
            Ip.Text = ip;
            SystemName.Text = devicename;
            Status.Text = status;
        }

        public DeviceStatusControl(string ip, string devicename, int value)
        {
            InitializeComponent();
            Ip.Text = ip;
            SystemName.Text = devicename;
            Controls.Remove(Status);
            Wisder.W3Common.WMetroControl.Controls.MetroProgressBar p = new Wisder.W3Common.WMetroControl.Controls.MetroProgressBar();
            p.Value = value;
            p.Dock = DockStyle.Left;
            p.Style = Wisder.W3Common.WMetroControl.MetroColorStyle.Green;
            Controls.Add(p);
            Controls.SetChildIndex(p, 0);
            
        }

    }
}
