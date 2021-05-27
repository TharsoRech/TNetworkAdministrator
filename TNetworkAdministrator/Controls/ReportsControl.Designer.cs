
namespace TNetworkAdministrator.Controls
{
    partial class ReportsControl
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
            this.label5 = new System.Windows.Forms.Label();
            this.ProrityChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ManufactuerChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupsChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.metroProgressBar1 = new Wisder.W3Common.WMetroControl.Controls.MetroProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton2 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroButton1 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.Scaneados = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(279, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 55;
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
            this.ProrityChoose.Location = new System.Drawing.Point(380, 276);
            this.ProrityChoose.Name = "ProrityChoose";
            this.ProrityChoose.Size = new System.Drawing.Size(121, 29);
            this.ProrityChoose.TabIndex = 54;
            this.ProrityChoose.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.ProrityChoose.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Status:";
            // 
            // StatusChoose
            // 
            this.StatusChoose.FormattingEnabled = true;
            this.StatusChoose.ItemHeight = 23;
            this.StatusChoose.Items.AddRange(new object[] {
            "OK",
            "Alerta",
            "Critico"});
            this.StatusChoose.Location = new System.Drawing.Point(380, 220);
            this.StatusChoose.Name = "StatusChoose";
            this.StatusChoose.Size = new System.Drawing.Size(121, 29);
            this.StatusChoose.TabIndex = 52;
            this.StatusChoose.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.StatusChoose.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(279, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fabricante:";
            // 
            // ManufactuerChoose
            // 
            this.ManufactuerChoose.FormattingEnabled = true;
            this.ManufactuerChoose.ItemHeight = 23;
            this.ManufactuerChoose.Location = new System.Drawing.Point(380, 170);
            this.ManufactuerChoose.Name = "ManufactuerChoose";
            this.ManufactuerChoose.Size = new System.Drawing.Size(121, 29);
            this.ManufactuerChoose.TabIndex = 50;
            this.ManufactuerChoose.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.ManufactuerChoose.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "Grupo:";
            // 
            // GroupsChoose
            // 
            this.GroupsChoose.FormattingEnabled = true;
            this.GroupsChoose.ItemHeight = 23;
            this.GroupsChoose.Location = new System.Drawing.Point(380, 121);
            this.GroupsChoose.Name = "GroupsChoose";
            this.GroupsChoose.Size = new System.Drawing.Size(121, 29);
            this.GroupsChoose.TabIndex = 48;
            this.GroupsChoose.Theme = Wisder.W3Common.WMetroControl.MetroThemeStyle.Dark;
            this.GroupsChoose.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Inventário:";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(283, 395);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(249, 23);
            this.metroProgressBar1.TabIndex = 46;
            this.metroProgressBar1.Value = 100;
            this.metroProgressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Filtros:";
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton2.Location = new System.Drawing.Point(361, 350);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(140, 22);
            this.metroButton2.TabIndex = 44;
            this.metroButton2.Text = "Gerar Relatório";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseVisualStyleBackColor = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.Location = new System.Drawing.Point(71, 64);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(106, 22);
            this.metroButton1.TabIndex = 43;
            this.metroButton1.Text = "Selecionar Todos";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseVisualStyleBackColor = false;
            // 
            // Scaneados
            // 
            this.Scaneados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Scaneados.Location = new System.Drawing.Point(14, 92);
            this.Scaneados.Name = "Scaneados";
            this.Scaneados.Size = new System.Drawing.Size(239, 507);
            this.Scaneados.TabIndex = 42;
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProrityChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusChoose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ManufactuerChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupsChoose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Scaneados);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(547, 634);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox ProrityChoose;
        private System.Windows.Forms.Label label3;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox StatusChoose;
        private System.Windows.Forms.Label label4;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox ManufactuerChoose;
        private System.Windows.Forms.Label label2;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox GroupsChoose;
        private System.Windows.Forms.Label label6;
        private Wisder.W3Common.WMetroControl.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Label label1;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton2;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TreeView Scaneados;
    }
}
