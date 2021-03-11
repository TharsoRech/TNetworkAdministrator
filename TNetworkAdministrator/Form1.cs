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
            this.Inventario.Click += (sender, e) => { ShowForm(new SubFormas.Inventory()); };
            this.ribboninventario.Click += (sender, e) => { ShowForm(new SubFormas.Inventory()); };
            this.Scannear.Click += (sender, e) => { ShowForm(new SubFormas.Scan()); };
            this.ribbonscan.Click += (sender, e) => { ShowForm(new SubFormas.Scan()); };
            this.Alertas.Click += (sender, e) => { ShowForm(new SubFormas.Warnings()); };
            this.Relatorios.Click += (sender, e) => { ShowForm(new SubFormas.Reports()); };
            this.Configuracoes.Click += (sender, e) => { ShowForm(new SubFormas.Configuracoes()); };
            this.ribbonconfig.Click += (sender, e) => { ShowForm(new SubFormas.Configuracoes()); };
            this.ribbonexit.Click += (sender, e) => { this.Close(); };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void ShowForm(object e)
        {
            try { 

             var newp = Activator.CreateInstance(e.GetType());
             Wisder.W3Common.WMetroControl.Forms.MetroForm newp2 = (Wisder.W3Common.WMetroControl.Forms.MetroForm) newp;
                newp2.Show();

            }
            catch (Exception)
            {

              
            }
      
        }

     
    }
}
