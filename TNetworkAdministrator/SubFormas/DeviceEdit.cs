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
    public partial class DeviceEdit : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public DeviceEdit()
        {
            InitializeComponent();
        }

        private void DeviceEdit_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ImageChoose imp = new ImageChoose();
                imp.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(metroCheckBox1.Checked == true)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
