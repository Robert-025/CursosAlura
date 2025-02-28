using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Classes
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<int> Notas { get; set; }

        public void ExibirDadosAluno()
        {
            Console.WriteLine($"O nome do aluno é: {Nome}");
            Console.WriteLine($"O aluno tem {Idade} anos");
            foreach( int i in Notas )
            {
                Console.WriteLine($"Notas: {i}");
            }
        }
    }
}
