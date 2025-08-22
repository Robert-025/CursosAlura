using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Modelos.Conta;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;

        // Ao instanciar a classe ListaDeContasCorrentes, o construtor é executado automáticamente.
        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            // A lista que está sendo adicionado é maior que o tamanho necessário para o array
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            Console.WriteLine("Aumentando capacidade da lista!");
            // Cria o novo array com a nova capacidade da lista
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            // Enquanto o tamanho de itens for menor que a variável i do for
            for (int i = 0; i < _itens.Length; i++)
            {
                // Iguala os valores dos dois arrays
                novoArray[i] = _itens[i];
            }

            // Define o novo valor de _itens
            _itens = novoArray;
        }
    }
}
