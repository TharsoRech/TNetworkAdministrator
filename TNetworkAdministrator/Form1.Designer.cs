
using System;
using System.Windows.Forms;

namespace TNetworkAdministrator
{
    partial class Form1
    {

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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListImage = new System.Windows.Forms.ImageList(this.components);
            this.BarPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new AltoControls.AltoButton();
            this.altoButton13 = new AltoControls.AltoButton();
            this.ConfigButton = new AltoControls.AltoButton();
            this.altoButton11 = new AltoControls.AltoButton();
            this.AlertButton = new AltoControls.AltoButton();
            this.altoButton9 = new AltoControls.AltoButton();
            this.ReportButton = new AltoControls.AltoButton();
            this.altoButton7 = new AltoControls.AltoButton();
            this.MapButton = new AltoControls.AltoButton();
            this.altoButton5 = new AltoControls.AltoButton();
            this.ScannerButton = new AltoControls.AltoButton();
            this.altoButton3 = new AltoControls.AltoButton();
            this.InventoryButton = new AltoControls.AltoButton();
            this.altoButton2 = new AltoControls.AltoButton();
            this.InicioButton = new AltoControls.AltoButton();
            this.PanelVisualizer = new System.Windows.Forms.Panel();
            this.BarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListImage
            // 
            this.ListImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListImage.ImageStream")));
            this.ListImage.TransparentColor = System.Drawing.Color.Transparent;
            this.ListImage.Images.SetKeyName(0, "DefaultDevice.png");
            this.ListImage.Images.SetKeyName(1, "Device-computer-icon.png");
            this.ListImage.Images.SetKeyName(2, "printer.png");
            this.ListImage.Images.SetKeyName(3, "Switch.png");
            this.ListImage.Images.SetKeyName(4, "e14894d1b443ee21cbb0e6f94eb71b71.png");
            this.ListImage.Images.SetKeyName(5, "wireless-access-point-icon-29.jpg");
            // 
            // BarPanel
            // 
            this.BarPanel.Controls.Add(this.ExitButton);
            this.BarPanel.Controls.Add(this.altoButton13);
            this.BarPanel.Controls.Add(this.ConfigButton);
            this.BarPanel.Controls.Add(this.altoButton11);
            this.BarPanel.Controls.Add(this.AlertButton);
            this.BarPanel.Controls.Add(this.altoButton9);
            this.BarPanel.Controls.Add(this.ReportButton);
            this.BarPanel.Controls.Add(this.altoButton7);
            this.BarPanel.Controls.Add(this.MapButton);
            this.BarPanel.Controls.Add(this.altoButton5);
            this.BarPanel.Controls.Add(this.ScannerButton);
            this.BarPanel.Controls.Add(this.altoButton3);
            this.BarPanel.Controls.Add(this.InventoryButton);
            this.BarPanel.Controls.Add(this.altoButton2);
            this.BarPanel.Controls.Add(this.InicioButton);
            this.BarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarPanel.Location = new System.Drawing.Point(20, 60);
            this.BarPanel.Name = "BarPanel";
            this.BarPanel.Size = new System.Drawing.Size(97, 713);
            this.BarPanel.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.ExitButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Inactive1 = System.Drawing.Color.Transparent;
            this.ExitButton.Inactive2 = System.Drawing.Color.Transparent;
            this.ExitButton.Location = new System.Drawing.Point(0, 280);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Radius = 10;
            this.ExitButton.Size = new System.Drawing.Size(97, 30);
            this.ExitButton.Stroke = false;
            this.ExitButton.StrokeColor = System.Drawing.Color.Gray;
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Sair";
            this.ExitButton.Transparency = false;
            this.ExitButton.Click += new System.EventHandler(this.altoButton16_Click);
            // 
            // altoButton13
            // 
            this.altoButton13.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton13.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton13.BackColor = System.Drawing.Color.Transparent;
            this.altoButton13.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton13.Dock = System.Windows.Forms.DockStyle.Top;
            this.altoButton13.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton13.ForeColor = System.Drawing.Color.White;
            this.altoButton13.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton13.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton13.Location = new System.Drawing.Point(0, 270);
            this.altoButton13.Name = "altoButton13";
            this.altoButton13.Radius = 10;
            this.altoButton13.Size = new System.Drawing.Size(97, 10);
            this.altoButton13.Stroke = false;
            this.altoButton13.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton13.TabIndex = 13;
            this.altoButton13.Transparency = false;
            this.altoButton13.Visible = false;
            // 
            // ConfigButton
            // 
            this.ConfigButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.ConfigButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.ConfigButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfigButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfigButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConfigButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.ConfigButton.ForeColor = System.Drawing.Color.White;
            this.ConfigButton.Inactive1 = System.Drawing.Color.Transparent;
            this.ConfigButton.Inactive2 = System.Drawing.Color.Transparent;
            this.ConfigButton.Location = new System.Drawing.Point(0, 240);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Radius = 10;
            this.ConfigButton.Size = new System.Drawing.Size(97, 30);
            this.ConfigButton.Stroke = false;
            this.ConfigButton.StrokeColor = System.Drawing.Color.Gray;
            this.ConfigButton.TabIndex = 12;
            this.ConfigButton.Text = "Configurações";
            this.ConfigButton.Transparency = false;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // altoButton11
            // 
            this.altoButton11.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton11.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton11.BackColor = System.Drawing.Color.Transparent;
            this.altoButton11.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton11.Dock = System.Windows.Forms.DockStyle.Top;
            this.altoButton11.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton11.ForeColor = System.Drawing.Color.White;
            this.altoButton11.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton11.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton11.Location = new System.Drawing.Point(0, 230);
            this.altoButton11.Name = "altoButton11";
            this.altoButton11.Radius = 10;
            this.altoButton11.Size = new System.Drawing.Size(97, 10);
            this.altoButton11.Stroke = false;
            this.altoButton11.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton11.TabIndex = 11;
            this.altoButton11.Transparency = false;
            this.altoButton11.Visible = false;
            // 
            // AlertButton
            // 
            this.AlertButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.AlertButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.AlertButton.BackColor = System.Drawing.Color.Transparent;
            this.AlertButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AlertButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlertButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.AlertButton.ForeColor = System.Drawing.Color.White;
            this.AlertButton.Inactive1 = System.Drawing.Color.Transparent;
            this.AlertButton.Inactive2 = System.Drawing.Color.Transparent;
            this.AlertButton.Location = new System.Drawing.Point(0, 200);
            this.AlertButton.Name = "AlertButton";
            this.AlertButton.Radius = 10;
            this.AlertButton.Size = new System.Drawing.Size(97, 30);
            this.AlertButton.Stroke = false;
            this.AlertButton.StrokeColor = System.Drawing.Color.Gray;
            this.AlertButton.TabIndex = 10;
            this.AlertButton.Text = "Alertas";
            this.AlertButton.Transparency = false;
            this.AlertButton.Click += new System.EventHandler(this.AlertButton_Click);
            // 
            // altoButton9
            // 
            this.altoButton9.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton9.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton9.BackColor = System.Drawing.Color.Transparent;
            this.altoButton9.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.altoButton9.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton9.ForeColor = System.Drawing.Color.White;
            this.altoButton9.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton9.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton9.Location = new System.Drawing.Point(0, 190);
            this.altoButton9.Name = "altoButton9";
            this.altoButton9.Radius = 10;
            this.altoButton9.Size = new System.Drawing.Size(97, 10);
            this.altoButton9.Stroke = false;
            this.altoButton9.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton9.TabIndex = 9;
            this.altoButton9.Transparency = false;
            this.altoButton9.Visible = false;
            // 
            // ReportButton
            // 
            this.ReportButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.ReportButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.ReportButton.BackColor = System.Drawing.Color.Transparent;
            this.ReportButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ReportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.Inactive1 = System.Drawing.Color.Transparent;
            this.ReportButton.Inactive2 = System.Drawing.Color.Transparent;
            this.ReportButton.Location = new System.Drawing.Point(0, 160);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Radius = 10;
            this.ReportButton.Size = new System.Drawing.Size(97, 30);
            this.ReportButton.Stroke = false;
            this.ReportButton.StrokeColor = System.Drawing.Color.Gray;
            this.ReportButton.TabIndex = 8;
            this.ReportButton.Text = "Relatórios";
            this.ReportButton.Transparency = false;
            this.ReportButton.Click += new System.EventHandler(this.altoButton10_Click);
            // 
            // altoButton7
            // 
            this.altoButton7.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton7.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton7.BackColor = System.Drawing.Color.Transparent;
            this.altoButton7.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.altoButton7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton7.ForeColor = System.Drawing.Color.White;
            this.altoButton7.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton7.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton7.Location = new System.Drawing.Point(0, 150);
            this.altoButton7.Name = "altoButton7";
            this.altoButton7.Radius = 10;
            this.altoButton7.Size = new System.Drawing.Size(97, 10);
            this.altoButton7.Stroke = false;
            this.altoButton7.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton7.TabIndex = 7;
            this.altoButton7.Transparency = false;
            this.altoButton7.Visible = false;
            // 
            // MapButton
            // 
            this.MapButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.MapButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.MapButton.BackColor = System.Drawing.Color.Transparent;
            this.MapButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.MapButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MapButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.MapButton.ForeColor = System.Drawing.Color.White;
            this.MapButton.Inactive1 = System.Drawing.Color.Transparent;
            this.MapButton.Inactive2 = System.Drawing.Color.Transparent;
            this.MapButton.Location = new System.Drawing.Point(0, 120);
            this.MapButton.Name = "MapButton";
            this.MapButton.Radius = 10;
            this.MapButton.Size = new System.Drawing.Size(97, 30);
            this.MapButton.Stroke = false;
            this.MapButton.StrokeColor = System.Drawing.Color.Gray;
            this.MapButton.TabIndex = 6;
            this.MapButton.Text = "Mapa";
            this.MapButton.Transparency = false;
            this.MapButton.Click += new System.EventHandler(this.altoButton8_Click);
            // 
            // altoButton5
            // 
            this.altoButton5.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton5.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton5.BackColor = System.Drawing.Color.Transparent;
            this.altoButton5.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.altoButton5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton5.ForeColor = System.Drawing.Color.White;
            this.altoButton5.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton5.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton5.Location = new System.Drawing.Point(0, 110);
            this.altoButton5.Name = "altoButton5";
            this.altoButton5.Radius = 10;
            this.altoButton5.Size = new System.Drawing.Size(97, 10);
            this.altoButton5.Stroke = false;
            this.altoButton5.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton5.TabIndex = 5;
            this.altoButton5.Transparency = false;
            this.altoButton5.Visible = false;
            // 
            // ScannerButton
            // 
            this.ScannerButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.ScannerButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.ScannerButton.BackColor = System.Drawing.Color.Transparent;
            this.ScannerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ScannerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScannerButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.ScannerButton.ForeColor = System.Drawing.Color.White;
            this.ScannerButton.Inactive1 = System.Drawing.Color.Transparent;
            this.ScannerButton.Inactive2 = System.Drawing.Color.Transparent;
            this.ScannerButton.Location = new System.Drawing.Point(0, 80);
            this.ScannerButton.Name = "ScannerButton";
            this.ScannerButton.Radius = 10;
            this.ScannerButton.Size = new System.Drawing.Size(97, 30);
            this.ScannerButton.Stroke = false;
            this.ScannerButton.StrokeColor = System.Drawing.Color.Gray;
            this.ScannerButton.TabIndex = 4;
            this.ScannerButton.Text = "Scanner";
            this.ScannerButton.Transparency = false;
            this.ScannerButton.Click += new System.EventHandler(this.altoButton6_Click);
            // 
            // altoButton3
            // 
            this.altoButton3.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton3.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton3.BackColor = System.Drawing.Color.Transparent;
            this.altoButton3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.altoButton3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton3.ForeColor = System.Drawing.Color.White;
            this.altoButton3.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton3.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton3.Location = new System.Drawing.Point(0, 70);
            this.altoButton3.Name = "altoButton3";
            this.altoButton3.Radius = 10;
            this.altoButton3.Size = new System.Drawing.Size(97, 10);
            this.altoButton3.Stroke = false;
            this.altoButton3.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton3.TabIndex = 3;
            this.altoButton3.Transparency = false;
            this.altoButton3.Visible = false;
            // 
            // InventoryButton
            // 
            this.InventoryButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.InventoryButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.InventoryButton.BackColor = System.Drawing.Color.Transparent;
            this.InventoryButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.InventoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.InventoryButton.ForeColor = System.Drawing.Color.White;
            this.InventoryButton.Inactive1 = System.Drawing.Color.Transparent;
            this.InventoryButton.Inactive2 = System.Drawing.Color.Transparent;
            this.InventoryButton.Location = new System.Drawing.Point(0, 40);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Radius = 10;
            this.InventoryButton.Size = new System.Drawing.Size(97, 30);
            this.InventoryButton.Stroke = false;
            this.InventoryButton.StrokeColor = System.Drawing.Color.Gray;
            this.InventoryButton.TabIndex = 2;
            this.InventoryButton.Text = "Inventário";
            this.InventoryButton.Transparency = false;
            this.InventoryButton.Click += new System.EventHandler(this.altoButton4_Click);
            // 
            // altoButton2
            // 
            this.altoButton2.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton2.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton2.BackColor = System.Drawing.Color.Transparent;
            this.altoButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.altoButton2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.altoButton2.ForeColor = System.Drawing.Color.White;
            this.altoButton2.Inactive1 = System.Drawing.Color.Transparent;
            this.altoButton2.Inactive2 = System.Drawing.Color.Transparent;
            this.altoButton2.Location = new System.Drawing.Point(0, 30);
            this.altoButton2.Name = "altoButton2";
            this.altoButton2.Radius = 10;
            this.altoButton2.Size = new System.Drawing.Size(97, 10);
            this.altoButton2.Stroke = false;
            this.altoButton2.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton2.TabIndex = 1;
            this.altoButton2.Transparency = false;
            this.altoButton2.Visible = false;
            // 
            // InicioButton
            // 
            this.InicioButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.InicioButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.InicioButton.BackColor = System.Drawing.Color.Transparent;
            this.InicioButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.InicioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InicioButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.InicioButton.ForeColor = System.Drawing.Color.White;
            this.InicioButton.Inactive1 = System.Drawing.Color.Transparent;
            this.InicioButton.Inactive2 = System.Drawing.Color.Transparent;
            this.InicioButton.Location = new System.Drawing.Point(0, 0);
            this.InicioButton.Name = "InicioButton";
            this.InicioButton.Radius = 10;
            this.InicioButton.Size = new System.Drawing.Size(97, 30);
            this.InicioButton.Stroke = false;
            this.InicioButton.StrokeColor = System.Drawing.Color.Gray;
            this.InicioButton.TabIndex = 0;
            this.InicioButton.Text = "Inicio";
            this.InicioButton.Transparency = false;
            this.InicioButton.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // PanelVisualizer
            // 
            this.PanelVisualizer.AutoScroll = true;
            this.PanelVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelVisualizer.Location = new System.Drawing.Point(117, 60);
            this.PanelVisualizer.Name = "PanelVisualizer";
            this.PanelVisualizer.Size = new System.Drawing.Size(1323, 713);
            this.PanelVisualizer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 793);
            this.Controls.Add(this.PanelVisualizer);
            this.Controls.Add(this.BarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Tnetwork Administrator";
            this.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components;
        public ImageList ListImage;
        private Panel BarPanel;
        private AltoControls.AltoButton altoButton11;
        private AltoControls.AltoButton AlertButton;
        private AltoControls.AltoButton altoButton9;
        private AltoControls.AltoButton ReportButton;
        private AltoControls.AltoButton altoButton7;
        private AltoControls.AltoButton MapButton;
        private AltoControls.AltoButton altoButton5;
        private AltoControls.AltoButton ScannerButton;
        private AltoControls.AltoButton altoButton3;
        private AltoControls.AltoButton InventoryButton;
        private AltoControls.AltoButton altoButton2;
        private AltoControls.AltoButton InicioButton;
        private AltoControls.AltoButton ExitButton;
        private AltoControls.AltoButton altoButton13;
        private AltoControls.AltoButton ConfigButton;
        private Panel PanelVisualizer;
    }
}

