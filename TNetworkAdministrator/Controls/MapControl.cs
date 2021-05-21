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
        private Point MouseDownLocation;
        public MapControl()
        {
            InitializeComponent();
            this.MouseDown += (sender, e) => { MapControl_MouseDown(sender,e); };
            this.MouseMove += (sender, e) => { MapControl_MouseMove(sender, e); };
            DeviceImage.MouseDown += (sender, e) => { MapControl_MouseDown(sender, e); };
            DeviceImage.MouseMove += (sender, e) => { MapControl_MouseMove(sender, e); };
            Description.MouseDown += (sender, e) => { MapControl_MouseDown(sender, e); };
            Description.MouseMove += (sender, e) => { MapControl_MouseMove(sender, e); };
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


        private void MapControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void MapControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

    }
}
