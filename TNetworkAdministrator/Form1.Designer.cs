
using System;
using System.Windows.Forms;

namespace TNetworkAdministrator
{
    partial class Form1
    {

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea37 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend37 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series181 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series182 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series183 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series184 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series185 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title37 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea38 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend38 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series186 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series187 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series188 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series189 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series190 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series191 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title38 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea39 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend39 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series192 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series193 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series194 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series195 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title39 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.CharProblemas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartMonitorados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.StatusList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.LastOnline = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.PingList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.DiskList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CpuList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel11 = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Label();
            this.SystemName = new System.Windows.Forms.Label();
            this.Ip = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharProblemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMonitorados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartStatus)).BeginInit();
            this.panel10.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.StatusList.SuspendLayout();
            this.panel9.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.LastOnline.SuspendLayout();
            this.panel5.SuspendLayout();
            this.PingList.SuspendLayout();
            this.panel4.SuspendLayout();
            this.DiskList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.CpuList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
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
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.StatusList);
            this.panel1.Controls.Add(this.flowLayoutPanel6);
            this.panel1.Controls.Add(this.LastOnline);
            this.panel1.Controls.Add(this.PingList);
            this.panel1.Controls.Add(this.DiskList);
            this.panel1.Controls.Add(this.CpuList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 630);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.CharProblemas);
            this.panel7.Controls.Add(this.ChartMonitorados);
            this.panel7.Controls.Add(this.ChartStatus);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Location = new System.Drawing.Point(16, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1363, 442);
            this.panel7.TabIndex = 42;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // CharProblemas
            // 
            chartArea37.Name = "ChartArea1";
            this.CharProblemas.ChartAreas.Add(chartArea37);
            legend37.Name = "Legend1";
            this.CharProblemas.Legends.Add(legend37);
            this.CharProblemas.Location = new System.Drawing.Point(913, 68);
            this.CharProblemas.Name = "CharProblemas";
            series181.ChartArea = "ChartArea1";
            series181.Legend = "Legend1";
            series181.Name = "Perca de Pacote";
            series182.ChartArea = "ChartArea1";
            series182.Legend = "Legend1";
            series182.Name = "Offline";
            series183.ChartArea = "ChartArea1";
            series183.Legend = "Legend1";
            series183.Name = "Uso Da Rede Extremo";
            series184.ChartArea = "ChartArea1";
            series184.Legend = "Legend1";
            series184.Name = "Uso da CPU Extremo";
            series185.ChartArea = "ChartArea1";
            series185.Legend = "Legend1";
            series185.Name = "Espaço em Disco";
            this.CharProblemas.Series.Add(series181);
            this.CharProblemas.Series.Add(series182);
            this.CharProblemas.Series.Add(series183);
            this.CharProblemas.Series.Add(series184);
            this.CharProblemas.Series.Add(series185);
            this.CharProblemas.Size = new System.Drawing.Size(434, 325);
            this.CharProblemas.TabIndex = 9;
            this.CharProblemas.Text = "chart3";
            title37.Name = "Principais Problemas";
            title37.Text = "Principais Problemas";
            this.CharProblemas.Titles.Add(title37);
            // 
            // ChartMonitorados
            // 
            chartArea38.Name = "ChartArea1";
            this.ChartMonitorados.ChartAreas.Add(chartArea38);
            legend38.Name = "Legend1";
            this.ChartMonitorados.Legends.Add(legend38);
            this.ChartMonitorados.Location = new System.Drawing.Point(453, 57);
            this.ChartMonitorados.Name = "ChartMonitorados";
            series186.ChartArea = "ChartArea1";
            series186.Legend = "Legend1";
            series186.Name = "Computadores";
            series187.ChartArea = "ChartArea1";
            series187.Legend = "Legend1";
            series187.Name = "Switchs";
            series188.ChartArea = "ChartArea1";
            series188.Legend = "Legend1";
            series188.Name = "Ips";
            series189.ChartArea = "ChartArea1";
            series189.Legend = "Legend1";
            series189.Name = "Cameras";
            series190.ChartArea = "ChartArea1";
            series190.Legend = "Legend1";
            series190.Name = "Links";
            series191.ChartArea = "ChartArea1";
            series191.Legend = "Legend1";
            series191.Name = "Outros";
            this.ChartMonitorados.Series.Add(series186);
            this.ChartMonitorados.Series.Add(series187);
            this.ChartMonitorados.Series.Add(series188);
            this.ChartMonitorados.Series.Add(series189);
            this.ChartMonitorados.Series.Add(series190);
            this.ChartMonitorados.Series.Add(series191);
            this.ChartMonitorados.Size = new System.Drawing.Size(434, 325);
            this.ChartMonitorados.TabIndex = 8;
            this.ChartMonitorados.Text = "chart2";
            title38.Name = "Title1";
            title38.Text = "Dispositivos Monitorados";
            this.ChartMonitorados.Titles.Add(title38);
            // 
            // ChartStatus
            // 
            chartArea39.Name = "ChartArea1";
            this.ChartStatus.ChartAreas.Add(chartArea39);
            legend39.Name = "Legend1";
            this.ChartStatus.Legends.Add(legend39);
            this.ChartStatus.Location = new System.Drawing.Point(13, 57);
            this.ChartStatus.Name = "ChartStatus";
            series192.ChartArea = "ChartArea1";
            series192.Legend = "Legend1";
            series192.Name = "Online";
            series193.ChartArea = "ChartArea1";
            series193.Legend = "Legend1";
            series193.Name = "Atenção";
            series194.ChartArea = "ChartArea1";
            series194.Legend = "Legend1";
            series194.Name = "Alerta";
            series195.ChartArea = "ChartArea1";
            series195.Legend = "Legend1";
            series195.Name = "Offline";
            this.ChartStatus.Series.Add(series192);
            this.ChartStatus.Series.Add(series193);
            this.ChartStatus.Series.Add(series194);
            this.ChartStatus.Series.Add(series195);
            this.ChartStatus.Size = new System.Drawing.Size(434, 325);
            this.ChartStatus.TabIndex = 7;
            this.ChartStatus.Text = "chart1";
            title39.Name = "Title1";
            title39.Text = "Status Dispositivos";
            this.ChartStatus.Titles.Add(title39);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button12);
            this.panel10.Controls.Add(this.button11);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(155, 33);
            this.panel10.TabIndex = 3;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Left;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(135, 33);
            this.button12.TabIndex = 2;
            this.button12.Text = "Relatório por Gráfico";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Dock = System.Windows.Forms.DockStyle.Right;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(135, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(20, 33);
            this.button11.TabIndex = 1;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.panel6);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(13, 475);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1366, 408);
            this.flowLayoutPanel4.TabIndex = 41;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1347, 33);
            this.panel6.TabIndex = 2;
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.Dock = System.Windows.Forms.DockStyle.Right;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(1327, 0);
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
            // StatusList
            // 
            this.StatusList.AutoScroll = true;
            this.StatusList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusList.Controls.Add(this.panel9);
            this.StatusList.Controls.Add(this.panel11);
            this.StatusList.Location = new System.Drawing.Point(29, 911);
            this.StatusList.Name = "StatusList";
            this.StatusList.Size = new System.Drawing.Size(322, 338);
            this.StatusList.TabIndex = 40;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button15);
            this.panel9.Controls.Add(this.button16);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(287, 33);
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
            this.button15.Location = new System.Drawing.Point(267, 0);
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
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoScroll = true;
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel6.Controls.Add(this.panel8);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(26, 1268);
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
            // LastOnline
            // 
            this.LastOnline.AutoScroll = true;
            this.LastOnline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastOnline.Controls.Add(this.panel5);
            this.LastOnline.Controls.Add(this.panel12);
            this.LastOnline.Location = new System.Drawing.Point(394, 911);
            this.LastOnline.Name = "LastOnline";
            this.LastOnline.Size = new System.Drawing.Size(322, 338);
            this.LastOnline.TabIndex = 34;
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
            // PingList
            // 
            this.PingList.AutoScroll = true;
            this.PingList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PingList.Controls.Add(this.panel4);
            this.PingList.Controls.Add(this.panel13);
            this.PingList.Location = new System.Drawing.Point(726, 911);
            this.PingList.Name = "PingList";
            this.PingList.Size = new System.Drawing.Size(322, 338);
            this.PingList.TabIndex = 33;
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
            this.button6.Text = "Top 10 por Pior Píng";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // DiskList
            // 
            this.DiskList.AutoScroll = true;
            this.DiskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiskList.Controls.Add(this.panel3);
            this.DiskList.Controls.Add(this.panel16);
            this.DiskList.Location = new System.Drawing.Point(1067, 1271);
            this.DiskList.Name = "DiskList";
            this.DiskList.Size = new System.Drawing.Size(322, 365);
            this.DiskList.TabIndex = 32;
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
            // CpuList
            // 
            this.CpuList.AutoScroll = true;
            this.CpuList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CpuList.Controls.Add(this.panel2);
            this.CpuList.Controls.Add(this.panel15);
            this.CpuList.Location = new System.Drawing.Point(1067, 911);
            this.CpuList.Name = "CpuList";
            this.CpuList.Size = new System.Drawing.Size(322, 338);
            this.CpuList.TabIndex = 31;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DefaultDevice.png");
            this.imageList1.Images.SetKeyName(1, "ComputerImage.png");
            this.imageList1.Images.SetKeyName(2, "PrinterImage.png");
            this.imageList1.Images.SetKeyName(3, "Switch.png");
            this.imageList1.Images.SetKeyName(4, "Security-Camera-icon.png");
            this.imageList1.Images.SetKeyName(5, "LinkImage.png");
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.Status);
            this.panel11.Controls.Add(this.SystemName);
            this.panel11.Controls.Add(this.Ip);
            this.panel11.Controls.Add(this.button17);
            this.panel11.Location = new System.Drawing.Point(3, 42);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(335, 21);
            this.panel11.TabIndex = 1;
            // 
            // Status
            // 
            this.Status.Dock = System.Windows.Forms.DockStyle.Left;
            this.Status.Font = new System.Drawing.Font("Calibri", 10F);
            this.Status.ForeColor = System.Drawing.Color.Black;
            this.Status.Location = new System.Drawing.Point(255, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(99, 21);
            this.Status.TabIndex = 34;
            this.Status.Text = "Status:";
            // 
            // SystemName
            // 
            this.SystemName.Dock = System.Windows.Forms.DockStyle.Left;
            this.SystemName.Font = new System.Drawing.Font("Calibri", 10F);
            this.SystemName.ForeColor = System.Drawing.Color.Black;
            this.SystemName.Location = new System.Drawing.Point(152, 0);
            this.SystemName.Name = "SystemName";
            this.SystemName.Size = new System.Drawing.Size(103, 21);
            this.SystemName.TabIndex = 33;
            this.SystemName.Text = "Nome:";
            // 
            // Ip
            // 
            this.Ip.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ip.Font = new System.Drawing.Font("Calibri", 10F);
            this.Ip.ForeColor = System.Drawing.Color.Black;
            this.Ip.Location = new System.Drawing.Point(47, 0);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(105, 21);
            this.Ip.TabIndex = 32;
            this.Ip.Text = "Ip:";
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button17.Dock = System.Windows.Forms.DockStyle.Left;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(0, 0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(47, 21);
            this.button17.TabIndex = 31;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.label2);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.button18);
            this.panel12.Location = new System.Drawing.Point(3, 42);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(335, 21);
            this.panel12.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(255, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Horário:";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(152, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ip:";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button18.Dock = System.Windows.Forms.DockStyle.Left;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(0, 0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(47, 21);
            this.button18.TabIndex = 31;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.button19);
            this.panel13.Location = new System.Drawing.Point(3, 42);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(335, 21);
            this.panel13.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(255, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ping:";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(152, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(47, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ip:";
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button19.Dock = System.Windows.Forms.DockStyle.Left;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(0, 0);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(47, 21);
            this.button19.TabIndex = 31;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label10);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Controls.Add(this.label12);
            this.panel15.Controls.Add(this.button21);
            this.panel15.Location = new System.Drawing.Point(3, 42);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(335, 21);
            this.panel15.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(255, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "Uso da CPU:";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(152, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 21);
            this.label11.TabIndex = 33;
            this.label11.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Font = new System.Drawing.Font("Calibri", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(47, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 21);
            this.label12.TabIndex = 32;
            this.label12.Text = "Ip:";
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button21.Dock = System.Windows.Forms.DockStyle.Left;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(0, 0);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(47, 21);
            this.button21.TabIndex = 31;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label13);
            this.panel16.Controls.Add(this.label14);
            this.panel16.Controls.Add(this.label15);
            this.panel16.Controls.Add(this.button22);
            this.panel16.Location = new System.Drawing.Point(3, 42);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(335, 21);
            this.panel16.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Font = new System.Drawing.Font("Calibri", 10F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(255, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 21);
            this.label13.TabIndex = 34;
            this.label13.Text = "Espaço Total em Disco:";
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Font = new System.Drawing.Font("Calibri", 10F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(152, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 21);
            this.label14.TabIndex = 33;
            this.label14.Text = "Nome:";
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Font = new System.Drawing.Font("Calibri", 10F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(47, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 21);
            this.label15.TabIndex = 32;
            this.label15.Text = "Ip:";
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button22.Dock = System.Windows.Forms.DockStyle.Left;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(0, 0);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(47, 21);
            this.button22.TabIndex = 31;
            this.button22.UseVisualStyleBackColor = false;
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
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CharProblemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMonitorados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartStatus)).EndInit();
            this.panel10.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.StatusList.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.LastOnline.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.PingList.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.DiskList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.CpuList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
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
        private FlowLayoutPanel DiskList;
        private FlowLayoutPanel CpuList;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Button button3;
        private Button button4;
        private FlowLayoutPanel LastOnline;
        private Panel panel5;
        private Button button7;
        private Button button8;
        private FlowLayoutPanel PingList;
        private Panel panel4;
        private Button button5;
        private Button button6;
        private FlowLayoutPanel flowLayoutPanel6;
        private Panel panel8;
        private Button button13;
        private Button button14;
        private FlowLayoutPanel StatusList;
        private Panel panel9;
        private Button button15;
        private Button button16;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel panel6;
        private Button button10;
        private Button button9;
        private Panel panel7;
        private Panel panel10;
        private Button button11;
        private Button button12;
        private System.Windows.Forms.DataVisualization.Charting.Chart CharProblemas;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMonitorados;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartStatus;
        public ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private Panel panel11;
        public Label Status;
        public Label SystemName;
        public Label Ip;
        private Button button17;
        private Panel panel12;
        public Label label1;
        public Label label2;
        public Label label3;
        private Button button18;
        private Panel panel13;
        public Label label4;
        public Label label5;
        public Label label6;
        private Button button19;
        private Panel panel15;
        public Label label10;
        public Label label11;
        public Label label12;
        private Button button21;
        private Panel panel16;
        public Label label13;
        public Label label14;
        public Label label15;
        private Button button22;
    }
}

