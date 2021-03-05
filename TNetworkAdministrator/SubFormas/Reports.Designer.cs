
namespace TNetworkAdministrator.SubFormas
{
    partial class Reports
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
            this.Scaneados = new System.Windows.Forms.TreeView();
            this.metroButton1 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.metroButton2 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroProgressBar1 = new Wisder.W3Common.WMetroControl.Controls.MetroProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupsChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ManufactuerChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProrityChoose = new Wisder.W3Common.WMetroControl.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // Scaneados
            // 
            this.Scaneados.Location = new System.Drawing.Point(23, 113);
            this.Scaneados.Name = "Scaneados";
            this.Scaneados.Size = new System.Drawing.Size(239, 507);
            this.Scaneados.TabIndex = 13;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.Location = new System.Drawing.Point(80, 85);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(106, 22);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "Selecionar Todos";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseVisualStyleBackColor = false;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton2.Location = new System.Drawing.Point(370, 371);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(140, 22);
            this.metroButton2.TabIndex = 20;
            this.metroButton2.Text = "Gerar Relatório";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Filtros:";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(292, 416);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(249, 23);
            this.metroProgressBar1.TabIndex = 32;
            this.metroProgressBar1.Value = 100;
            this.metroProgressBar1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Inventário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(315, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Grupo:";
            // 
            // GroupsChoose
            // 
            this.GroupsChoose.FormattingEnabled = true;
            this.GroupsChoose.ItemHeight = 23;
            this.GroupsChoose.Location = new System.Drawing.Point(389, 142);
            this.GroupsChoose.Name = "GroupsChoose";
            this.GroupsChoose.Size = new System.Drawing.Size(121, 29);
            this.GroupsChoose.TabIndex = 34;
            this.GroupsChoose.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(288, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fabricante:";
            // 
            // ManufactuerChoose
            // 
            this.ManufactuerChoose.FormattingEnabled = true;
            this.ManufactuerChoose.ItemHeight = 23;
            this.ManufactuerChoose.Location = new System.Drawing.Point(389, 191);
            this.ManufactuerChoose.Name = "ManufactuerChoose";
            this.ManufactuerChoose.Size = new System.Drawing.Size(121, 29);
            this.ManufactuerChoose.TabIndex = 36;
            this.ManufactuerChoose.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(320, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 39;
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
            this.StatusChoose.Location = new System.Drawing.Point(389, 241);
            this.StatusChoose.Name = "StatusChoose";
            this.StatusChoose.Size = new System.Drawing.Size(121, 29);
            this.StatusChoose.TabIndex = 38;
            this.StatusChoose.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(288, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 41;
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
            this.ProrityChoose.Location = new System.Drawing.Point(389, 297);
            this.ProrityChoose.Name = "ProrityChoose";
            this.ProrityChoose.Size = new System.Drawing.Size(121, 29);
            this.ProrityChoose.TabIndex = 40;
            this.ProrityChoose.UseSelectable = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 634);
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
            this.Name = "Reports";
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView Scaneados;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton1;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label1;
        private Wisder.W3Common.WMetroControl.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox GroupsChoose;
        private System.Windows.Forms.Label label4;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox ManufactuerChoose;
        private System.Windows.Forms.Label label3;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox StatusChoose;
        private System.Windows.Forms.Label label5;
        private Wisder.W3Common.WMetroControl.Controls.MetroComboBox ProrityChoose;
    }
}