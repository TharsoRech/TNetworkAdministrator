
namespace TNetworkAdministrator.Controls
{
    partial class ConfigutacoesControl
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
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroButton4 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Database = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroButton3 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.StatusCheck = new Wisder.W3Common.WMetroControl.Controls.MetroCheckBox();
            this.metroButton2 = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.SaveButton = new Wisder.W3Common.WMetroControl.Controls.MetroButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Server = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new Wisder.W3Common.WMetroControl.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 19);
            this.label11.TabIndex = 79;
            this.label11.Text = "Verificar erros e alertas a cada(Min):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(288, 108);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(27, 20);
            this.numericUpDown1.TabIndex = 78;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton4.Location = new System.Drawing.Point(479, 188);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(144, 22);
            this.metroButton4.TabIndex = 77;
            this.metroButton4.Text = "Configurar Envio SMS";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(498, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 76;
            this.label5.Text = "Envio SMS:";
            // 
            // Database
            // 
            this.Database.Lines = new string[0];
            this.Database.Location = new System.Drawing.Point(423, 66);
            this.Database.MaxLength = 32767;
            this.Database.Name = "Database";
            this.Database.PasswordChar = '\0';
            this.Database.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Database.SelectedText = "";
            this.Database.Size = new System.Drawing.Size(257, 24);
            this.Database.TabIndex = 75;
            this.Database.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(506, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 74;
            this.label3.Text = "Database:";
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton3.Location = new System.Drawing.Point(536, 99);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(144, 22);
            this.metroButton3.TabIndex = 73;
            this.metroButton3.Text = "Configurar Database";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseVisualStyleBackColor = false;
            // 
            // StatusCheck
            // 
            this.StatusCheck.AutoSize = true;
            this.StatusCheck.FontSize = Wisder.W3Common.WMetroControl.MetroCheckBoxSize.Medium;
            this.StatusCheck.ForeColor = System.Drawing.Color.White;
            this.StatusCheck.Location = new System.Drawing.Point(40, 43);
            this.StatusCheck.Name = "StatusCheck";
            this.StatusCheck.Size = new System.Drawing.Size(262, 19);
            this.StatusCheck.TabIndex = 72;
            this.StatusCheck.Text = "Iniciar Aplicativo junto com o Windows";
            this.StatusCheck.UseCustomBackColor = true;
            this.StatusCheck.UseCustomForeColor = true;
            this.StatusCheck.UseSelectable = true;
            this.StatusCheck.UseVisualStyleBackColor = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton2.Location = new System.Drawing.Point(40, 332);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(140, 22);
            this.metroButton2.TabIndex = 71;
            this.metroButton2.Text = "Remover Configurações";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveButton.Location = new System.Drawing.Point(193, 332);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 22);
            this.SaveButton.TabIndex = 70;
            this.SaveButton.Text = "Salvar";
            this.SaveButton.UseCustomBackColor = true;
            this.SaveButton.UseSelectable = true;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(66, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 23);
            this.label9.TabIndex = 69;
            this.label9.Text = "Configurar Email para Envio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Servidor:";
            // 
            // Server
            // 
            this.Server.Lines = new string[0];
            this.Server.Location = new System.Drawing.Point(104, 237);
            this.Server.MaxLength = 32767;
            this.Server.Name = "Server";
            this.Server.PasswordChar = '\0';
            this.Server.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Server.SelectedText = "";
            this.Server.Size = new System.Drawing.Size(189, 24);
            this.Server.TabIndex = 67;
            this.Server.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 66;
            this.label4.Text = "Senha:";
            // 
            // Password
            // 
            this.Password.Lines = new string[0];
            this.Password.Location = new System.Drawing.Point(104, 283);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(189, 24);
            this.Password.TabIndex = 65;
            this.Password.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Email:";
            // 
            // Email
            // 
            this.Email.Lines = new string[0];
            this.Email.Location = new System.Drawing.Point(104, 188);
            this.Email.MaxLength = 32767;
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Email.SelectedText = "";
            this.Email.Size = new System.Drawing.Size(189, 24);
            this.Email.TabIndex = 63;
            this.Email.UseSelectable = true;
            // 
            // ConfigutacoesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.StatusCheck);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Name = "ConfigutacoesControl";
            this.Size = new System.Drawing.Size(701, 387);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton4;
        private System.Windows.Forms.Label label5;
        public Wisder.W3Common.WMetroControl.Controls.MetroTextBox Database;
        private System.Windows.Forms.Label label3;
        public Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton3;
        private Wisder.W3Common.WMetroControl.Controls.MetroCheckBox StatusCheck;
        private Wisder.W3Common.WMetroControl.Controls.MetroButton metroButton2;
        public Wisder.W3Common.WMetroControl.Controls.MetroButton SaveButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        public Wisder.W3Common.WMetroControl.Controls.MetroTextBox Server;
        private System.Windows.Forms.Label label4;
        public Wisder.W3Common.WMetroControl.Controls.MetroTextBox Password;
        private System.Windows.Forms.Label label2;
        public Wisder.W3Common.WMetroControl.Controls.MetroTextBox Email;
    }
}
