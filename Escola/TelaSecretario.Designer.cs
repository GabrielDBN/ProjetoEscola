namespace Escola
{
    partial class TelaSecretario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSecretario));
            this.btnRegistrarProfessor = new System.Windows.Forms.Button();
            this.btnRegistrarAluno = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnRegistrarTurma = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarDisciplina = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dlgImportProfessores = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarProfessor
            // 
            this.btnRegistrarProfessor.Location = new System.Drawing.Point(42, 21);
            this.btnRegistrarProfessor.Name = "btnRegistrarProfessor";
            this.btnRegistrarProfessor.Size = new System.Drawing.Size(113, 46);
            this.btnRegistrarProfessor.TabIndex = 0;
            this.btnRegistrarProfessor.Text = "Registrar";
            this.btnRegistrarProfessor.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarAluno
            // 
            this.btnRegistrarAluno.Location = new System.Drawing.Point(41, 22);
            this.btnRegistrarAluno.Name = "btnRegistrarAluno";
            this.btnRegistrarAluno.Size = new System.Drawing.Size(114, 46);
            this.btnRegistrarAluno.TabIndex = 1;
            this.btnRegistrarAluno.Text = "Registrar";
            this.btnRegistrarAluno.UseVisualStyleBackColor = true;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistros.Location = new System.Drawing.Point(10, 7);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(76, 20);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.Text = "Secretario";
            // 
            // btnRegistrarTurma
            // 
            this.btnRegistrarTurma.Location = new System.Drawing.Point(42, 22);
            this.btnRegistrarTurma.Name = "btnRegistrarTurma";
            this.btnRegistrarTurma.Size = new System.Drawing.Size(113, 46);
            this.btnRegistrarTurma.TabIndex = 3;
            this.btnRegistrarTurma.Text = "Registrar";
            this.btnRegistrarTurma.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarTurma);
            this.groupBox1.Location = new System.Drawing.Point(22, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrarAluno);
            this.groupBox2.Location = new System.Drawing.Point(248, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aluno";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRegistrarProfessor);
            this.groupBox3.Location = new System.Drawing.Point(22, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Professor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRegistrarDisciplina);
            this.groupBox4.Location = new System.Drawing.Point(248, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 84);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Disciplina";
            // 
            // btnRegistrarDisciplina
            // 
            this.btnRegistrarDisciplina.Location = new System.Drawing.Point(41, 21);
            this.btnRegistrarDisciplina.Name = "btnRegistrarDisciplina";
            this.btnRegistrarDisciplina.Size = new System.Drawing.Size(113, 46);
            this.btnRegistrarDisciplina.TabIndex = 0;
            this.btnRegistrarDisciplina.Text = "Registrar";
            this.btnRegistrarDisciplina.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Importar professores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRegistros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaSecretario";
            this.Text = "Tela Secretario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrarProfessor;
        private Button btnRegistrarAluno;
        private Label lblRegistros;
        private Button btnRegistrarTurma;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnRegistrarDisciplina;
        private Button button1;
        private OpenFileDialog dlgImportProfessores;
    }
}