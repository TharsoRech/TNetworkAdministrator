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
    public partial class ResizableController : UserControl
    {
        private Point MouseDownLocation;
        public ResizableController()
        {
            InitializeComponent();
            this.MouseDown += (sender, e) => { MapControl_MouseDown(sender, e); };
            this.MouseMove += (sender, e) => { MapControl_MouseMove(sender, e); };
            altoButton1.MouseDown += (sender, e) => { MapControl_MouseDown(sender, e); };
            altoButton1.MouseMove += (sender, e) => { MapControl_MouseMove(sender, e); };
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
