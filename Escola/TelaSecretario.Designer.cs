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
            this.btnRegistrarProfessor = new System.Windows.Forms.Button();
            this.btnRegistrarAuluno = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnRegistrarTurma = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarProfessor
            // 
            this.btnRegistrarProfessor.Location = new System.Drawing.Point(42, 25);
            this.btnRegistrarProfessor.Name = "btnRegistrarProfessor";
            this.btnRegistrarProfessor.Size = new System.Drawing.Size(113, 63);
            this.btnRegistrarProfessor.TabIndex = 0;
            this.btnRegistrarProfessor.Text = "Registrar";
            this.btnRegistrarProfessor.UseVisualStyleBackColor = true;
            this.btnRegistrarProfessor.Click += new System.EventHandler(this.btnRegistrarProfessor_Click);
            // 
            // btnRegistrarAuluno
            // 
            this.btnRegistrarAuluno.Location = new System.Drawing.Point(51, 22);
            this.btnRegistrarAuluno.Name = "btnRegistrarAuluno";
            this.btnRegistrarAuluno.Size = new System.Drawing.Size(113, 62);
            this.btnRegistrarAuluno.TabIndex = 1;
            this.btnRegistrarAuluno.Text = "Registrar";
            this.btnRegistrarAuluno.UseVisualStyleBackColor = true;
            this.btnRegistrarAuluno.Click += new System.EventHandler(this.btnRegistrarAuluno_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistros.Location = new System.Drawing.Point(12, 9);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(76, 20);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.Text = "Secretario";
            // 
            // btnRegistrarTurma
            // 
            this.btnRegistrarTurma.Location = new System.Drawing.Point(42, 22);
            this.btnRegistrarTurma.Name = "btnRegistrarTurma";
            this.btnRegistrarTurma.Size = new System.Drawing.Size(113, 62);
            this.btnRegistrarTurma.TabIndex = 3;
            this.btnRegistrarTurma.Text = "Registrar";
            this.btnRegistrarTurma.UseVisualStyleBackColor = true;
            this.btnRegistrarTurma.Click += new System.EventHandler(this.btnRegistrarTurma_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarTurma);
            this.groupBox1.Location = new System.Drawing.Point(22, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrarAuluno);
            this.groupBox2.Location = new System.Drawing.Point(239, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aluno";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRegistrarProfessor);
            this.groupBox3.Location = new System.Drawing.Point(22, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Professor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(248, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dsciplina";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(136, 305);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grade aluno";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TelaSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRegistros);
            this.Name = "TelaSecretario";
            this.Text = "Tela Secretario";
            this.Load += new System.EventHandler(this.TelaSecretario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrarProfessor;
        private Button btnRegistrarAuluno;
        private Label lblRegistros;
        private Button btnRegistrarTurma;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button1;
        private GroupBox groupBox5;
        private Button button2;
    }
}