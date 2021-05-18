
namespace TNetworkAdministrator.Controls
{
    partial class DeviceScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceScan));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Ip = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DeviceText = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.ScanDeviceWork = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DeviceImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DefaultDevice.png");
            this.imageList1.Images.SetKeyName(1, "Device-computer-icon.png");
            this.imageList1.Images.SetKeyName(2, "printer.png");
            this.imageList1.Images.SetKeyName(3, "Switch.png");
            this.imageList1.Images.SetKeyName(4, "e14894d1b443ee21cbb0e6f94eb71b71.png");
            this.imageList1.Images.SetKeyName(5, "wireless-access-point-icon-29.jpg");
            // 
            // Ip
            // 
            this.Ip.AutoSize = true;
            this.Ip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ip.ForeColor = System.Drawing.Color.Black;
            this.Ip.Location = new System.Drawing.Point(53, 6);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(25, 19);
            this.Ip.TabIndex = 21;
            this.Ip.Text = "Ip:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1032, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 35);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // DeviceText
            // 
            this.DeviceText.AutoSize = true;
            this.DeviceText.Font = new System.Drawing.Font("Calibri", 12F);
            this.DeviceText.ForeColor = System.Drawing.Color.Black;
            this.DeviceText.Location = new System.Drawing.Point(259, 6);
            this.DeviceText.Name = "DeviceText";
            this.DeviceText.Size = new System.Drawing.Size(78, 19);
            this.DeviceText.TabIndex = 19;
            this.DeviceText.Text = "Dipositivo:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Calibri", 12F);
            this.Status.ForeColor = System.Drawing.Color.Black;
            this.Status.Location = new System.Drawing.Point(619, 7);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(53, 19);
            this.Status.TabIndex = 23;
            this.Status.Text = "Status:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(982, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 35);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(951, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(31, 35);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DeviceImage
            // 
            this.DeviceImage.BackColor = System.Drawing.Color.Transparent;
            this.DeviceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeviceImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeviceImage.Image = ((System.Drawing.Image)(resources.GetObject("DeviceImage.Image")));
            this.DeviceImage.Location = new System.Drawing.Point(0, 0);
            this.DeviceImage.Name = "DeviceImage";
            this.DeviceImage.Size = new System.Drawing.Size(32, 35);
            this.DeviceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeviceImage.TabIndex = 25;
            this.DeviceImage.TabStop = false;
            // 
            // DeviceScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DeviceText);
            this.Controls.Add(this.DeviceImage);
            this.Name = "DeviceScan";
            this.Size = new System.Drawing.Size(1087, 35);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label Ip;
        public System.Windows.Forms.Label DeviceText;
        public System.Windows.Forms.Label Status;
        public System.ComponentModel.BackgroundWorker ScanDeviceWork;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox DeviceImage;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
