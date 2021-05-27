
namespace TNetworkAdministrator.Controls
{
    partial class ScanControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton6 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchForIP = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.metroProgressBar1 = new Wisder.W3Common.WMetroControl.Controls.MetroProgressBar();
            this.metroButton5 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.SearchForGateway = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IpInicial = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.metroButton2 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.Gateway = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.ScanWorker = new System.ComponentModel.BackgroundWorker();
            this.metroButton3 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroButton1 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.Scaneados = new System.Windows.Forms.FlowLayoutPanel();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton6.Location = new System.Drawing.Point(1059, 136);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(74, 22);
            this.metroButton6.TabIndex = 42;
            this.metroButton6.Text = "Cancelar";
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.UseVisualStyleBackColor = false;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(322, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "(Primeiros 6 digítos,por exemplo:\"172.16.\")\r\n";
            // 
            // SearchForIP
            // 
            this.SearchForIP.AutoSize = true;
            this.SearchForIP.ForeColor = System.Drawing.Color.White;
            this.SearchForIP.Location = new System.Drawing.Point(321, 31);
            this.SearchForIP.Name = "SearchForIP";
            this.SearchForIP.Size = new System.Drawing.Size(150, 15);
            this.SearchForIP.TabIndex = 40;
            this.SearchForIP.Text = "Procurar Por Inico de IP:";
            this.SearchForIP.UseCustomBackColor = true;
            this.SearchForIP.UseCustomForeColor = true;
            this.SearchForIP.UseSelectable = true;
            this.SearchForIP.UseVisualStyleBackColor = true;
            this.SearchForIP.CheckedChanged += new System.EventHandler(this.SearchForIP_CheckedChanged);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(23, 164);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(1110, 23);
            this.metroProgressBar1.TabIndex = 39;
            this.metroProgressBar1.Value = 100;
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton5.Location = new System.Drawing.Point(990, 193);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(146, 22);
            this.metroButton5.TabIndex = 38;
            this.metroButton5.Text = "Adicionar Manualmente";
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.UseVisualStyleBackColor = false;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // SearchForGateway
            // 
            this.SearchForGateway.AutoSize = true;
            this.SearchForGateway.ForeColor = System.Drawing.Color.White;
            this.SearchForGateway.Location = new System.Drawing.Point(35, 38);
            this.SearchForGateway.Name = "SearchForGateway";
            this.SearchForGateway.Size = new System.Drawing.Size(140, 15);
            this.SearchForGateway.TabIndex = 37;
            this.SearchForGateway.Text = "Procurar Por Gateway:";
            this.SearchForGateway.UseCustomBackColor = true;
            this.SearchForGateway.UseCustomForeColor = true;
            this.SearchForGateway.UseSelectable = true;
            this.SearchForGateway.UseVisualStyleBackColor = true;
            this.SearchForGateway.CheckedChanged += new System.EventHandler(this.SearchForGateway_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ip Inicial:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Gateway:";
            // 
            // IpInicial
            // 
            this.IpInicial.Enabled = false;
            this.IpInicial.Lines = new string[0];
            this.IpInicial.Location = new System.Drawing.Point(325, 96);
            this.IpInicial.MaxLength = 7;
            this.IpInicial.Name = "IpInicial";
            this.IpInicial.PasswordChar = '\0';
            this.IpInicial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IpInicial.SelectedText = "";
            this.IpInicial.Size = new System.Drawing.Size(189, 24);
            this.IpInicial.TabIndex = 34;
            this.IpInicial.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.IpInicial.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton2.Location = new System.Drawing.Point(420, 126);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(146, 22);
            this.metroButton2.TabIndex = 33;
            this.metroButton2.Text = "Iniciar Scaneamento";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseVisualStyleBackColor = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Gateway
            // 
            this.Gateway.Enabled = false;
            this.Gateway.Lines = new string[0];
            this.Gateway.Location = new System.Drawing.Point(35, 96);
            this.Gateway.MaxLength = 32767;
            this.Gateway.Name = "Gateway";
            this.Gateway.PasswordChar = '\0';
            this.Gateway.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Gateway.SelectedText = "";
            this.Gateway.Size = new System.Drawing.Size(189, 24);
            this.Gateway.TabIndex = 32;
            this.Gateway.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Gateway.UseSelectable = true;
            // 
            // ScanWorker
            // 
            this.ScanWorker.WorkerSupportsCancellation = true;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton3.Location = new System.Drawing.Point(686, 193);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(146, 22);
            this.metroButton3.TabIndex = 46;
            this.metroButton3.Text = "Selecionar Todos";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseVisualStyleBackColor = false;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.Location = new System.Drawing.Point(838, 193);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(146, 22);
            this.metroButton1.TabIndex = 45;
            this.metroButton1.Text = "Adicionar Selecionados";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Scaneados
            // 
            this.Scaneados.AutoScroll = true;
            this.Scaneados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scaneados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Scaneados.Location = new System.Drawing.Point(0, 221);
            this.Scaneados.Name = "Scaneados";
            this.Scaneados.Size = new System.Drawing.Size(1156, 492);
            this.Scaneados.TabIndex = 44;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(809, 139);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(117, 19);
            this.Status.TabIndex = 43;
            this.Status.Text = "Status Da Coleta";
            // 
            // ScanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchForIP);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.SearchForGateway);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IpInicial);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.Gateway);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Scaneados);
            this.Controls.Add(this.Status);
            this.Name = "ScanControl";
            this.Size = new System.Drawing.Size(1156, 713);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton6;
        private System.Windows.Forms.Label label4;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox SearchForIP;
        private Wisder.W3Common.WMetroControl.Controls.MetroProgressBar metroProgressBar1;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton5;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox SearchForGateway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Wisder.W3Common.WMetroControl.Controls.MetroTextBox IpInicial;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton2;
        private Wisder.W3Common.WMetroControl.Controls.MetroTextBox Gateway;
        private System.ComponentModel.BackgroundWorker ScanWorker;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton3;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton1;
        private System.Windows.Forms.FlowLayoutPanel Scaneados;
        private System.Windows.Forms.Label Status;
    }
}
