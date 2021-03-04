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
    public partial class Configuracoes : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void Configuracoes_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
