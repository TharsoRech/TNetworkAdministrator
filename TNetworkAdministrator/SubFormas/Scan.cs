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
    public partial class Scan : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public Scan()
        {
            InitializeComponent();
        }

        private void Scan_Load(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Scaneados.Nodes.Clear();
            }
            catch (Exception ex)
            {
              

            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
               foreach (TreeNode tr in Scaneados.Nodes)
                {
                    if (tr.Checked == true)
                    {
                        Scaneados.Nodes.Remove(tr);
                    }
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado = Classes.InputBox.ShowDialog("Ip", "Coloque o valor");
                if (resultado != "")
                {
                    Scaneados.Nodes.Add(resultado);
                }
            }

            catch (Exception ex)
            {

            }
           
        }


  

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(TreeNode tr in Scaneados.Nodes)
                {
                    if (tr.Checked = true) {
                        
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
