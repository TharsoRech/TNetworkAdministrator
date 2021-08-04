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
        public int ImageIndex = 0;
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
                int StatusDev = 0;
                int PriorityDev = 0;
                int TypeDev = 0;
                int ImageIndex = 0;
                switch (StatusDevice.Text)
                {
                    case "Bom":
                        StatusDev = 1;
                        break;
                    case "Lento":
                        StatusDev = 2;
                        break;
                    case "Não Acessível":
                        StatusDev = 3;
                        break;
                    case "Não Testado":
                        StatusDev = 4;
                        break;
                }
                switch (PriorityChoose.Text)
                {
                    case "Baixa":
                        PriorityDev = 1;
                        break;
                    case "Média":
                        PriorityDev = 2;
                        break;
                    case "Alta":
                        PriorityDev = 3;
                        break;
                    case "Crítica":
                        PriorityDev = 4;
                        break;
                }
                switch (TypeDevice.Text)
                {
                    case "Computador":
                        TypeDev = 1;
                        break;
                    case "Impressora":
                        TypeDev = 2;
                        break;
                    case "Switch":
                        TypeDev = 3;
                        break;
                    case "Camera":
                        TypeDev = 4;
                        break;
                    case "Desconhecido":
                        TypeDev = 5;
                        break;
                }

                if (metroButton1.Text == "Salvar")
                {
                    Form1.addnew("Monitoring", new List<string>() { "CheckStatus", "LostingPackage", "NetworkingUsingExtreme", "ProcessUsingExtreme" }, new List<object> { Returnzeroone(StatusCheck.Checked), Returnzeroone(LostPackageCheck.Checked), Returnzeroone(NetworkUseCheckl.Checked), Returnzeroone(ProcessorUseCheck.Checked) });
                    Form1.addnew("DaysToCheck", new List<string>() { "Sunday", "Monday", "Tuesday", "wednesday" ,"Thursday","Friday","Saturday"}, new List<object> { Returnzeroone(Sunday.Checked), Returnzeroone(Monday.Checked), Returnzeroone(Tuesday.Checked), Returnzeroone(Wednesday.Checked), Returnzeroone(Thursday.Checked), Returnzeroone(Friday.Checked), Returnzeroone(Saturday.Checked) });
              Form1.addnew("Device",new List<string>() {"Name","Description","Manufacturer","Ip","status","Image","Priority","Group","Type","AddIn","DaysToCheck","CheckEvery","Monitoring" }, new List<object>() { NameText.Text, Description.Text, Manufacturer.Text, Ip.Text, StatusDev, ImageIndex, PriorityDev, GroupsChoose.Text, TypeDev, DateTime.Now, Form1.GetLastId("DaysToCheck").ToString(), CheckEvery.Value, Form1.GetLastId("Monitoring").ToString() });

                }
                else
                {
                  
                }
                this.Close();
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
                imp.DEdit = this;
                imp.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private int Returnzeroone(bool b)
        {
            try
            {
                int value = 0;
                if (b == true)
                {
                    value = 1;
                }
                else
                {
                    value = 0;
                }
                return value;
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

       
        
    }
}
