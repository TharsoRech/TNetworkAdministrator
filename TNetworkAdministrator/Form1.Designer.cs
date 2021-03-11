
using System;
using System.Windows.Forms;

namespace TNetworkAdministrator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private Wisder.W3Common.WMetroControl.Forms.MetroForm components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribboninventario = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonscan = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonconfig = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonexit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.Inventario = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.Scannear = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.Alertas = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.Relatorios = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.Configuracoes = new System.Windows.Forms.RibbonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(20, 30);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribboninventario);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonscan);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonconfig);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonexit);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 248);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbText = "Arquivo";
            this.ribbon1.PanelCaptionHeight = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1346, 113);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
      
            // 
            // ribboninventario
            // 
            this.ribboninventario.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribboninventario.Image = ((System.Drawing.Image)(resources.GetObject("ribboninventario.Image")));
            this.ribboninventario.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribboninventario.SmallImage")));
            this.ribboninventario.Text = " Inventário";
            // 
            // ribbonscan
            // 
            this.ribbonscan.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonscan.Image = ((System.Drawing.Image)(resources.GetObject("ribbonscan.Image")));
            this.ribbonscan.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonscan.SmallImage")));
            this.ribbonscan.Text = "Scanear Rede";
            // 
            // ribbonconfig
            // 
            this.ribbonconfig.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonconfig.Image = ((System.Drawing.Image)(resources.GetObject("ribbonconfig.Image")));
            this.ribbonconfig.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonconfig.SmallImage")));
            this.ribbonconfig.Text = "Configurações";
            // 
            // ribbonexit
            // 
            this.ribbonexit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonexit.Image = ((System.Drawing.Image)(resources.GetObject("ribbonexit.Image")));
            this.ribbonexit.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonexit.SmallImage")));
            this.ribbonexit.Text = "Sair";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Panels.Add(this.ribbonPanel4);
            this.ribbonTab1.Panels.Add(this.ribbonPanel5);
            this.ribbonTab1.Text = "Gerenciamento";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.Inventario);
            this.ribbonPanel1.Text = "Inventario";
            // 
            // Inventario
            // 
            this.Inventario.Image = ((System.Drawing.Image)(resources.GetObject("Inventario.Image")));
            this.Inventario.SmallImage = ((System.Drawing.Image)(resources.GetObject("Inventario.SmallImage")));
            this.Inventario.Text = "Inventário";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.Scannear);
            this.ribbonPanel2.Text = "Scanear Rede";
            // 
            // Scannear
            // 
            this.Scannear.Image = ((System.Drawing.Image)(resources.GetObject("Scannear.Image")));
            this.Scannear.SmallImage = ((System.Drawing.Image)(resources.GetObject("Scannear.SmallImage")));
            this.Scannear.Text = "Scaneamento de Rede";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.Alertas);
            this.ribbonPanel3.Text = "ribbonPanel3";
            // 
            // Alertas
            // 
            this.Alertas.Image = ((System.Drawing.Image)(resources.GetObject("Alertas.Image")));
            this.Alertas.SmallImage = ((System.Drawing.Image)(resources.GetObject("Alertas.SmallImage")));
            this.Alertas.Text = "Alertas";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.Relatorios);
            this.ribbonPanel4.Text = "ribbonPanel4";
            // 
            // Relatorios
            // 
            this.Relatorios.Image = ((System.Drawing.Image)(resources.GetObject("Relatorios.Image")));
            this.Relatorios.SmallImage = ((System.Drawing.Image)(resources.GetObject("Relatorios.SmallImage")));
            this.Relatorios.Text = "Relatórios";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.Configuracoes);
            this.ribbonPanel5.Text = "ribbonPanel5";
            // 
            // Configuracoes
            // 
            this.Configuracoes.Image = ((System.Drawing.Image)(resources.GetObject("Configuracoes.Image")));
            this.Configuracoes.SmallImage = ((System.Drawing.Image)(resources.GetObject("Configuracoes.SmallImage")));
            this.Configuracoes.Text = "Configurações";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 630);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonOrbMenuItem ribboninventario;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonscan;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonconfig;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonexit;
        private System.Windows.Forms.RibbonButton Inventario;
        private System.Windows.Forms.RibbonButton Scannear;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton Alertas;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton Relatorios;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton Configuracoes;
        private System.Windows.Forms.Panel panel1;
    }
}

