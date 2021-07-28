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
using System.Net;
using System.IO;

namespace TNetworkAdministrator.Controls
{
    public partial class DeviceScan : UserControl
    {

        private bool Checked { get; set; }
        public int TypeDevice { get; set; }

        public int StatusDevice { get; set; }


        public bool check()
        {

            return Checked;
        }
        public bool check(bool ch)
        {
            checkBox1.Checked = ch;
            Checked = ch;
            return checkBox1.Checked;
        }

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
                if (pc != "" && pc != "Null")
                {
                    this.Invoke(new MethodInvoker(delegate { DeviceText.Text = "Computador:" + pc; }));
                    this.Invoke(new MethodInvoker(delegate { DeviceImage.Image = Form1.instance.GetImage(1); }));
                    this.Invoke(new MethodInvoker(delegate { Status.Text = "Status:Coletado com sucesso"; }));
                    TypeDevice =  1;
                    StatusDevice = 1;
                    return;
                }
                string Printer1 = CheckifisPrinter(ip1);
                if (Printer1 != ""  && Printer1 != "Null")
                {   
                    
                    this.Invoke(new MethodInvoker(delegate { DeviceText.Text = "Impressora:" + Printer1; }));
                    this.Invoke(new MethodInvoker(delegate { DeviceImage.Image = Form1.instance.GetImage(2); }));
                    this.Invoke(new MethodInvoker(delegate { Status.Text = "Status:Coletado com sucesso"; }));
                    TypeDevice = 2;
                    StatusDevice = 1;
                    return;
                }
                //  string Switch1 = CheckifisSwitch(ip1);
                 string Switch1 = CheckifisSwitch(ip1);
                if (Switch1 != "" && Switch1 != "Null")
                {

                    this.Invoke(new MethodInvoker(delegate { DeviceText.Text = "Switch:" + Switch1; }));
                    this.Invoke(new MethodInvoker(delegate { DeviceImage.Image = Form1.instance.GetImage(3); ; }));
                    this.Invoke(new MethodInvoker(delegate { Status.Text = "Status:Coletado com sucesso"; }));
                    TypeDevice = 3;
                    StatusDevice = 1;
                    return;
                }
 
                if (CheckifIscameraIP("http://" + ip1 + "/") == true)
                {
                    this.Invoke(new MethodInvoker(delegate { DeviceText.Text = "Camera:" + ip1; }));
                    this.Invoke(new MethodInvoker(delegate { DeviceImage.Image = Form1.instance.GetImage(4); ; }));
                    this.Invoke(new MethodInvoker(delegate { Status.Text = "Status:Coletado com sucesso"; }));
                    TypeDevice = 4;
                    StatusDevice = 1;
                    return;
                }
                this.Invoke(new MethodInvoker(delegate { Status.Text = "Status:Dispositivo desconhecido"; }));
                this.Invoke(new MethodInvoker(delegate { Application.DoEvents(); }));
                TypeDevice = 5;
                StatusDevice = 4;
                return;
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
                requestOid = new string[] { ".1.3.6.1.2.1.25.3.2.1.3.1" };
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
                else
                {
                    return pc1;
                }



                return pc1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return pc1;

            }

        }

        public string CheckifisSwitch(string ip)
        {
            string pc1 = "";
            try
            {

                pc1 = GetSystemName(ip);
                return pc1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return pc1;

            }


        }

        public string GetSystemName(string ip)
        {
            string pc1 = "";
            try
            {
                String snmpAgent = ip;
                String snmpCommunity = "public";
                SimpleSnmp snmp = new SimpleSnmp(snmpAgent, snmpCommunity);
                Dictionary<Oid, AsnType> result = snmp.Walk(SnmpVersion.Ver2, "1.3.6.1.2.1.1.5");
                if (result == null)
                {
                    pc1 = "";
                }
                else
                {
                    foreach (KeyValuePair<Oid, AsnType> entry in result)
                    {

                        pc1 = pc1 + entry.Value.ToString();
                    }

                }
                return pc1;
            }
            catch (Exception ex)
            {
                pc1 = ex.Message + ex.StackTrace;
                return pc1;

            }



        }
        public string GetDescription(string ip)
        {
            string pc1 = "";
            try
            {
                String snmpAgent = ip;
                String snmpCommunity = "public";
                SimpleSnmp snmp = new SimpleSnmp(snmpAgent, snmpCommunity);
                Dictionary<Oid, AsnType> result = snmp.Walk(SnmpVersion.Ver2, "1.3.6.1.2.1.1.1");
                if (result == null)
                {
                    pc1 = "";
                }
                else
                {
                    foreach (KeyValuePair<Oid, AsnType> entry in result)
                    {

                        pc1 = pc1 + entry.Value.ToString();
                    }

                }
                return pc1;
            }
            catch (Exception ex)
            {
                pc1 = ex.Message + ex.StackTrace;
                return pc1;

            }
        }
        public bool CheckifIscameraIP(string IP)
        {
            {
                string urlAddress = IP;
                bool iscamera = false;
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Stream receiveStream = response.GetResponseStream();
                        StreamReader readStream = null;

                        if (String.IsNullOrWhiteSpace(response.CharacterSet))
                            readStream = new StreamReader(receiveStream);
                        else
                            readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                        string data = readStream.ReadToEnd();

                        response.Close();
                        readStream.Close();
                        if (data.Contains("Channel"))
                        {
                            iscamera = true;
                        }

                    }
                    return iscamera;
                }
                catch (Exception )
                {

                    return iscamera;

                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Parent.Controls.Remove(this);
            }
            catch (Exception)
            {

                
            }
        }
    }

    }
    
