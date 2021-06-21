using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNetworkAdministrator.SubFormas;

namespace TNetworkAdministrator.Controls
{
    public partial class ControlMap : UserControl
    {
        public ControlMap()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MapTabControl.TabPages.Count > 0)
                {
                    SubFormas.SelectDevice p = new SelectDevice(MapTabControl.SelectedTab);
                    p.Show();
                }
                else
                {
                    MetroMessageBox.Show(TNetworkAdministrator.Form1.ActiveForm, "Primeiro Adicione uma localização", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                newp.BackColor = Color.Transparent;
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
                    AltoControls.AltoButton p = new AltoControls.AltoButton();
                    MapTabControl.SelectedTab.Controls.Add(p);
                    p.Active1 = Color.Lime;
                    p.Active2 = Color.Lime;
                    p.Inactive1 = Color.Lime;
                    p.Inactive2 = Color.Lime;
                    p.Text = "";
                    p.Size = new System.Drawing.Size(102, 15);
                    ControlManager.ControlMoverOrResizer.Init(p);
                }
                else
                {
                    MetroMessageBox.Show(TNetworkAdministrator.Form1.ActiveForm, "Primeiro Adicione uma localização", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
