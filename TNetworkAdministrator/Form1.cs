using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TNetworkAdministrator
{
    public partial class Form1 : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.ribbonexit.Click += (sender, e) => { this.Close(); };
            this.Alertas.Click += (sender, e) => { SubFormas.Warnings p = new SubFormas.Warnings(); p.Show(); };
            this.Relatorios.Click += (sender, e) => { SubFormas.Reports p = new SubFormas.Reports(); p.Show(); };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        public void Inventario_Click(object sender, EventArgs e)
        {
            SubFormas.Inventory newp = new SubFormas.Inventory();
            newp.Show();

        }

        public void Scanner_Click(object sender, EventArgs e)
        {
            SubFormas.Scan newp = new SubFormas.Scan();
            newp.Show();

        }
    }
}
