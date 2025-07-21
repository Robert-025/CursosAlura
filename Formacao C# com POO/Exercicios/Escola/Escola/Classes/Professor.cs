using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Classes
{
    public class Professor
    {
        public string Nome { get; set; }
        public List<Disciplina> disciplinasLecionadas = new List<Disciplina>();

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            disciplinasLecionadas.Add(disciplina);
        }

        public void ExibirDadosProfessora()
        {
            Console.WriteLine($"O nome do professor é: {Nome}");
            foreach (var disciplina in disciplinasLecionadas)
            {
                Console.WriteLine($"Disciplina lecionada: {disciplina.Nome}");
            }
        }
    }
}
