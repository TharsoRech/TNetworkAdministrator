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
        public ImageChoose()
        {
            InitializeComponent();
        }

        private void ImageChoose_Load(object sender, EventArgs e)
        {
            try
            {
                DeviceCheck.BackgroundImage = imageList1.Images[0];
 
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
