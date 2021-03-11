
namespace TNetworkAdministrator.Controls
{
    partial class Device
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Device));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.DeviceText = new System.Windows.Forms.Label();
            this.Grouptext = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Ip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DefaultDevice.png");
            this.imageList1.Images.SetKeyName(1, "ComputerImage.png");
            this.imageList1.Images.SetKeyName(2, "PrinterImage.png");
            this.imageList1.Images.SetKeyName(3, "WifiImage.png");
            this.imageList1.Images.SetKeyName(4, "Switch.png");
            this.imageList1.Images.SetKeyName(5, "LinkImage.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DeviceText
            // 
            this.DeviceText.AutoSize = true;
            this.DeviceText.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceText.ForeColor = System.Drawing.Color.Black;
            this.DeviceText.Location = new System.Drawing.Point(328, 6);
            this.DeviceText.Name = "DeviceText";
            this.DeviceText.Size = new System.Drawing.Size(93, 23);
            this.DeviceText.TabIndex = 12;
            this.DeviceText.Text = "Dipositivo:";
            // 
            // Grouptext
            // 
            this.Grouptext.AutoSize = true;
            this.Grouptext.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grouptext.ForeColor = System.Drawing.Color.Black;
            this.Grouptext.Location = new System.Drawing.Point(670, 6);
            this.Grouptext.Name = "Grouptext";
            this.Grouptext.Size = new System.Drawing.Size(64, 23);
            this.Grouptext.TabIndex = 14;
            this.Grouptext.Text = "Grupo:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(959, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 38);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(909, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 38);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ip
            // 
            this.Ip.AutoSize = true;
            this.Ip.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ip.ForeColor = System.Drawing.Color.Black;
            this.Ip.Location = new System.Drawing.Point(53, 6);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(31, 23);
            this.Ip.TabIndex = 17;
            this.Ip.Text = "Ip:";
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Grouptext);
            this.Controls.Add(this.DeviceText);
            this.Controls.Add(this.button1);
            this.Name = "Device";
            this.Size = new System.Drawing.Size(1014, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DeviceText;
        private System.Windows.Forms.Label Grouptext;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Ip;
    }
}
