using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;


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
                    TNetworkAdministrator.Controls.DeviceStatusControl p;
                    if (i == 5)
                    {
                      p = new Controls.DeviceStatusControl("172.16.1" + i, "Nome" + i, "Offline");
                    }
                    else
                    {
                      p = new Controls.DeviceStatusControl("172.16.1" + i, "Nome" + i, "Online");
                    }
                    StatusList.Controls.Add(p);

                    //  
                    TNetworkAdministrator.Controls.DeviceStatusControl p1;
                    if (i == 5)
                    {

                        p1 = new Controls.DeviceStatusControl("172.16.1" + i, "Nome" + i, "Offline");
                    }
                    else
                    {
                        p1 = new Controls.DeviceStatusControl("172.16.1" + i, "Nome" + i, "Online");
                    }
                    PingList.Controls.Add(p1);
                    //  
                    TNetworkAdministrator.Controls.DeviceStatusControl p2;
                    if (i == 5)
                    {

                        p2 = new Controls.DeviceStatusControl("172.16.1" + i, "Nome" + i, "Offline");
                    }
                    else
                    {
                        p2 = new Controls.DeviceStatusControl("172.16.1" + i, "Nome" + i, "Online");
                    }
                    LastOnline.Controls.Add(p2);
                    //  

                    TNetworkAdministrator.Controls.DeviceStatusControl p3;
                    if (i == 5)
                    {

                        p3 = new Controls.DeviceStatusControl("172.16.1" + i, "Nome" + i, 50);
                    }
                    else
                    {
                        p3 = new Controls.DeviceStatusControl("172.16.1" + i, "Nome" + i, 100);
                    }
                    CpuList.Controls.Add(p3);


                    //  DiskList.Controls.Add(p4);
                    TNetworkAdministrator.Controls.DeviceStatusControl p4;
                    if (i == 5)
                    {

                        p4 = new Controls.DeviceStatusControl("172.16.1" + i, "Nome" + i, 50);
                    }
                    else
                    {
                        p4 = new Controls.DeviceStatusControl("172.16.1" + i, "Nome" + i, 100);
                    }
                    DiskList.Controls.Add(p4);
                    
                }
                TNetworkAdministrator.Controls.DeviceControl p5= new Controls.DeviceControl("172.16.1.1", Classes.Status.Good);
                TNetworkAdministrator.Controls.DeviceControl p7 = new Controls.DeviceControl("172.16.1.1", Classes.Status.Slow);
                TNetworkAdministrator.Controls.DeviceControl p8 = new Controls.DeviceControl("172.16.1.1", Classes.Status.Unreacheable);
                TNetworkAdministrator.Controls.DeviceControl p9 = new Controls.DeviceControl("172.16.1.1", Classes.Status.NotTested);
                ConectivityStatus.Controls.Add(p5);
                ConectivityStatus.Controls.Add(p7);
                ConectivityStatus.Controls.Add(p8);
                ConectivityStatus.Controls.Add(p9);
              //  ChartStatus.Series[0].Points[0].SetValueXY(200, 70);
             // ChartStatus.Series[0].Points[1].SetValueXY(200, 50);
           //  ChartStatus.Series[0].Points[2].SetValueXY(200, 35);
             // ChartStatus.Series[0].Points[3].SetValueXY(200, 35);


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
