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
                string resultado = ShowDialog("Ip", "Coloque o valor");
                if (resultado != "")
                {
                    Scaneados.Nodes.Add(resultado);
                }
            }

            catch (Exception ex)
            {

            }
           
        }


        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
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
