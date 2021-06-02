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
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                TNetworkAdministrator.Controls.InicioControl ic = new Controls.InicioControl();
                //   ChartStatus.Series[0].Points[0].SetValueXY(100, 1);
                //  ChartStatus.Series[0].Points[1].SetValueXY(10, 5);
                //   ChartStatus.Series[0].Points[1].SetValueXY(10, 3);
                //   ChartStatus.Series[0].Points[1].SetValueXY(10,2);
                for (int i = 1; i <= 20; i++)
                {


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
                    ic.PingList.Controls.Add(p1);
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
                    ic.LastOnline.Controls.Add(p2);
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
                   ic.CpuList.Controls.Add(p3);


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
                    ic.DiskList.Controls.Add(p4);
                    
                }
                TNetworkAdministrator.Controls.DeviceControl p5= new Controls.DeviceControl("172.16.1.1", Classes.Status.Good);
                TNetworkAdministrator.Controls.DeviceControl p7 = new Controls.DeviceControl("172.16.1.1", Classes.Status.Slow);
                TNetworkAdministrator.Controls.DeviceControl p8 = new Controls.DeviceControl("172.16.1.1", Classes.Status.Unreacheable);
                TNetworkAdministrator.Controls.DeviceControl p9 = new Controls.DeviceControl("172.16.1.1", Classes.Status.NotTested);
                ic.ConectivityStatus.Controls.Add(p5);
                ic.ConectivityStatus.Controls.Add(p7);
                ic.ConectivityStatus.Controls.Add(p8);
                ic.ConectivityStatus.Controls.Add(p9);
                ic.Dock = DockStyle.Fill;
                PanelVisualizer.Controls.Add(ic);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        public void ShowControl(object e)
        {
            try { 

             var newp = Activator.CreateInstance(e.GetType());
             UserControl newp2 = (UserControl) newp;
                newp2.Dock = DockStyle.Fill;
                PanelVisualizer.Controls.Add(newp2);

            }
            catch (Exception)
            {

              
            }
      
        }

        public Image GetImage(int n)
        {
            try
            {
                
                return ListImage.Images[n];
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void altoButton16_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void altoButton4_Click(object sender, EventArgs e)
        {
            try
            {
                PanelVisualizer.Controls.Clear();

                ShowControl(new TNetworkAdministrator.Controls.InventoryControl());

            }
            catch (Exception)
            {

                throw;
            }
        }

      
        private void altoButton2_Click(object sender, EventArgs e)
        {
            PanelVisualizer.Controls.Clear();

            ShowControl(new TNetworkAdministrator.Controls.InicioControl());
        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            PanelVisualizer.Controls.Clear();

            ShowControl(new TNetworkAdministrator.Controls.InventoryControl());
        }

        private void altoButton5_Click(object sender, EventArgs e)
        {
            PanelVisualizer.Controls.Clear();

            ShowControl(new TNetworkAdministrator.Controls.ScanControl());
        }

        private void altoButton7_Click(object sender, EventArgs e)
        {
            PanelVisualizer.Controls.Clear();

            ShowControl(new TNetworkAdministrator.Controls.ControlMap());
        }

        private void altoButton9_Click(object sender, EventArgs e)
        {
            PanelVisualizer.Controls.Clear();

            ShowControl(new TNetworkAdministrator.Controls.ReportsControl());
        }

        private void altoButton11_Click(object sender, EventArgs e)
        {
            PanelVisualizer.Controls.Clear();

            ShowControl(new TNetworkAdministrator.Controls.WarningsControl());
        }

        private void altoButton13_Click(object sender, EventArgs e)
        {
            PanelVisualizer.Controls.Clear();

            ShowControl(new TNetworkAdministrator.Controls.ConfigControl());
        }

        private void altoButton6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
