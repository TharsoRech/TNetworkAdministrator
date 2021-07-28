using MetroFramework;
using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TNetworkAdministrator.Controls
{
    public partial class ScanControl : UserControl
    {
        public ScanControl()
        {
            InitializeComponent();
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

            this.ScanWorker.DoWork += (senderr, eer) => { searchingips(); };
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
            catch (Exception)
            {
                // MessageBox.Show(ex.Message);
                return ping1;
            }
        }

        private void SearchForGateway_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (SearchForGateway.Checked == true)
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

        public void searchingips()
        {
            try
            {
                if (Gateway.Text == "" && SearchForGateway.Checked == true)
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
                        if (maxindex == 3 || Thirt == "")
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
                this.Invoke(new MethodInvoker(delegate { Status.Visible = true; }));
                this.Invoke(new MethodInvoker(delegate { Status.Text = "Scaneando..."; }));

                if (SearchForGateway.Checked == true)

                {

                    this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Value = 0; }));
                    this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Maximum = 253; }));




                    for (int i = 2; i <= 255; i++)
                    {
                        if (ScanWorker.CancellationPending == true)
                        {

                            this.Invoke(new MethodInvoker(delegate { Status.Text = "Scaneamento cancelado"; }));
                            this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Value = 0; }));
                            return;
                        }
                        this.Invoke(new MethodInvoker(delegate { metroProgressBar1.Value += 1; }));
                        ping_var = First + "." + Second + "." + Thirt + "." + i;
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

            catch (Exception )
            {

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

        public void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
               
                foreach (TNetworkAdministrator.Controls.DeviceScan n1 in Scaneados.Controls)
                {
                    if (n1.check() == true)
                    {
                        Form1.addnew("Device", new List<string>() { "Name", "Ip", "status", "Type","AddIn" }, new List<object>() { n1.DeviceText.Text, n1.Ip.Text, n1.StatusDevice, n1.TypeDevice,DateTime.Now });
                        MetroMessageBox.Show(TNetworkAdministrator.Form1.ActiveForm, "Item(s) adicionado com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
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
                Dictionary<Oid, AsnType> result = snmp.Walk(SnmpVersion.Ver2, ".1.3.6.1.2.1");
                if (result == null)
                {
                    pc1 = "Request failed.";
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TNetworkAdministrator.Controls.DeviceScan n1 in Scaneados.Controls)
                {
                    if (n1.check() == true)
                    {
                        n1.check(false);
                    }
                    else
                    {
                        n1.check(true);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
