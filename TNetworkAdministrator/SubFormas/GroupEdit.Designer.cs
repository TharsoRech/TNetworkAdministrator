﻿
namespace TNetworkAdministrator.SubFormas
{
    partial class GroupEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupEdit));
            this.metroCheckBox1 = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.TimeOff = new System.Windows.Forms.DateTimePicker();
            this.TimeON = new System.Windows.Forms.DateTimePicker();
            this.Saturday = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.Fryday = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.Thursday = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.Wednesday = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.Tuesday = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.Monday = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.Sunday = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MonitoringCheck = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ProcessorUseCheck = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.NetworkUseCheckl = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.LostPackageCheck = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.StatusCheck = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.InfoText = new System.Windows.Forms.Label();
            this.Descricaotext = new System.Windows.Forms.Label();
            this.Descricao = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.metroButton2 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.SaveButton = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NameText = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.DevicesList = new Wisder.W3Common.WMetroControl.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Prioridades = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MonitoringCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesList)).BeginInit();
            this.SuspendLayout();
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(35, 255);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(316, 15);
            this.metroCheckBox1.TabIndex = 122;
            this.metroCheckBox1.Text = "Usar Monitoramento padrão para todos itens do Grupo:";
            this.metroCheckBox1.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            // 
            // TimeOff
            // 
            this.TimeOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeOff.Location = new System.Drawing.Point(236, 610);
            this.TimeOff.Name = "TimeOff";
            this.TimeOff.Size = new System.Drawing.Size(48, 20);
            this.TimeOff.TabIndex = 121;
            // 
            // TimeON
            // 
            this.TimeON.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeON.Location = new System.Drawing.Point(97, 611);
            this.TimeON.Name = "TimeON";
            this.TimeON.Size = new System.Drawing.Size(48, 20);
            this.TimeON.TabIndex = 120;
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Location = new System.Drawing.Point(246, 544);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(62, 15);
            this.Saturday.TabIndex = 119;
            this.Saturday.Text = "Sábado";
            this.Saturday.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Saturday.UseSelectable = true;
            this.Saturday.UseVisualStyleBackColor = true;
            // 
            // Fryday
            // 
            this.Fryday.AutoSize = true;
            this.Fryday.Location = new System.Drawing.Point(135, 544);
            this.Fryday.Name = "Fryday";
            this.Fryday.Size = new System.Drawing.Size(81, 15);
            this.Fryday.TabIndex = 118;
            this.Fryday.Text = "Sexta-Feira";
            this.Fryday.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Fryday.UseSelectable = true;
            this.Fryday.UseVisualStyleBackColor = true;
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Location = new System.Drawing.Point(32, 542);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(89, 15);
            this.Thursday.TabIndex = 117;
            this.Thursday.Text = "Quinta-Feira";
            this.Thursday.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Thursday.UseSelectable = true;
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Location = new System.Drawing.Point(242, 510);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(89, 15);
            this.Wednesday.TabIndex = 116;
            this.Wednesday.Text = "Quarta-Feira";
            this.Wednesday.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Wednesday.UseSelectable = true;
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Location = new System.Drawing.Point(136, 510);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(80, 15);
            this.Tuesday.TabIndex = 115;
            this.Tuesday.Text = "Terça-Feira";
            this.Tuesday.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Tuesday.UseSelectable = true;
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Location = new System.Drawing.Point(32, 510);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(99, 15);
            this.Monday.TabIndex = 114;
            this.Monday.Text = "Segunda-Feira";
            this.Monday.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Monday.UseSelectable = true;
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Location = new System.Drawing.Point(246, 478);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(73, 15);
            this.Sunday.TabIndex = 113;
            this.Sunday.Text = "Domingo";
            this.Sunday.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Sunday.UseSelectable = true;
            this.Sunday.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(152, 609);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 19);
            this.label14.TabIndex = 112;
            this.label14.Text = "Até a Hora:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(31, 610);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 19);
            this.label13.TabIndex = 111;
            this.label13.Text = "Da hora:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(31, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 19);
            this.label12.TabIndex = 110;
            this.label12.Text = "Fazer Monitoramento nos dias:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 29);
            this.label10.TabIndex = 109;
            this.label10.Text = "Monitoramento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(37, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 19);
            this.label11.TabIndex = 108;
            this.label11.Text = "Monitoramento a cada(Min):";
            // 
            // MonitoringCheck
            // 
            this.MonitoringCheck.Location = new System.Drawing.Point(240, 575);
            this.MonitoringCheck.Name = "MonitoringCheck";
            this.MonitoringCheck.Size = new System.Drawing.Size(33, 20);
            this.MonitoringCheck.TabIndex = 107;
            this.MonitoringCheck.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 46);
            this.label9.TabIndex = 106;
            this.label9.Text = "Assinale os tipos de Monitoramento \r\nque você deseja para esse dispositivo:";
            // 
            // ProcessorUseCheck
            // 
            this.ProcessorUseCheck.AutoSize = true;
            this.ProcessorUseCheck.Location = new System.Drawing.Point(240, 438);
            this.ProcessorUseCheck.Name = "ProcessorUseCheck";
            this.ProcessorUseCheck.Size = new System.Drawing.Size(127, 15);
            this.ProcessorUseCheck.TabIndex = 105;
            this.ProcessorUseCheck.Text = "Uso do Processador";
            this.ProcessorUseCheck.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.ProcessorUseCheck.UseSelectable = true;
            this.ProcessorUseCheck.UseVisualStyleBackColor = true;
            // 
            // NetworkUseCheckl
            // 
            this.NetworkUseCheckl.AutoSize = true;
            this.NetworkUseCheckl.Location = new System.Drawing.Point(38, 438);
            this.NetworkUseCheckl.Name = "NetworkUseCheckl";
            this.NetworkUseCheckl.Size = new System.Drawing.Size(88, 15);
            this.NetworkUseCheckl.TabIndex = 104;
            this.NetworkUseCheckl.Text = "Uso da Rede";
            this.NetworkUseCheckl.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.NetworkUseCheckl.UseSelectable = true;
            this.NetworkUseCheckl.UseVisualStyleBackColor = true;
            // 
            // LostPackageCheck
            // 
            this.LostPackageCheck.AutoSize = true;
            this.LostPackageCheck.Location = new System.Drawing.Point(240, 400);
            this.LostPackageCheck.Name = "LostPackageCheck";
            this.LostPackageCheck.Size = new System.Drawing.Size(107, 15);
            this.LostPackageCheck.TabIndex = 103;
            this.LostPackageCheck.Text = "Perca de Pacote";
            this.LostPackageCheck.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.LostPackageCheck.UseSelectable = true;
            this.LostPackageCheck.UseVisualStyleBackColor = true;
            // 
            // StatusCheck
            // 
            this.StatusCheck.AutoSize = true;
            this.StatusCheck.Location = new System.Drawing.Point(38, 400);
            this.StatusCheck.Name = "StatusCheck";
            this.StatusCheck.Size = new System.Drawing.Size(178, 15);
            this.StatusCheck.TabIndex = 102;
            this.StatusCheck.Text = "Verificar Status do Dispositivo";
            this.StatusCheck.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.StatusCheck.UseSelectable = true;
            this.StatusCheck.UseVisualStyleBackColor = true;
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.InfoText.Location = new System.Drawing.Point(27, 60);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(261, 29);
            this.InfoText.TabIndex = 99;
            this.InfoText.Text = "Informações Do Grupo:";
            // 
            // Descricaotext
            // 
            this.Descricaotext.AutoSize = true;
            this.Descricaotext.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricaotext.ForeColor = System.Drawing.Color.White;
            this.Descricaotext.Location = new System.Drawing.Point(31, 149);
            this.Descricaotext.Name = "Descricaotext";
            this.Descricaotext.Size = new System.Drawing.Size(90, 23);
            this.Descricaotext.TabIndex = 98;
            this.Descricaotext.Text = "Descrição:";
            // 
            // Descricao
            // 
            this.Descricao.Lines = new string[0];
            this.Descricao.Location = new System.Drawing.Point(131, 151);
            this.Descricao.MaxLength = 32767;
            this.Descricao.Multiline = true;
            this.Descricao.Name = "Descricao";
            this.Descricao.PasswordChar = '\0';
            this.Descricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Descricao.SelectedText = "";
            this.Descricao.Size = new System.Drawing.Size(328, 41);
            this.Descricao.TabIndex = 97;
            this.Descricao.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Descricao.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton2.Location = new System.Drawing.Point(428, 612);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(100, 22);
            this.metroButton2.TabIndex = 124;
            this.metroButton2.Text = "Cancelar";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseVisualStyleBackColor = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveButton.Location = new System.Drawing.Point(556, 612);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 22);
            this.SaveButton.TabIndex = 123;
            this.SaveButton.Text = "Salvar";
            this.SaveButton.UseCustomBackColor = true;
            this.SaveButton.UseSelectable = true;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 125;
            this.label1.Text = "Nome:";
            // 
            // NameText
            // 
            this.NameText.Lines = new string[0];
            this.NameText.Location = new System.Drawing.Point(133, 111);
            this.NameText.MaxLength = 32767;
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameText.SelectedText = "";
            this.NameText.Size = new System.Drawing.Size(326, 24);
            this.NameText.TabIndex = 126;
            this.NameText.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.NameText.UseSelectable = true;
            // 
            // DevicesList
            // 
            this.DevicesList.AllowUserToResizeRows = false;
            this.DevicesList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DevicesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DevicesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DevicesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DevicesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DevicesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DevicesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DevicesList.DefaultCellStyle = dataGridViewCellStyle5;
            this.DevicesList.EnableHeadersVisualStyles = false;
            this.DevicesList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DevicesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DevicesList.Location = new System.Drawing.Point(388, 336);
            this.DevicesList.Name = "DevicesList";
            this.DevicesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DevicesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DevicesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DevicesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DevicesList.Size = new System.Drawing.Size(304, 257);
            this.DevicesList.TabIndex = 127;
            this.DevicesList.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dispositivo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(383, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 29);
            this.label2.TabIndex = 128;
            this.label2.Text = "Dispositivos do Grupo:";
            // 
            // Prioridades
            // 
            this.Prioridades.FormattingEnabled = true;
            this.Prioridades.ItemHeight = 23;
            this.Prioridades.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta",
            "Critica"});
            this.Prioridades.Location = new System.Drawing.Point(131, 211);
            this.Prioridades.Name = "Prioridades";
            this.Prioridades.Size = new System.Drawing.Size(132, 29);
            this.Prioridades.TabIndex = 101;
            this.Prioridades.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Prioridades.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 129;
            this.label3.Text = "Prioridade:";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.ForeColor = System.Drawing.Color.White;
            this.Id.Location = new System.Drawing.Point(64, 66);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(31, 23);
            this.Id.TabIndex = 130;
            this.Id.Text = "Id:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(645, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 131;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // GroupEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DevicesList);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.TimeOff);
            this.Controls.Add(this.TimeON);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Fryday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MonitoringCheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProcessorUseCheck);
            this.Controls.Add(this.NetworkUseCheckl);
            this.Controls.Add(this.LostPackageCheck);
            this.Controls.Add(this.StatusCheck);
            this.Controls.Add(this.Prioridades);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.Descricaotext);
            this.Controls.Add(this.Descricao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupEdit";
            this.Text = "Grupo";
            this.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.GroupEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MonitoringCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox metroCheckBox1;
        private System.Windows.Forms.DateTimePicker TimeOff;
        private System.Windows.Forms.DateTimePicker TimeON;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox Saturday;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox Fryday;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox Thursday;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox Wednesday;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox Tuesday;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox Monday;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox Sunday;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown MonitoringCheck;
        private System.Windows.Forms.Label label9;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox ProcessorUseCheck;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox NetworkUseCheckl;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox LostPackageCheck;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox StatusCheck;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Label Descricaotext;
        private Wisder.W3Common.WMetroControl.Controls.MetroTextBox Descricao;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton2;
        public Wisder.W3Common.WMetroControl.Controls.MetroButton SaveButton;
        private System.Windows.Forms.Label label1;
        public Wisder.W3Common.WMetroControl.Controls.MetroTextBox NameText;
        private Wisder.W3Common.WMetroControl.Controls.MetroGrid DevicesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.Label label2;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox Prioridades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button button1;
    }
}