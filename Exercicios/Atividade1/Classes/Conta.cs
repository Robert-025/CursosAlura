using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1.Classes
{
    public class Conta
    {
        //public int indicador;
        //public string titular;
        //public double saldo;
        public int Indicado { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine($"Titular da conta: {Titular}");
            Console.WriteLine($"Saldo: R$ {Saldo}");
        }
    }
}
