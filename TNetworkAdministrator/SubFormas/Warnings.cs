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
    public partial class Warnings : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public Warnings()
        {
            InitializeComponent();
        }

        private void Warnings_Load(object sender, EventArgs e)
        {

        }

        private void enviarEmailDeAlertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado = Classes.InputBox.ShowDialog("Email", "Envie um alerta");
               if(resultado != "")
                {

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
          
            }

            catch (Exception ex)
            {

            }
        }
    }
}
