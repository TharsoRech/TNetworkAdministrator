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
    public partial class Device : UserControl
    {
        public string ID { get; set; }
        public Device()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> values = Form1.GetInfoFrom("Device", new List<string>() { "Id", "Name", "Group","Description","Manufacturer","Ip","Status","Image","Priority","Type","Addin","TimeON","TimeOF","DaysToCheck","CheckEvery" });
            SubFormas.DeviceEdit newp = new SubFormas.DeviceEdit();
            newp.Id = values[0];
            newp.NameText.Text = values[1];
            newp.GroupsChoose.Text = values[2];
            newp.Description.Text = values[3];
            newp.Manufacturer.Text = values[4];
            newp.Ip.Text = values[5];
            newp.Status.Text = values[6];
            newp.ImageText.Text = values[7];
            newp.PriorityChoose.Text = values[8];
            newp.TypeDevice.Text = values[9];
            newp.AddIn.Text = values[10];
            newp.TimeON.Text = values[11];
            newp.TimeOff.Text = values[12];


            newp.CheckEvery.Text = values[14];

            newp.SaveButton.Text = "Atualizar";
            newp.Show();          
           
        }
    }
}
