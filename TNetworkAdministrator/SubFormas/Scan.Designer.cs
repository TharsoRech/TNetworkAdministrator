
namespace TNetworkAdministrator.SubFormas
{
    partial class Scan
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
            this.IpInicial = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.metroButton2 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.IpFinal = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Scaneados = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.ScaneamentoAutomatico = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.metroButton1 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroButton3 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroButton4 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.ProcurarPorFaixa = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.metroButton5 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroProgressBar1 = new Wisder.W3Common.WMetroControl.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // IpInicial
            // 
            this.IpInicial.Enabled = false;
            this.IpInicial.Lines = new string[0];
            this.IpInicial.Location = new System.Drawing.Point(117, 91);
            this.IpInicial.MaxLength = 32767;
            this.IpInicial.Name = "IpInicial";
            this.IpInicial.PasswordChar = '\0';
            this.IpInicial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IpInicial.SelectedText = "";
            this.IpInicial.Size = new System.Drawing.Size(189, 24);
            this.IpInicial.TabIndex = 6;
            this.IpInicial.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton2.Location = new System.Drawing.Point(265, 167);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(146, 22);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Iniciar Scaneamento";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseVisualStyleBackColor = false;
            // 
            // IpFinal
            // 
            this.IpFinal.Enabled = false;
            this.IpFinal.Lines = new string[0];
            this.IpFinal.Location = new System.Drawing.Point(410, 91);
            this.IpFinal.MaxLength = 32767;
            this.IpFinal.Name = "IpFinal";
            this.IpFinal.PasswordChar = '\0';
            this.IpFinal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IpFinal.SelectedText = "";
            this.IpFinal.Size = new System.Drawing.Size(189, 24);
            this.IpFinal.TabIndex = 8;
            this.IpFinal.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ip Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(321, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ip Final:";
            // 
            // Scaneados
            // 
            this.Scaneados.Location = new System.Drawing.Point(23, 264);
            this.Scaneados.Name = "Scaneados";
            this.Scaneados.Size = new System.Drawing.Size(291, 374);
            this.Scaneados.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Scaneados:";
            // 
            // ScaneamentoAutomatico
            // 
            this.ScaneamentoAutomatico.AutoSize = true;
            this.ScaneamentoAutomatico.Checked = true;
            this.ScaneamentoAutomatico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ScaneamentoAutomatico.Location = new System.Drawing.Point(35, 172);
            this.ScaneamentoAutomatico.Name = "ScaneamentoAutomatico";
            this.ScaneamentoAutomatico.Size = new System.Drawing.Size(204, 15);
            this.ScaneamentoAutomatico.TabIndex = 17;
            this.ScaneamentoAutomatico.Text = "Scaneamento automático da Rede";
            this.ScaneamentoAutomatico.UseSelectable = true;
            this.ScaneamentoAutomatico.UseVisualStyleBackColor = true;
            this.ScaneamentoAutomatico.CheckedChanged += new System.EventHandler(this.ScaneamentoAutomatico_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.Location = new System.Drawing.Point(325, 327);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(156, 22);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "Adicionar Selecionados";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton3.Location = new System.Drawing.Point(325, 380);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(105, 22);
            this.metroButton3.TabIndex = 19;
            this.metroButton3.Text = "Remover";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseVisualStyleBackColor = false;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton4.Location = new System.Drawing.Point(325, 424);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(105, 22);
            this.metroButton4.TabIndex = 20;
            this.metroButton4.Text = "Limpar Lista";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.UseVisualStyleBackColor = false;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // ProcurarPorFaixa
            // 
            this.ProcurarPorFaixa.AutoSize = true;
            this.ProcurarPorFaixa.Location = new System.Drawing.Point(35, 141);
            this.ProcurarPorFaixa.Name = "ProcurarPorFaixa";
            this.ProcurarPorFaixa.Size = new System.Drawing.Size(151, 15);
            this.ProcurarPorFaixa.TabIndex = 22;
            this.ProcurarPorFaixa.Text = "Procurar Por Faixa de IP:";
            this.ProcurarPorFaixa.UseSelectable = true;
            this.ProcurarPorFaixa.UseVisualStyleBackColor = true;
            this.ProcurarPorFaixa.CheckedChanged += new System.EventHandler(this.ProcurarPorFaixa_CheckedChanged);
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton5.Location = new System.Drawing.Point(325, 284);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(146, 22);
            this.metroButton5.TabIndex = 23;
            this.metroButton5.Text = "Adicionar Manualmente";
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.UseVisualStyleBackColor = false;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(23, 234);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(291, 23);
            this.metroProgressBar1.TabIndex = 24;
            this.metroProgressBar1.Value = 100;
            // 
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 661);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.ProcurarPorFaixa);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ScaneamentoAutomatico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Scaneados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IpFinal);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.IpInicial);
            this.Name = "Scan";
            this.Text = "Scan";
            this.Load += new System.EventHandler(this.Scan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisder.W3Common.WMetroControl.Controls.MetroTextBox IpInicial;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton2;
        private Wisder.W3Common.WMetroControl.Controls.MetroTextBox IpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView Scaneados;
        private System.Windows.Forms.Label label3;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox ScaneamentoAutomatico;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton1;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton3;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton4;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox ProcurarPorFaixa;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton5;
        private Wisder.W3Common.WMetroControl.Controls.MetroProgressBar metroProgressBar1;
    }
}