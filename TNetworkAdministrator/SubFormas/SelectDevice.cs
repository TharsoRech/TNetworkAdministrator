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
    public partial class SelectDevice : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {

        public TabPage Tb { get; set; }
        public SelectDevice(TabPage tb)
        {
            InitializeComponent();
            Tb = tb;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Controls.MapControl p = new Controls.MapControl();
                p.Description.Text = DeviceBox.Text;
                Tb.Controls.Add(p);
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SubFormas.DeviceEdit p = new SubFormas.DeviceEdit();
                p.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
