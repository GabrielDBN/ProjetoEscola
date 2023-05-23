using Escola.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class CadastroAlunos : Form
    {

        private List<Turma> turmas;
        

        
        public CadastroAlunos()
        {
            
            InitializeComponent();
            turmas = Turma.ListAll();
            foreach (Turma turma in turmas) {
                cbxTurmas.Items.Add(turma.Nome);
            }
        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new();
            Matricula matricula = new();
            aluno.Nome = txtNome.Text;
            aluno.DataNascimento = dateTime.Value;
            aluno.Email = txtEmail.Text;
            var idAluno = aluno.SalvarAluno();
            matricula.Aluno_Id = idAluno;
            int index = cbxTurmas.SelectedIndex;
            int idTurma = turmas[index].Id;
            matricula.Turma_Id = idTurma;
            matricula.Insert();
            MessageBox.Show("Aluno Cadastrado!");
        }
    }
}
