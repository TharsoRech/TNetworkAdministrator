using MetroFramework;
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
    public partial class Map : Wisder.W3Common.WMetroControl.Forms.MetroForm
    {
        public Map()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(MapTabControl.TabPages.Count > 0)
                {
                    SubFormas.SelectDevice p = new SelectDevice(MapTabControl.SelectedTab);
                        p.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "Primeiro Adicione uma localização", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                TabPage newp = new TabPage();
                newp.BackColor = Color.White;
                newp.Text = Classes.InputBox.ShowDialog("Digite o nome", "Digite o nome da localização,Adm,Engenharia...");
                MapTabControl.TabPages.Add(newp);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (MapTabControl.TabPages.Count > 0)
                {
                    TNetworkAdministrator.Controls.ResizableController p = new Controls.ResizableController();
                    MapTabControl.SelectedTab.Controls.Add(p);
                }
                else
                {
                    MetroMessageBox.Show(this, "Primeiro Adicione uma localização", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
