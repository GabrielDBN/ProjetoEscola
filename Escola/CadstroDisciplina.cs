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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Escola
{
    public partial class CadstroDisciplina : Form
    {
        private Professor professor = new();
        private List<Professor> professors;
        private Disciplinas disciplinas;
        List<Turma> turmaList = Turma.ListAll(); 
        private List<string> diasDaSemana = new List<string>()
        {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira"
        };

        private List<string> horarios = new List<string>()
        {
            "Matutino",
            "Vespertino",
            "Noturno"
        };

        public CadstroDisciplina()
        {
            InitializeComponent();
            professors = professor.ListAll();
            cbxTipoDsiciplina.Items.Add("2");
            cbxTipoDsiciplina.Items.Add("4");
            foreach (string dia in diasDaSemana)
            {
                cbxDiaSemana.Items.Add(dia);
            }
            foreach(string horario in horarios)
            {
                cbxHorarios.Items.Add(horario);
            }
            foreach (Turma turma in turmaList)
            {
                cbxTurma.Items.Add(turma.Nome);
            }
            for ( int i = 0;i < professors.Count;i++ )
            {
                cbxProfessorNome.Items.Add(professors[i].Nome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var indexProfessor = cbxProfessorNome.SelectedIndex;
            var idProfessor = professors[indexProfessor].Id;
            var indexTurma = cbxTurma.SelectedIndex;
            var idTurma = turmaList[indexTurma].Id;
        
            Disciplinas disciplinas = new();
            Horario horario = new();
            Turma turma = new();
            disciplinas.Nome = txtNome.Text;
            disciplinas.Professor_id = idProfessor;
            disciplinas.Tipo_disciplina = cbxTipoDsiciplina.Text;
            var idDisciplina = disciplinas.Insert();
            horario.Turma_id = idTurma;
            horario.Disciplina_id = idDisciplina;
            horario.Time = cbxHorarios.Text;
            horario.Dia_semana = cbxDiaSemana.Text;
            horario.Insert();
            
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void cbxDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
