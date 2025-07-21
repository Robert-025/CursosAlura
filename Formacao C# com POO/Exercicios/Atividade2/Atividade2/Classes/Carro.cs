using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2.Classes
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public int Ano { get; set; }
        public string DescricaoDetalhada { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Fabricante: {Fabricante}");
            Console.WriteLine($"Ano: {}");
        }
    }
}
