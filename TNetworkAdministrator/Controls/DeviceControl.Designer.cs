
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Backbackground = new AltoControls.AltoButton();
            this.StatusText = new AltoControls.AltoSlidingLabel();
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Accept-icon.png");
            this.imageList1.Images.SetKeyName(1, "2735421_warning-symbol-warning-icon-png-transparent-png.png");
            this.imageList1.Images.SetKeyName(2, "PngItem_3638770.png");
            this.imageList1.Images.SetKeyName(3, "qmwskqgpny cópia.png");
            // 
            // Backbackground
            // 
            this.Backbackground.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.Backbackground.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.Backbackground.BackColor = System.Drawing.Color.Transparent;
            this.Backbackground.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Backbackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Backbackground.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.Backbackground.ForeColor = System.Drawing.Color.Black;
            this.Backbackground.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Backbackground.Inactive2 = System.Drawing.Color.Transparent;
            this.Backbackground.Location = new System.Drawing.Point(0, 0);
            this.Backbackground.Name = "Backbackground";
            this.Backbackground.Radius = 10;
            this.Backbackground.Size = new System.Drawing.Size(78, 80);
            this.Backbackground.Stroke = false;
            this.Backbackground.StrokeColor = System.Drawing.Color.Gray;
            this.Backbackground.TabIndex = 8;
            this.Backbackground.Transparency = false;
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(3, 48);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(72, 18);
            this.StatusText.Slide = true;
            this.StatusText.TabIndex = 9;
            this.StatusText.Text = "altoSlidingLabel1";
            // 
            // DeviceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.Backbackground);
            this.Name = "DeviceControl";
            this.Size = new System.Drawing.Size(78, 80);
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.ImageList imageList1;
        private AltoControls.AltoButton Backbackground;
        private AltoControls.AltoSlidingLabel StatusText;
    }
}
