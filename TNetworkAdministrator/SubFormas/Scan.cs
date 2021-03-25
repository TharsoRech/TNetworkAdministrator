using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TNetworkAdministrator.SubFormas
{
    public partial class Scan : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public  Scan()
        {
            InitializeComponent();
        }

        private void Scan_Load(object sender, EventArgs e)
        {

        }

    

   
        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
               
                SubFormas.DeviceEdit newp = new SubFormas.DeviceEdit();
                newp.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
           
        }


  

        private void metroButton2_Click(object sender, EventArgs e)
        {

            this.ScanWorker.DoWork += (senderr,eer) => { searchingips(); };
            ScanWorker.RunWorkerAsync();
        }

        public bool Pinghost(string host)
        {
            bool ping1 = false;
            try
            {
                System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
                System.Net.NetworkInformation.PingReply rep = p.Send(host);
                if (rep.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    ping1 = true;
                        return ping1;
                }
                return ping1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ping1;
            }
        }

        private void SearchForGateway_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(SearchForGateway.Checked == true)
                {
                    SearchForIP.Checked = false;
                    Gateway.Enabled = true;
                    IpInicial.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string Before(string value, string a)
        {
            int posA = value.IndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            return value.Substring(0, posA);
        }
        private void SearchForIP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (SearchForIP.Checked == true)
                {
                    SearchForGateway.Checked = false;
                    IpInicial.Enabled = true;
                    Gateway.Enabled = false;
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  void searchingips()
        {
            try
            {
                if (Gateway.Text == "" && SearchForGateway.Checked==true)
                {
                    MessageBox.Show("Está faltado informação de Gateway,favor digitar");
                    return;
                }
                if (IpInicial.Text == "" && SearchForIP.Checked == true)
                {
                    MessageBox.Show("Está faltado informaçãode IP ,favor digitar");
                    return;
                }
                string ping_var = "";
                string First = "";
                string Second = "";
                string Thirt = "";
                string value = "";
                if (SearchForGateway.Checked == true)
                {
                    value = Gateway.Text.ToString();
                }
                if (SearchForIP.Checked == true)
                {
                    value = IpInicial.Text.ToString();
                }
                int maxindex = 0;
                string value2 = "";
                int k = 0;
                while (k < value.Length)
                {
                    if (value[k].ToString() == ".")
                    {
                        maxindex += 1;
                        if (maxindex == 1 || First == "")
                        {
                            First = value2;
                            value2 = "";
                        }
                        if (maxindex == 2 || Second == "")
                        {
                            Second = value2;
                            value2 = "";
                        }
                        if (maxindex == 3 || Thirt == "" )
                        {
                            Thirt = value2;
                            value2 = "";
                        }
                    }
                    else
                    {
                        value2 = value2 + value[k].ToString();

                    }

                    k++;
                }
                this.Invoke(new MethodInvoker(delegate { Status.Visible=true; }));
                this.Invoke(new MethodInvoker(delegate { Status.Text = "Scaneando..."; }));
                
                if (SearchForGateway.Checked == true)

                {

                    this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Value = 0; }));
                    this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Maximum = 253; }));


                
                       
                    for (int i = 2; i <= 255; i++)
                    {
                    if(ScanWorker.CancellationPending == true)
                        {
                           
                            this.Invoke(new MethodInvoker(delegate { Status.Text = "Scaneamento cancelado"; }));
                            this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Value = 0; }));
                            return;
                        }
                        this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Value += 1; }));
                        ping_var = First + "." + Second + "." + Thirt + "." + i;
                        this.Invoke(new MethodInvoker(delegate { Status.Text = "Scaneando IP:"+ ping_var; }));
                        if (Pinghost(ping_var) == true)
                         {
                            Controls.DeviceScan newc = new Controls.DeviceScan();
                            newc.Ip.Text = ping_var;
                        this.Invoke(new MethodInvoker(delegate { Scaneados.Controls.Add(newc); }));
                        this.Invoke(new MethodInvoker(delegate { Application.DoEvents(); }));

                         }
                    }
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Value = 0; }));
                    this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Maximum = 64009; }));
                    for (int i = 2; i <= 255; i++)
                    {
                        if (ScanWorker.CancellationPending == true)
                        {

                            this.Invoke(new MethodInvoker(delegate { Status.Text = "Scaneamento cancelado"; }));
                            this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Value = 0; }));
                            return;
                        }
                        for (int j = 2; j <= 255; j++)
                        {
                            if (ScanWorker.CancellationPending == true)
                            {

                                this.Invoke(new MethodInvoker(delegate { Status.Text = "Scaneamento cancelado"; }));
                                this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Value = 0; }));
                                return;
                            }
                            this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Value += 1; }));
                            ping_var = First + "." + Second + "." + i + "." + j;
                            this.Invoke(new MethodInvoker(delegate { Status.Text = "Scaneando IP:" + ping_var; }));
                            if (Pinghost(ping_var) == true)
                             {
                                Controls.DeviceScan newc = new Controls.DeviceScan();
                            newc.Ip.Text = ping_var;
                                this.Invoke(new MethodInvoker(delegate { Scaneados.Controls.Add(newc); }));
                                this.Invoke(new MethodInvoker(delegate { Application.DoEvents(); }));
                          
                               
                            }
                        }
                    }
                }
                this.Invoke(new MethodInvoker(delegate { Status.Text = "Scanemento concluido"; }));
            }
         
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            try
            {
                Status.Text = "Cancelando...";
                ScanWorker.CancelAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
               // MessageBox.Show(CheckifisSwitchHP("192.168.1.239"));
                MessageBox.Show(CheckifisSwitchHP("192.168.1.247"));


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public string CheckifisSwitchHP(string ip)
        {
            string pc1 = "";
            try
            {
                String snmpAgent = ip;
                String snmpCommunity = "public";
                SimpleSnmp snmp = new SimpleSnmp(snmpAgent, snmpCommunity);
                Dictionary<Oid, AsnType> result = snmp.Walk(SnmpVersion.Ver2, ".1.3.6.1.4.1.11.2.14.11.15.2.6.1.1.1.1.6");
                if (result == null)
                {
                    pc1 =   "Request failed.";
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


    }
}
