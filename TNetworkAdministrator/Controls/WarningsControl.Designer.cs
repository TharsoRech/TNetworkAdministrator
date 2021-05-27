
namespace TNetworkAdministrator.Controls
{
    partial class WarningsControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exibirAlertaDetalhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarEmailDeAlertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerAlertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarSeHáErrosNovosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarningsList = new Wisder.W3Common.WMetroControl.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningsList)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirAlertaDetalhadoToolStripMenuItem,
            this.gerarRelatórioToolStripMenuItem,
            this.enviarEmailDeAlertaToolStripMenuItem,
            this.removerAlertaToolStripMenuItem,
            this.verificarSeHáErrosNovosToolStripMenuItem,
            this.limparListaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 158);
            // 
            // exibirAlertaDetalhadoToolStripMenuItem
            // 
            this.exibirAlertaDetalhadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exibirAlertaDetalhadoToolStripMenuItem.Image")));
            this.exibirAlertaDetalhadoToolStripMenuItem.Name = "exibirAlertaDetalhadoToolStripMenuItem";
            this.exibirAlertaDetalhadoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exibirAlertaDetalhadoToolStripMenuItem.Text = "Exibir Alerta Detalhado";
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gerarRelatórioToolStripMenuItem.Image")));
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.gerarRelatórioToolStripMenuItem.Text = "Gerar Relatório";
            // 
            // enviarEmailDeAlertaToolStripMenuItem
            // 
            this.enviarEmailDeAlertaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enviarEmailDeAlertaToolStripMenuItem.Image")));
            this.enviarEmailDeAlertaToolStripMenuItem.Name = "enviarEmailDeAlertaToolStripMenuItem";
            this.enviarEmailDeAlertaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.enviarEmailDeAlertaToolStripMenuItem.Text = "Enviar Email de Alerta";
            this.enviarEmailDeAlertaToolStripMenuItem.Click += new System.EventHandler(this.enviarEmailDeAlertaToolStripMenuItem_Click);
            // 
            // removerAlertaToolStripMenuItem
            // 
            this.removerAlertaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerAlertaToolStripMenuItem.Image")));
            this.removerAlertaToolStripMenuItem.Name = "removerAlertaToolStripMenuItem";
            this.removerAlertaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.removerAlertaToolStripMenuItem.Text = "Remover Alerta";
            // 
            // verificarSeHáErrosNovosToolStripMenuItem
            // 
            this.verificarSeHáErrosNovosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verificarSeHáErrosNovosToolStripMenuItem.Image")));
            this.verificarSeHáErrosNovosToolStripMenuItem.Name = "verificarSeHáErrosNovosToolStripMenuItem";
            this.verificarSeHáErrosNovosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.verificarSeHáErrosNovosToolStripMenuItem.Text = "Verificar se há erros novos";
            // 
            // limparListaToolStripMenuItem
            // 
            this.limparListaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("limparListaToolStripMenuItem.Image")));
            this.limparListaToolStripMenuItem.Name = "limparListaToolStripMenuItem";
            this.limparListaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.limparListaToolStripMenuItem.Text = "Limpar Lista";
            // 
            // WarningsList
            // 
            this.WarningsList.AllowUserToResizeRows = false;
            this.WarningsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.WarningsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarningsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.WarningsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarningsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.WarningsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarningsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.WarningsList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WarningsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.WarningsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarningsList.EnableHeadersVisualStyles = false;
            this.WarningsList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WarningsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.WarningsList.Location = new System.Drawing.Point(0, 0);
            this.WarningsList.Name = "WarningsList";
            this.WarningsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarningsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.WarningsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.WarningsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WarningsList.Size = new System.Drawing.Size(1065, 802);
            this.WarningsList.TabIndex = 6;
            this.WarningsList.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Erro";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Dispositivo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Tipo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Data";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // WarningsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WarningsList);
            this.Name = "WarningsControl";
            this.Size = new System.Drawing.Size(1065, 802);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarningsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirAlertaDetalhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarEmailDeAlertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerAlertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarSeHáErrosNovosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparListaToolStripMenuItem;
        private Wisder.W3Common.WMetroControl.Controls.MetroGrid WarningsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
