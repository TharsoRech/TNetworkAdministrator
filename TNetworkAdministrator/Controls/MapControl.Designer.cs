
namespace TNetworkAdministrator.Controls
{
    partial class MapControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapControl));
            this.Description = new System.Windows.Forms.Label();
            this.DeviceImage = new System.Windows.Forms.PictureBox();
            this.Online = new System.Windows.Forms.RadioButton();
            this.metroContextMenu1 = new Wisder.W3Common.WMetroControl.Controls.MetroContextMenu(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checarStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceImage)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Georgia", 10F);
            this.Description.Location = new System.Drawing.Point(45, 14);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(46, 17);
            this.Description.TabIndex = 9;
            this.Description.Text = "Nome";
            this.Description.Click += new System.EventHandler(this.StatusText_Click);
            // 
            // DeviceImage
            // 
            this.DeviceImage.BackColor = System.Drawing.Color.Transparent;
            this.DeviceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeviceImage.Image = ((System.Drawing.Image)(resources.GetObject("DeviceImage.Image")));
            this.DeviceImage.Location = new System.Drawing.Point(3, 6);
            this.DeviceImage.Name = "DeviceImage";
            this.DeviceImage.Size = new System.Drawing.Size(32, 35);
            this.DeviceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeviceImage.TabIndex = 26;
            this.DeviceImage.TabStop = false;
            // 
            // Online
            // 
            this.Online.AutoSize = true;
            this.Online.BackColor = System.Drawing.Color.Transparent;
            this.Online.Checked = true;
            this.Online.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Online.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Online.Location = new System.Drawing.Point(109, 29);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(13, 12);
            this.Online.TabIndex = 27;
            this.Online.TabStop = true;
            this.Online.UseVisualStyleBackColor = false;
            this.Online.CheckedChanged += new System.EventHandler(this.Online_CheckedChanged);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.checarStatusToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(147, 70);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // checarStatusToolStripMenuItem
            // 
            this.checarStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("checarStatusToolStripMenuItem.Image")));
            this.checarStatusToolStripMenuItem.Name = "checarStatusToolStripMenuItem";
            this.checarStatusToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.checarStatusToolStripMenuItem.Text = "Checar Status";
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerToolStripMenuItem.Image")));
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // MapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.metroContextMenu1;
            this.Controls.Add(this.Online);
            this.Controls.Add(this.DeviceImage);
            this.Controls.Add(this.Description);
            this.Name = "MapControl";
            this.Size = new System.Drawing.Size(127, 45);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceImage)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Description;
        public System.Windows.Forms.PictureBox DeviceImage;
        private System.Windows.Forms.RadioButton Online;
        private Wisder.W3Common.WMetroControl.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checarStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
    }
}
