
namespace TNetworkAdministrator.Controls
{
    partial class DeviceControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceControl));
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.StatusText = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.SuspendLayout();
            // 
            // Image1
            // 
            this.Image1.BackColor = System.Drawing.Color.Transparent;
            this.Image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Image1.Image = ((System.Drawing.Image)(resources.GetObject("Image1.Image")));
            this.Image1.Location = new System.Drawing.Point(19, 10);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(32, 32);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image1.TabIndex = 0;
            this.Image1.TabStop = false;
            this.Image1.Click += new System.EventHandler(this.Image1_Click);
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Font = new System.Drawing.Font("Georgia", 10F);
            this.StatusText.Location = new System.Drawing.Point(0, 53);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(37, 17);
            this.StatusText.TabIndex = 7;
            this.StatusText.Text = "Bom";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Accept-icon.png");
            this.imageList1.Images.SetKeyName(1, "2735421_warning-symbol-warning-icon-png-transparent-png.png");
            this.imageList1.Images.SetKeyName(2, "PngItem_3638770.png");
            this.imageList1.Images.SetKeyName(3, "qmwskqgpny cópia.png");
            // 
            // DeviceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Image1);
            this.Name = "DeviceControl";
            this.Size = new System.Drawing.Size(78, 80);
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox Image1;
        public System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.ImageList imageList1;
    }
}
