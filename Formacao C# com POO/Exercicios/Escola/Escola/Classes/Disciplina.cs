using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Classes
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public List<Aluno> alunosMatriculados = new List<Aluno>();

        public void AdicionarAluno(Aluno aluno)
        {
            alunosMatriculados.Add(aluno);
        }

        public void ExibirDadosDisciplina()
        {
            Console.WriteLine($"O nome da disciplina é: {Nome}");
            foreach (var aluno in alunosMatriculados)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
            }
        }
    }
}
