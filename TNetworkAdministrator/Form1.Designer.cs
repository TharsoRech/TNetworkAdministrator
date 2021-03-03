
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
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem3 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem4 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.Inventario = new System.Windows.Forms.RibbonButton();
            this.Scannear = new System.Windows.Forms.RibbonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.Alertas = new System.Windows.Forms.RibbonButton();
            this.Relatorios = new System.Windows.Forms.RibbonButton();
            this.Configuracoes = new System.Windows.Forms.RibbonButton();
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
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem3);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem4);
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
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = " Inventário";
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "Scanear Rede";
            // 
            // ribbonOrbMenuItem3
            // 
            this.ribbonOrbMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.Image")));
            this.ribbonOrbMenuItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.SmallImage")));
            this.ribbonOrbMenuItem3.Text = "Configurações";
            // 
            // ribbonOrbMenuItem4
            // 
            this.ribbonOrbMenuItem4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem4.Image")));
            this.ribbonOrbMenuItem4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem4.SmallImage")));
            this.ribbonOrbMenuItem4.Text = "Sair";
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
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.Scannear);
            this.ribbonPanel2.Text = "Scanear Rede";
            // 
            // Inventario
            // 
            this.Inventario.Image = ((System.Drawing.Image)(resources.GetObject("Inventario.Image")));
            this.Inventario.Text = "Inventário";
            // 
            // Scannear
            // 
            this.Scannear.Image = ((System.Drawing.Image)(resources.GetObject("Scannear.Image")));
            this.Scannear.SmallImage = ((System.Drawing.Image)(resources.GetObject("Scannear.SmallImage")));
            this.Scannear.Text = "Scaneamento de Rede";
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
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.Alertas);
            this.ribbonPanel3.Text = "ribbonPanel3";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.Relatorios);
            this.ribbonPanel4.Text = "ribbonPanel4";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.Configuracoes);
            this.ribbonPanel5.Text = "ribbonPanel5";
            // 
            // Alertas
            // 
            this.Alertas.Image = ((System.Drawing.Image)(resources.GetObject("Alertas.Image")));
            this.Alertas.SmallImage = ((System.Drawing.Image)(resources.GetObject("Alertas.SmallImage")));
            this.Alertas.Text = "Alertas";
            // 
            // Relatorios
            // 
            this.Relatorios.Image = ((System.Drawing.Image)(resources.GetObject("Relatorios.Image")));
            this.Relatorios.SmallImage = ((System.Drawing.Image)(resources.GetObject("Relatorios.SmallImage")));
            this.Relatorios.Text = "Relatórios";
            // 
            // Configuracoes
            // 
            this.Configuracoes.Image = ((System.Drawing.Image)(resources.GetObject("Configuracoes.Image")));
            this.Configuracoes.SmallImage = ((System.Drawing.Image)(resources.GetObject("Configuracoes.SmallImage")));
            this.Configuracoes.Text = "Configurações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.DisplayHeader = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem3;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem4;
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

