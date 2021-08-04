
using System.Drawing;

namespace TNetworkAdministrator.SubFormas
{
    partial class ImageChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageChoose));
            this.DeviceCheck = new System.Windows.Forms.CheckBox();
            this.ServerCheck = new System.Windows.Forms.CheckBox();
            this.ComputerCheck = new System.Windows.Forms.CheckBox();
            this.PrinterCheck = new System.Windows.Forms.CheckBox();
            this.WifiCheck = new System.Windows.Forms.CheckBox();
            this.SwitchCheck = new System.Windows.Forms.CheckBox();
            this.metroButton2 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.SaveButton = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.LinkCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DeviceCheck
            // 
            this.DeviceCheck.AutoSize = true;
            this.DeviceCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeviceCheck.ForeColor = System.Drawing.Color.White;
            this.DeviceCheck.Location = new System.Drawing.Point(27, 76);
            this.DeviceCheck.Name = "DeviceCheck";
            this.DeviceCheck.Size = new System.Drawing.Size(77, 17);
            this.DeviceCheck.TabIndex = 0;
            this.DeviceCheck.Text = "Dispositivo";
            this.DeviceCheck.UseVisualStyleBackColor = true;
            // 
            // ServerCheck
            // 
            this.ServerCheck.AutoSize = true;
            this.ServerCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ServerCheck.ForeColor = System.Drawing.Color.White;
            this.ServerCheck.Location = new System.Drawing.Point(136, 76);
            this.ServerCheck.Name = "ServerCheck";
            this.ServerCheck.Size = new System.Drawing.Size(65, 17);
            this.ServerCheck.TabIndex = 1;
            this.ServerCheck.Text = "Servidor";
            this.ServerCheck.UseVisualStyleBackColor = true;
            // 
            // ComputerCheck
            // 
            this.ComputerCheck.AutoSize = true;
            this.ComputerCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComputerCheck.ForeColor = System.Drawing.Color.White;
            this.ComputerCheck.Location = new System.Drawing.Point(27, 122);
            this.ComputerCheck.Name = "ComputerCheck";
            this.ComputerCheck.Size = new System.Drawing.Size(83, 17);
            this.ComputerCheck.TabIndex = 2;
            this.ComputerCheck.Text = "Computador";
            this.ComputerCheck.UseVisualStyleBackColor = true;
            // 
            // PrinterCheck
            // 
            this.PrinterCheck.AutoSize = true;
            this.PrinterCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrinterCheck.ForeColor = System.Drawing.Color.White;
            this.PrinterCheck.Location = new System.Drawing.Point(136, 122);
            this.PrinterCheck.Name = "PrinterCheck";
            this.PrinterCheck.Size = new System.Drawing.Size(77, 17);
            this.PrinterCheck.TabIndex = 3;
            this.PrinterCheck.Text = "Impressora";
            this.PrinterCheck.UseVisualStyleBackColor = true;
            // 
            // WifiCheck
            // 
            this.WifiCheck.AutoSize = true;
            this.WifiCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WifiCheck.ForeColor = System.Drawing.Color.White;
            this.WifiCheck.Location = new System.Drawing.Point(27, 171);
            this.WifiCheck.Name = "WifiCheck";
            this.WifiCheck.Size = new System.Drawing.Size(44, 17);
            this.WifiCheck.TabIndex = 4;
            this.WifiCheck.Text = "Wifi";
            this.WifiCheck.UseVisualStyleBackColor = true;
            // 
            // SwitchCheck
            // 
            this.SwitchCheck.AutoSize = true;
            this.SwitchCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SwitchCheck.ForeColor = System.Drawing.Color.White;
            this.SwitchCheck.Location = new System.Drawing.Point(136, 171);
            this.SwitchCheck.Name = "SwitchCheck";
            this.SwitchCheck.Size = new System.Drawing.Size(58, 17);
            this.SwitchCheck.TabIndex = 5;
            this.SwitchCheck.Text = "Switch";
            this.SwitchCheck.UseVisualStyleBackColor = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton2.Location = new System.Drawing.Point(23, 254);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(100, 22);
            this.metroButton2.TabIndex = 31;
            this.metroButton2.Text = "Cancelar";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveButton.Location = new System.Drawing.Point(136, 254);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 22);
            this.SaveButton.TabIndex = 30;
            this.SaveButton.Text = "Salvar";
            this.SaveButton.UseCustomBackColor = true;
            this.SaveButton.UseSelectable = true;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LinkCheck
            // 
            this.LinkCheck.AutoSize = true;
            this.LinkCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LinkCheck.ForeColor = System.Drawing.Color.White;
            this.LinkCheck.Location = new System.Drawing.Point(27, 211);
            this.LinkCheck.Name = "LinkCheck";
            this.LinkCheck.Size = new System.Drawing.Size(46, 17);
            this.LinkCheck.TabIndex = 32;
            this.LinkCheck.Text = "Link";
            this.LinkCheck.UseVisualStyleBackColor = true;
            // 
            // ImageChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 299);
            this.Controls.Add(this.LinkCheck);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SwitchCheck);
            this.Controls.Add(this.WifiCheck);
            this.Controls.Add(this.PrinterCheck);
            this.Controls.Add(this.ComputerCheck);
            this.Controls.Add(this.ServerCheck);
            this.Controls.Add(this.DeviceCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageChoose";
            this.Text = "Escolher Imagens";
            this.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ImageChoose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DeviceCheck;
        private System.Windows.Forms.CheckBox ServerCheck;
        private System.Windows.Forms.CheckBox ComputerCheck;
        private System.Windows.Forms.CheckBox PrinterCheck;
        private System.Windows.Forms.CheckBox WifiCheck;
        private System.Windows.Forms.CheckBox SwitchCheck;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton2;
        public Wisder.W3Common.WMetroControl.Controls.MetroButton SaveButton;
        private System.Windows.Forms.CheckBox LinkCheck;
    }
}