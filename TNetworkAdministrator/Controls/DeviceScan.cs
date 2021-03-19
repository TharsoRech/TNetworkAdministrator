using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using SnmpSharpNet;

namespace TNetworkAdministrator.Controls
{
    public partial class DeviceScan : UserControl
    {
        public DeviceScan()
        {
            InitializeComponent();
            this.Load += (senderr, eer) => { RunWorker(); };
        }



        private void RunWorker()
        {
            this.ScanDeviceWork.DoWork += (senderr, eer) => { CollectInfo(); };
            ScanDeviceWork.RunWorkerAsync();
        }

        public void CollectInfo()
        {
            try
            {
                string ip1 = "";
                this.Invoke(new MethodInvoker(delegate { ip1 = Ip.Text; }));
                this.Invoke(new MethodInvoker(delegate { Status.Text = "Status:Coletando Informações..."; }));
                this.Invoke(new MethodInvoker(delegate { Application.DoEvents(); }));
                string pc = CheckifisComputer(ip1);
                if (pc != "")
                {
                    this.Invoke(new MethodInvoker(delegate { DeviceText.Text = "Computador:" + pc; }));
                    this.Invoke(new MethodInvoker(delegate { DeviceImage.BackgroundImage = this.imageList1.Images[1]; }));
                    this.Invoke(new MethodInvoker(delegate { Status.Text = "Status:Coletado com sucesso"; }));
                    return;
                }
                string Printer1 = CheckifisPrinter(ip1);
                if (Printer1 != "")
                {
                    this.Invoke(new MethodInvoker(delegate { DeviceText.Text = "Impressora:" + Printer1; }));
                    this.Invoke(new MethodInvoker(delegate { DeviceImage.BackgroundImage = this.imageList1.Images[2]; }));
                    this.Invoke(new MethodInvoker(delegate { Status.Text = "Status:Coletado com sucesso"; }));
                    return;
                }
                this.Invoke(new MethodInvoker(delegate { Status.Text = "Status:Dispositivo desconhecido"; }));
                this.Invoke(new MethodInvoker(delegate { Application.DoEvents(); }));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubFormas.DeviceEdit newp = new SubFormas.DeviceEdit();
            newp.SaveButton.Text = "Atualizar";
            newp.Show();
        }

        public string CheckifisComputer(string ip)
        {
            string pc1 = "";
            try
            {
                ManagementObjectSearcher theSearcher = new ManagementObjectSearcher("\\\\" + ip + "\\root\\CIMv2", "SELECT Name FROM Win32_ComputerSystem");

                foreach (ManagementObject theCurrentResult in theSearcher.Get())

                {
                    pc1 = theCurrentResult["Name"].ToString();
                    return pc1;

                }

                return pc1;
            }
            catch (Exception)
            {

                return pc1;

            }
        }
        public string CheckifisPrinter(string ip)
        {
            string pc1 = "";
            try
            {
                string community = "public";
                string[] requestOid;
                Dictionary<Oid, AsnType> result;
                requestOid = new string[] {".1.3.6.1.2.1.25.3.2.1.3.1"};
                SimpleSnmp snmp = new SimpleSnmp(ip, community);
                if (!snmp.Valid)
                {

                    return pc1;
                }
                result = snmp.Get(SnmpVersion.Ver2, requestOid);
                if (result != null)
                   
              {
                    foreach (KeyValuePair<Oid, AsnType> kvp in result)
                        pc1 = kvp.Value.ToString();
                }
      

                return pc1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return pc1;

            }

        }

    }
}
