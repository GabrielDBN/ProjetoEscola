namespace Escola
{
    partial class CadstroDisciplina
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
            this.cbxTipoDsiciplina = new System.Windows.Forms.ComboBox();
            this.cbxProfessorNome = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipoDsciplina = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.cbxDiaSemana = new System.Windows.Forms.ComboBox();
            this.cbxHorarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTurma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(205, 219);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(137, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxTipoDsiciplina
            // 
            this.cbxTipoDsiciplina.FormattingEnabled = true;
            this.cbxTipoDsiciplina.Location = new System.Drawing.Point(327, 75);
            this.cbxTipoDsiciplina.Name = "cbxTipoDsiciplina";
            this.cbxTipoDsiciplina.Size = new System.Drawing.Size(121, 23);
            this.cbxTipoDsiciplina.TabIndex = 1;
            // 
            // cbxProfessorNome
            // 
            this.cbxProfessorNome.FormattingEnabled = true;
            this.cbxProfessorNome.Location = new System.Drawing.Point(99, 104);
            this.cbxProfessorNome.Name = "cbxProfessorNome";
            this.cbxProfessorNome.Size = new System.Drawing.Size(121, 23);
            this.cbxProfessorNome.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(99, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 23);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(53, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblTipoDsciplina
            // 
            this.lblTipoDsciplina.AutoSize = true;
            this.lblTipoDsciplina.Location = new System.Drawing.Point(240, 78);
            this.lblTipoDsciplina.Name = "lblTipoDsciplina";
            this.lblTipoDsciplina.Size = new System.Drawing.Size(81, 15);
            this.lblTipoDsciplina.TabIndex = 5;
            this.lblTipoDsciplina.Text = "Tipo Dsciplina";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(37, 110);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(56, 15);
            this.lblProfessor.TabIndex = 6;
            this.lblProfessor.Text = "Professor";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(9, 136);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(84, 15);
            this.lblDiaSemana.TabIndex = 7;
            this.lblDiaSemana.Text = "Dia da semana";
            // 
            // cbxDiaSemana
            // 
            this.cbxDiaSemana.FormattingEnabled = true;
            this.cbxDiaSemana.Location = new System.Drawing.Point(99, 133);
            this.cbxDiaSemana.Name = "cbxDiaSemana";
            this.cbxDiaSemana.Size = new System.Drawing.Size(121, 23);
            this.cbxDiaSemana.TabIndex = 8;
            this.cbxDiaSemana.SelectedIndexChanged += new System.EventHandler(this.cbxDiaSemana_SelectedIndexChanged);
            // 
            // cbxHorarios
            // 
            this.cbxHorarios.FormattingEnabled = true;
            this.cbxHorarios.Location = new System.Drawing.Point(327, 133);
            this.cbxHorarios.Name = "cbxHorarios";
            this.cbxHorarios.Size = new System.Drawing.Size(121, 23);
            this.cbxHorarios.TabIndex = 9;
            this.cbxHorarios.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Horario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turma";
            // 
            // cbxTurma
            // 
            this.cbxTurma.FormattingEnabled = true;
            this.cbxTurma.Location = new System.Drawing.Point(327, 104);
            this.cbxTurma.Name = "cbxTurma";
            this.cbxTurma.Size = new System.Drawing.Size(121, 23);
            this.cbxTurma.TabIndex = 12;
            this.cbxTurma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(157, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cadastro de Desciplina";
            // 
            // CadstroDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 263);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxHorarios);
            this.Controls.Add(this.cbxDiaSemana);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.lblTipoDsciplina);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbxProfessorNome);
            this.Controls.Add(this.cbxTipoDsiciplina);
            this.Controls.Add(this.btnEnviar);
            this.Name = "CadstroDisciplina";
            this.Text = "Cadastro Disciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnviar;
        private ComboBox cbxTipoDsiciplina;
        private ComboBox cbxProfessorNome;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblTipoDsciplina;
        private Label lblProfessor;
        private Label lblDiaSemana;
        private ComboBox cbxDiaSemana;
        private ComboBox cbxHorarios;
        private Label label1;
        private Label label2;
        private ComboBox cbxTurma;
        private Label label3;
    }
}