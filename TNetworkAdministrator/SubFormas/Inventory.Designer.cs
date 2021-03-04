
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verificarStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroButton1 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.Texto = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.metroComboBox1 = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroComboBox2 = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.metroComboBox3 = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.metroComboBox4 = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 444);
            this.panel1.TabIndex = 0;
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
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.Location = new System.Drawing.Point(433, 90);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 22);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Pesquisar";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseVisualStyleBackColor = false;
            // 
            // Texto
            // 
            this.Texto.Lines = new string[0];
            this.Texto.Location = new System.Drawing.Point(39, 90);
            this.Texto.MaxLength = 32767;
            this.Texto.Name = "Texto";
            this.Texto.PasswordChar = '\0';
            this.Texto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Texto.SelectedText = "";
            this.Texto.Size = new System.Drawing.Size(379, 22);
            this.Texto.TabIndex = 3;
            this.Texto.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(135, 158);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtros:";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(135, 209);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 6;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Items.AddRange(new object[] {
            "Crescente\t",
            "Decrescente"});
            this.metroComboBox3.Location = new System.Drawing.Point(412, 158);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox3.TabIndex = 7;
            this.metroComboBox3.UseSelectable = true;
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 23;
            this.metroComboBox4.Items.AddRange(new object[] {
            "Crescente\t",
            "Decrescente"});
            this.metroComboBox4.Location = new System.Drawing.Point(412, 209);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox4.TabIndex = 8;
            this.metroComboBox4.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(343, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(343, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ip:";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 717);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroComboBox4);
            this.Controls.Add(this.metroComboBox3);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.panel1);
            this.Name = "Inventory";
            this.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton1;
        private Wisder.W3Common.WMetroControl.Controls.MetroTextBox Texto;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label1;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox metroComboBox2;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox metroComboBox3;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox metroComboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem verificarStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
    }
}