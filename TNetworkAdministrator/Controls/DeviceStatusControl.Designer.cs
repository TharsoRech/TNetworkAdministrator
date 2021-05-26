
namespace TNetworkAdministrator.Controls
{
    partial class DeviceStatusControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceStatusControl));
            this.Status = new System.Windows.Forms.Label();
            this.SystemName = new System.Windows.Forms.Label();
            this.Ip = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.Dock = System.Windows.Forms.DockStyle.Left;
            this.Status.Font = new System.Drawing.Font("Calibri", 10F);
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(255, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(99, 21);
            this.Status.TabIndex = 26;
            this.Status.Text = "Status:";
            // 
            // SystemName
            // 
            this.SystemName.BackColor = System.Drawing.Color.Transparent;
            this.SystemName.Dock = System.Windows.Forms.DockStyle.Left;
            this.SystemName.Font = new System.Drawing.Font("Calibri", 10F);
            this.SystemName.ForeColor = System.Drawing.Color.White;
            this.SystemName.Location = new System.Drawing.Point(152, 0);
            this.SystemName.Name = "SystemName";
            this.SystemName.Size = new System.Drawing.Size(103, 21);
            this.SystemName.TabIndex = 25;
            this.SystemName.Text = "Nome:";
            // 
            // Ip
            // 
            this.Ip.BackColor = System.Drawing.Color.Transparent;
            this.Ip.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ip.Font = new System.Drawing.Font("Calibri", 10F);
            this.Ip.ForeColor = System.Drawing.Color.White;
            this.Ip.Location = new System.Drawing.Point(47, 0);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(105, 21);
            this.Ip.TabIndex = 24;
            this.Ip.Text = "Ip:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 21);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DeviceStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.SystemName);
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.button1);
            this.Name = "DeviceStatusControl";
            this.Size = new System.Drawing.Size(360, 21);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Status;
        public System.Windows.Forms.Label SystemName;
        public System.Windows.Forms.Label Ip;
    }
}
