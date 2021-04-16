using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TNetworkAdministrator
{
    public partial class Form1 : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Inventario.Click += (sender, e) => { ShowForm(new SubFormas.Inventory()); };
            this.ribboninventario.Click += (sender, e) => { ShowForm(new SubFormas.Inventory()); };
            this.Scannear.Click += (sender, e) => { ShowForm(new SubFormas.Scan()); };
            this.ribbonscan.Click += (sender, e) => { ShowForm(new SubFormas.Scan()); };
            this.Alertas.Click += (sender, e) => { ShowForm(new SubFormas.Warnings()); };
            this.Relatorios.Click += (sender, e) => { ShowForm(new SubFormas.Reports()); };
            this.Configuracoes.Click += (sender, e) => { ShowForm(new SubFormas.Configuracoes()); };
            this.ribbonconfig.Click += (sender, e) => { ShowForm(new SubFormas.Configuracoes()); };
            this.ribbonexit.Click += (sender, e) => { this.Close(); };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //   ChartStatus.Series[0].Points[0].SetValueXY(100, 1);
                //  ChartStatus.Series[0].Points[1].SetValueXY(10, 5);
                //   ChartStatus.Series[0].Points[1].SetValueXY(10, 3);
                //   ChartStatus.Series[0].Points[1].SetValueXY(10,2);
                for (int i = 1; i <= 20; i++)
                {
                    TNetworkAdministrator.Controls.DeviceStatusControl p = new Controls.DeviceStatusControl();
                    p.Ip.Text = "172.16.1" + i;
                    p.SystemName.Text = "Nome" +  i;
                    if (i == 5)
                    {
                        p.Status.Text = "Offline";
                    }
                    p.Status.Text = "Online";
                    StatusList.Controls.Add(p);
                   // PingList.Controls.Add(p);
                  //  LastOnline.Controls.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        public void ShowForm(object e)
        {
            try { 

             var newp = Activator.CreateInstance(e.GetType());
             Wisder.W3Common.WMetroControl.Forms.MetroForm newp2 = (Wisder.W3Common.WMetroControl.Forms.MetroForm) newp;
                newp2.Show();

            }
            catch (Exception)
            {

              
            }
      
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
