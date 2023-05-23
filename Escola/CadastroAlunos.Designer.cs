namespace Escola
{
    partial class CadastroAlunos
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxTurmas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(167, 217);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(114, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(167, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(115, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(115, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(168, 129);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(114, 23);
            this.dateTime.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(98, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(102, 102);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(50, 135);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(112, 15);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data de nascimento";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(135, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 28);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Cadastro Aluno";
            // 
            // cbxTurmas
            // 
            this.cbxTurmas.FormattingEnabled = true;
            this.cbxTurmas.Location = new System.Drawing.Point(168, 167);
            this.cbxTurmas.Name = "cbxTurmas";
            this.cbxTurmas.Size = new System.Drawing.Size(114, 23);
            this.cbxTurmas.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Turma";
            // 
            // CadastroAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTurmas);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnEnviar);
            this.Name = "CadastroAlunos";
            this.Text = "Cadastro Alunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnviar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private DateTimePicker dateTime;
        private Label lblNome;
        private Label lblEmail;
        private Label lblData;
        private Label lblTitle;
        private ComboBox cbxTurmas;
        private Label label1;
    }
}