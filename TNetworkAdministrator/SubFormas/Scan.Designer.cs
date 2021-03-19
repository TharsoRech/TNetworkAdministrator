
namespace TNetworkAdministrator.SubFormas
{
    partial class Scan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scan));
            this.Gateway = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.metroButton2 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.IpInicial = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton5 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroProgressBar1 = new Wisder.W3Common.WMetroControl.Controls.MetroProgressBar();
            this.SearchForGateway = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.SearchForIP = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.metroButton6 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.ScanWorker = new System.ComponentModel.BackgroundWorker();
            this.Status = new System.Windows.Forms.Label();
            this.Scaneados = new System.Windows.Forms.FlowLayoutPanel();
            this.metroButton1 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroButton3 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Gateway
            // 
            this.Gateway.Enabled = false;
            this.Gateway.Lines = new string[0];
            this.Gateway.Location = new System.Drawing.Point(35, 128);
            this.Gateway.MaxLength = 32767;
            this.Gateway.Name = "Gateway";
            this.Gateway.PasswordChar = '\0';
            this.Gateway.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Gateway.SelectedText = "";
            this.Gateway.Size = new System.Drawing.Size(189, 24);
            this.Gateway.TabIndex = 6;
            this.Gateway.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton2.Location = new System.Drawing.Point(420, 158);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(146, 22);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Iniciar Scaneamento";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseVisualStyleBackColor = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // IpInicial
            // 
            this.IpInicial.Enabled = false;
            this.IpInicial.Lines = new string[0];
            this.IpInicial.Location = new System.Drawing.Point(325, 128);
            this.IpInicial.MaxLength = 7;
            this.IpInicial.Name = "IpInicial";
            this.IpInicial.PasswordChar = '\0';
            this.IpInicial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IpInicial.SelectedText = "";
            this.IpInicial.Size = new System.Drawing.Size(189, 24);
            this.IpInicial.TabIndex = 8;
            this.IpInicial.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gateway:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(321, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ip Inicial:\r\n";
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton5.Location = new System.Drawing.Point(990, 225);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(146, 22);
            this.metroButton5.TabIndex = 23;
            this.metroButton5.Text = "Adicionar Manualmente";
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.UseVisualStyleBackColor = false;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(23, 196);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(1110, 23);
            this.metroProgressBar1.TabIndex = 24;
            this.metroProgressBar1.Value = 100;
            // 
            // SearchForGateway
            // 
            this.SearchForGateway.AutoSize = true;
            this.SearchForGateway.Location = new System.Drawing.Point(35, 70);
            this.SearchForGateway.Name = "SearchForGateway";
            this.SearchForGateway.Size = new System.Drawing.Size(140, 15);
            this.SearchForGateway.TabIndex = 22;
            this.SearchForGateway.Text = "Procurar Por Gateway:";
            this.SearchForGateway.UseSelectable = true;
            this.SearchForGateway.UseVisualStyleBackColor = true;
            this.SearchForGateway.CheckedChanged += new System.EventHandler(this.SearchForGateway_CheckedChanged);
            // 
            // SearchForIP
            // 
            this.SearchForIP.AutoSize = true;
            this.SearchForIP.Location = new System.Drawing.Point(321, 63);
            this.SearchForIP.Name = "SearchForIP";
            this.SearchForIP.Size = new System.Drawing.Size(150, 15);
            this.SearchForIP.TabIndex = 25;
            this.SearchForIP.Text = "Procurar Por Inico de IP:";
            this.SearchForIP.UseSelectable = true;
            this.SearchForIP.UseVisualStyleBackColor = true;
            this.SearchForIP.CheckedChanged += new System.EventHandler(this.SearchForIP_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(322, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "(Primeiros 6 digítos,por exemplo:\"172.16.\")\r\n";
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton6.Location = new System.Drawing.Point(1059, 168);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(74, 22);
            this.metroButton6.TabIndex = 27;
            this.metroButton6.Text = "Cancelar";
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.UseVisualStyleBackColor = false;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // ScanWorker
            // 
            this.ScanWorker.WorkerSupportsCancellation = true;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.Black;
            this.Status.Location = new System.Drawing.Point(809, 171);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(117, 19);
            this.Status.TabIndex = 28;
            this.Status.Text = "Status Da Coleta";
            // 
            // Scaneados
            // 
            this.Scaneados.AutoScroll = true;
            this.Scaneados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scaneados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Scaneados.Location = new System.Drawing.Point(20, 261);
            this.Scaneados.Name = "Scaneados";
            this.Scaneados.Size = new System.Drawing.Size(1116, 432);
            this.Scaneados.TabIndex = 29;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.Location = new System.Drawing.Point(838, 225);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(146, 22);
            this.metroButton1.TabIndex = 30;
            this.metroButton1.Text = "Adicionar Selecionados";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton3.Location = new System.Drawing.Point(686, 225);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(146, 22);
            this.metroButton3.TabIndex = 31;
            this.metroButton3.Text = "Selecionar Todos";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseVisualStyleBackColor = false;
            // 
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 713);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Scaneados);
            this.Controls.Add(this.Status);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scan";
            this.Text = "Scan";
            this.Load += new System.EventHandler(this.Scan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisder.W3Common.WMetroControl.Controls.MetroTextBox Gateway;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton2;
        private Wisder.W3Common.WMetroControl.Controls.MetroTextBox IpInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton5;
        private Wisder.W3Common.WMetroControl.Controls.MetroProgressBar metroProgressBar1;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox SearchForGateway;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox SearchForIP;
        private System.Windows.Forms.Label label4;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton6;
        private System.ComponentModel.BackgroundWorker ScanWorker;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.FlowLayoutPanel Scaneados;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton1;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton3;
    }
}