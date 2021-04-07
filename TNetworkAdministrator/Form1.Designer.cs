
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
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Scaneados = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Scaneados.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.panel9.SuspendLayout();
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
            this.ribbon1.Size = new System.Drawing.Size(1420, 113);
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
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.flowLayoutPanel7);
            this.panel1.Controls.Add(this.flowLayoutPanel6);
            this.panel1.Controls.Add(this.flowLayoutPanel5);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.Scaneados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 630);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoScroll = true;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel5.Controls.Add(this.panel7);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(13, 18);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(471, 408);
            this.flowLayoutPanel5.TabIndex = 36;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button12);
            this.panel7.Controls.Add(this.button11);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(468, 33);
            this.panel7.TabIndex = 2;
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.Dock = System.Windows.Forms.DockStyle.Right;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(448, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(20, 33);
            this.button12.TabIndex = 1;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Left;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(179, 33);
            this.button11.TabIndex = 0;
            this.button11.Text = "Monitoramento Total";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.panel6);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(507, 18);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(865, 408);
            this.flowLayoutPanel4.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(851, 33);
            this.panel6.TabIndex = 2;
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.Dock = System.Windows.Forms.DockStyle.Right;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(831, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(20, 33);
            this.button10.TabIndex = 1;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Left;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 33);
            this.button9.TabIndex = 0;
            this.button9.Text = "Status de Conectividade";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.panel5);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(384, 475);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(322, 338);
            this.flowLayoutPanel3.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 33);
            this.panel5.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(288, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(20, 33);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Left;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(179, 33);
            this.button8.TabIndex = 0;
            this.button8.Text = "Top 10 por Ultima Vez Online";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(716, 475);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(322, 338);
            this.flowLayoutPanel2.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 33);
            this.panel4.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(288, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 33);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Left;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 33);
            this.button6.TabIndex = 0;
            this.button6.Text = "Top 10 por Píng";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1057, 835);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(322, 365);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 33);
            this.panel3.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(288, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 33);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 33);
            this.button4.TabIndex = 0;
            this.button4.Text = "Top 10 por Uso Total do Disco";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Scaneados
            // 
            this.Scaneados.AutoScroll = true;
            this.Scaneados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scaneados.Controls.Add(this.panel2);
            this.Scaneados.Location = new System.Drawing.Point(1057, 475);
            this.Scaneados.Name = "Scaneados";
            this.Scaneados.Size = new System.Drawing.Size(322, 338);
            this.Scaneados.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 33);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(288, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 33);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Top 10 por Uso da CPU";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoScroll = true;
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel6.Controls.Add(this.panel8);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(16, 832);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(1022, 371);
            this.flowLayoutPanel6.TabIndex = 39;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button13);
            this.panel8.Controls.Add(this.button14);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(851, 33);
            this.panel8.TabIndex = 2;
            // 
            // button13
            // 
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.Dock = System.Windows.Forms.DockStyle.Right;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(831, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(20, 33);
            this.button13.TabIndex = 1;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Left;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(0, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(135, 33);
            this.button14.TabIndex = 0;
            this.button14.Text = "Mapa de Dispositivos";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoScroll = true;
            this.flowLayoutPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel7.Controls.Add(this.panel9);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(39, 475);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(322, 338);
            this.flowLayoutPanel7.TabIndex = 40;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button15);
            this.panel9.Controls.Add(this.button16);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(308, 33);
            this.panel9.TabIndex = 0;
            // 
            // button15
            // 
            this.button15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button15.Dock = System.Windows.Forms.DockStyle.Right;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(288, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(20, 33);
            this.button15.TabIndex = 1;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Left;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(0, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(179, 33);
            this.button16.TabIndex = 0;
            this.button16.Text = "Dispositivos por status";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Scaneados.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel Scaneados;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Button button3;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel5;
        private Button button7;
        private Button button8;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel4;
        private Button button5;
        private Button button6;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel panel6;
        private Button button10;
        private Button button9;
        private Panel panel7;
        private Button button12;
        private Button button11;
        private FlowLayoutPanel flowLayoutPanel6;
        private Panel panel8;
        private Button button13;
        private Button button14;
        private FlowLayoutPanel flowLayoutPanel7;
        private Panel panel9;
        private Button button15;
        private Button button16;
    }
}

