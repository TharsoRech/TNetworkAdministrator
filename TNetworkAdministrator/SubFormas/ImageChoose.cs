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
    public partial class ImageChoose : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public DeviceEdit DEdit;
        public ImageChoose()
        {
            InitializeComponent();
        }

        private void ImageChoose_Load(object sender, EventArgs e)
        {
            try
            {
               if (DeviceCheck.Checked == true)
                {
                    DEdit.ImageIndex = 0;
                }
                if (ServerCheck.Checked == true)
                {
                    DEdit.ImageIndex = 1;
                }
                if (ComputerCheck.Checked == true)
                {
                    DEdit.ImageIndex = 2;
                }
                if (PrinterCheck.Checked == true)
                {
                    DEdit.ImageIndex = 3;
                }
                if (WifiCheck.Checked == true)
                {
                    DEdit.ImageIndex = 4;
                }
                if (SwitchCheck.Checked == true)
                {
                    DEdit.ImageIndex = 5;
                }
                if (LinkCheck.Checked == true)
                {
                    DEdit.ImageIndex = 6;
                }
                this.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
