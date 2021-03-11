
namespace TNetworkAdministrator.SubFormas
{
    partial class Warnings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warnings));
            this.ListOfAlert = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirAlertaDetalhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarEmailDeAlertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerAlertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroButton1 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroButton2 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfAlert
            // 
            this.ListOfAlert.ContextMenuStrip = this.contextMenuStrip1;
            this.ListOfAlert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListOfAlert.Location = new System.Drawing.Point(20, 127);
            this.ListOfAlert.Name = "ListOfAlert";
            this.ListOfAlert.Size = new System.Drawing.Size(1025, 655);
            this.ListOfAlert.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirAlertaDetalhadoToolStripMenuItem,
            this.gerarRelatórioToolStripMenuItem,
            this.enviarEmailDeAlertaToolStripMenuItem,
            this.removerAlertaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 92);
            // 
            // exibirAlertaDetalhadoToolStripMenuItem
            // 
            this.exibirAlertaDetalhadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exibirAlertaDetalhadoToolStripMenuItem.Image")));
            this.exibirAlertaDetalhadoToolStripMenuItem.Name = "exibirAlertaDetalhadoToolStripMenuItem";
            this.exibirAlertaDetalhadoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exibirAlertaDetalhadoToolStripMenuItem.Text = "Exibir Alerta Detalhado";
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gerarRelatórioToolStripMenuItem.Image")));
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gerarRelatórioToolStripMenuItem.Text = "Gerar Relatório";
            // 
            // enviarEmailDeAlertaToolStripMenuItem
            // 
            this.enviarEmailDeAlertaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enviarEmailDeAlertaToolStripMenuItem.Image")));
            this.enviarEmailDeAlertaToolStripMenuItem.Name = "enviarEmailDeAlertaToolStripMenuItem";
            this.enviarEmailDeAlertaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.enviarEmailDeAlertaToolStripMenuItem.Text = "Enviar Email de Alerta";
            this.enviarEmailDeAlertaToolStripMenuItem.Click += new System.EventHandler(this.enviarEmailDeAlertaToolStripMenuItem_Click);
            // 
            // removerAlertaToolStripMenuItem
            // 
            this.removerAlertaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerAlertaToolStripMenuItem.Image")));
            this.removerAlertaToolStripMenuItem.Name = "removerAlertaToolStripMenuItem";
            this.removerAlertaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.removerAlertaToolStripMenuItem.Text = "Remover Alerta";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.Location = new System.Drawing.Point(20, 99);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(173, 22);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Verificar se há novos alertas";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton2.Location = new System.Drawing.Point(211, 99);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(173, 22);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Limpar Lista";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseVisualStyleBackColor = false;
            // 
            // Warnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 802);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ListOfAlert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warnings";
            this.Text = "Alertas";
            this.Load += new System.EventHandler(this.Warnings_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ListOfAlert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirAlertaDetalhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarEmailDeAlertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerAlertaToolStripMenuItem;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton1;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton2;
    }
}