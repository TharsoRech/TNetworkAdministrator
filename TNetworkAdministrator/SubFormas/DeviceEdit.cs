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
        public string Id { get; set; }
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
                if(metroButton1.Text == "Salvar")
                {
                    //Form1.addnewDevice()
                }
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
            
                if (UseDefaultGroup.Checked == true)
                {
                    StatusCheck.Enabled = false;
                    LostPackageCheck.Enabled = false;
                    NetworkUseCheckl.Enabled = false;
                    ProcessorUseCheck.Enabled = false;
                    CheckEvery.Enabled = false;
                    TimeON.Enabled = false;
                    TimeOff.Enabled = false;
                    Sunday.Enabled = false;
                    Monday.Enabled = false;
                    Tuesday.Enabled = false;
                    Wednesday.Enabled = false;
                    Thursday.Enabled = false;
                    Fryday.Enabled = false;
                    Saturday.Enabled = false;
                    GroupsChoose.Enabled = false;
                }
                else
                {
                    StatusCheck.Enabled = true;
                    LostPackageCheck.Enabled = true;
                    NetworkUseCheckl.Enabled = true;
                    ProcessorUseCheck.Enabled = true;
                    CheckEvery.Enabled = true;
                    TimeON.Enabled = true;
                    TimeOff.Enabled = true;
                    Sunday.Enabled = true;
                    Monday.Enabled = true;
                    Tuesday.Enabled = true;
                    Wednesday.Enabled = true;
                    Thursday.Enabled = true;
                    Fryday.Enabled = true;
                    Saturday.Enabled = true;
                    GroupsChoose.Enabled = true;
                }
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
                SubFormas.GroupEdit newp = new GroupEdit();
                newp.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SubFormas.GroupEdit newp = new GroupEdit();
                newp.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GroupsChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(GroupsChoose.Text != "")
                {
                    UseDefaultGroup.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
