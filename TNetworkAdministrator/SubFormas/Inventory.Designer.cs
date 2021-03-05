﻿
namespace TNetworkAdministrator.SubFormas
{
    partial class Inventory
    {

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verificarStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1 = new Wisder.W3Common.WMetroControl.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.IpChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProrityChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.ListofDevices = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ManufactuerChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.StatusChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupsChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.Texto = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.metroButton1 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Prioridades = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.metroButton2 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.PrioridadePadrao = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.InfoText = new System.Windows.Forms.Label();
            this.Descricaotext = new System.Windows.Forms.Label();
            this.Descricao = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.metroButton5 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroButton4 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroButton3 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.Scaneados = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarStatusToolStripMenuItem,
            this.gerarRelatórioToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // verificarStatusToolStripMenuItem
            // 
            this.verificarStatusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verificarStatusToolStripMenuItem.Image")));
            this.verificarStatusToolStripMenuItem.Name = "verificarStatusToolStripMenuItem";
            this.verificarStatusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verificarStatusToolStripMenuItem.Text = "Verificar Status";
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gerarRelatórioToolStripMenuItem.Image")));
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gerarRelatórioToolStripMenuItem.Text = "Gerar Relatório";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerToolStripMenuItem.Image")));
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Padding = new System.Drawing.Point(6, 8);
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(998, 637);
            this.metroTabControl1.TabIndex = 13;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.NameChoose);
            this.tabPage1.Controls.Add(this.IpChoose);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ProrityChoose);
            this.tabPage1.Controls.Add(this.ListofDevices);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ManufactuerChoose);
            this.tabPage1.Controls.Add(this.StatusChoose);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.GroupsChoose);
            this.tabPage1.Controls.Add(this.Texto);
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dispostivos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(339, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(123, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ip:";
            // 
            // NameChoose
            // 
            this.NameChoose.FormattingEnabled = true;
            this.NameChoose.ItemHeight = 23;
            this.NameChoose.Items.AddRange(new object[] {
            "Crescente\t",
            "Decrescente"});
            this.NameChoose.Location = new System.Drawing.Point(406, 66);
            this.NameChoose.Name = "NameChoose";
            this.NameChoose.Size = new System.Drawing.Size(121, 29);
            this.NameChoose.TabIndex = 28;
            this.NameChoose.UseSelectable = true;
            // 
            // IpChoose
            // 
            this.IpChoose.FormattingEnabled = true;
            this.IpChoose.ItemHeight = 23;
            this.IpChoose.Items.AddRange(new object[] {
            "Crescente\t",
            "Decrescente"});
            this.IpChoose.Location = new System.Drawing.Point(160, 66);
            this.IpChoose.Name = "IpChoose";
            this.IpChoose.Size = new System.Drawing.Size(121, 29);
            this.IpChoose.TabIndex = 27;
            this.IpChoose.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(753, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Prioridade:";
            // 
            // ProrityChoose
            // 
            this.ProrityChoose.FormattingEnabled = true;
            this.ProrityChoose.ItemHeight = 23;
            this.ProrityChoose.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta",
            "Critica"});
            this.ProrityChoose.Location = new System.Drawing.Point(854, 13);
            this.ProrityChoose.Name = "ProrityChoose";
            this.ProrityChoose.Size = new System.Drawing.Size(121, 29);
            this.ProrityChoose.TabIndex = 25;
            this.ProrityChoose.UseSelectable = true;
            // 
            // ListofDevices
            // 
            this.ListofDevices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListofDevices.Location = new System.Drawing.Point(3, 119);
            this.ListofDevices.Name = "ListofDevices";
            this.ListofDevices.Size = new System.Drawing.Size(984, 473);
            this.ListofDevices.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(305, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fabricante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(548, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(91, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Grupo:";
            // 
            // ManufactuerChoose
            // 
            this.ManufactuerChoose.FormattingEnabled = true;
            this.ManufactuerChoose.ItemHeight = 23;
            this.ManufactuerChoose.Location = new System.Drawing.Point(406, 13);
            this.ManufactuerChoose.Name = "ManufactuerChoose";
            this.ManufactuerChoose.Size = new System.Drawing.Size(121, 29);
            this.ManufactuerChoose.TabIndex = 19;
            this.ManufactuerChoose.UseSelectable = true;
            // 
            // StatusChoose
            // 
            this.StatusChoose.FormattingEnabled = true;
            this.StatusChoose.ItemHeight = 23;
            this.StatusChoose.Items.AddRange(new object[] {
            "OK",
            "Alerta",
            "Critico"});
            this.StatusChoose.Location = new System.Drawing.Point(617, 13);
            this.StatusChoose.Name = "StatusChoose";
            this.StatusChoose.Size = new System.Drawing.Size(121, 29);
            this.StatusChoose.TabIndex = 18;
            this.StatusChoose.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filtros:";
            // 
            // GroupsChoose
            // 
            this.GroupsChoose.FormattingEnabled = true;
            this.GroupsChoose.ItemHeight = 23;
            this.GroupsChoose.Location = new System.Drawing.Point(160, 13);
            this.GroupsChoose.Name = "GroupsChoose";
            this.GroupsChoose.Size = new System.Drawing.Size(121, 29);
            this.GroupsChoose.TabIndex = 16;
            this.GroupsChoose.UseSelectable = true;
            // 
            // Texto
            // 
            this.Texto.Lines = new string[0];
            this.Texto.Location = new System.Drawing.Point(594, 60);
            this.Texto.MaxLength = 32767;
            this.Texto.Name = "Texto";
            this.Texto.PasswordChar = '\0';
            this.Texto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Texto.SelectedText = "";
            this.Texto.Size = new System.Drawing.Size(379, 22);
            this.Texto.TabIndex = 15;
            this.Texto.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.Location = new System.Drawing.Point(873, 91);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 22);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Pesquisar";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Prioridades);
            this.tabPage2.Controls.Add(this.metroButton2);
            this.tabPage2.Controls.Add(this.PrioridadePadrao);
            this.tabPage2.Controls.Add(this.InfoText);
            this.tabPage2.Controls.Add(this.Descricaotext);
            this.tabPage2.Controls.Add(this.Descricao);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.metroButton5);
            this.tabPage2.Controls.Add(this.metroButton4);
            this.tabPage2.Controls.Add(this.metroButton3);
            this.tabPage2.Controls.Add(this.Scaneados);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(990, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grupos";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.Prioridades.Location = new System.Drawing.Point(837, 107);
            this.Prioridades.Name = "Prioridades";
            this.Prioridades.Size = new System.Drawing.Size(132, 29);
            this.Prioridades.TabIndex = 33;
            this.Prioridades.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton2.Location = new System.Drawing.Point(864, 152);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(105, 22);
            this.metroButton2.TabIndex = 32;
            this.metroButton2.Text = "Salvar Alterações";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseVisualStyleBackColor = false;
            // 
            // PrioridadePadrao
            // 
            this.PrioridadePadrao.AutoSize = true;
            this.PrioridadePadrao.Location = new System.Drawing.Point(543, 114);
            this.PrioridadePadrao.Name = "PrioridadePadrao";
            this.PrioridadePadrao.Size = new System.Drawing.Size(286, 15);
            this.PrioridadePadrao.TabIndex = 31;
            this.PrioridadePadrao.Text = "Usar Prioridade padrão para todos itens do Grupo:";
            this.PrioridadePadrao.UseSelectable = true;
            this.PrioridadePadrao.UseVisualStyleBackColor = true;
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText.Location = new System.Drawing.Point(540, 14);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(221, 25);
            this.InfoText.TabIndex = 30;
            this.InfoText.Text = "Informações Do Grupo:";
            // 
            // Descricaotext
            // 
            this.Descricaotext.AutoSize = true;
            this.Descricaotext.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricaotext.ForeColor = System.Drawing.Color.Black;
            this.Descricaotext.Location = new System.Drawing.Point(541, 58);
            this.Descricaotext.Name = "Descricaotext";
            this.Descricaotext.Size = new System.Drawing.Size(90, 23);
            this.Descricaotext.TabIndex = 29;
            this.Descricaotext.Text = "Descrição:";
            // 
            // Descricao
            // 
            this.Descricao.Lines = new string[0];
            this.Descricao.Location = new System.Drawing.Point(641, 60);
            this.Descricao.MaxLength = 32767;
            this.Descricao.Multiline = true;
            this.Descricao.Name = "Descricao";
            this.Descricao.PasswordChar = '\0';
            this.Descricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Descricao.SelectedText = "";
            this.Descricao.Size = new System.Drawing.Size(328, 41);
            this.Descricao.TabIndex = 28;
            this.Descricao.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Grupos:";
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton5.Location = new System.Drawing.Point(324, 46);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(105, 22);
            this.metroButton5.TabIndex = 26;
            this.metroButton5.Text = "Adicionar";
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.UseVisualStyleBackColor = false;
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton4.Location = new System.Drawing.Point(324, 130);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(105, 22);
            this.metroButton4.TabIndex = 25;
            this.metroButton4.Text = "Limpar Lista";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.UseVisualStyleBackColor = false;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton3.Location = new System.Drawing.Point(324, 90);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(105, 22);
            this.metroButton3.TabIndex = 24;
            this.metroButton3.Text = "Remover";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseVisualStyleBackColor = false;
            // 
            // Scaneados
            // 
            this.Scaneados.Location = new System.Drawing.Point(15, 46);
            this.Scaneados.Name = "Scaneados";
            this.Scaneados.Size = new System.Drawing.Size(291, 515);
            this.Scaneados.TabIndex = 13;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 717);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Inventory";
            this.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Inventário";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem verificarStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private Wisder.W3Common.WMetroControl.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox ManufactuerChoose;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox StatusChoose;
        private System.Windows.Forms.Label label1;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox GroupsChoose;
        private Wisder.W3Common.WMetroControl.Controls.MetroTextBox Texto;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TreeView Scaneados;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton5;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton4;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Label Descricaotext;
        private Wisder.W3Common.WMetroControl.Controls.MetroTextBox Descricao;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton2;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox PrioridadePadrao;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox Prioridades;
        private System.Windows.Forms.FlowLayoutPanel ListofDevices;
        private System.Windows.Forms.Label label5;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox ProrityChoose;
        private System.Windows.Forms.Label label7;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox NameChoose;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox IpChoose;
        private System.Windows.Forms.Label label8;
    }
}