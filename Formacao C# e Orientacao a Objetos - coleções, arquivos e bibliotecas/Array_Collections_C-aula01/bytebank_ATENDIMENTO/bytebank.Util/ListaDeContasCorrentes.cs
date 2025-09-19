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

        public void Remover(ContaCorrente conta)
        {
            //Item que recebe o indice que vai ser removido 
            int indiceItem = -1;

            //Usa como parametro o _proximaPosicao, que é o tamanho do array no momento que for remover
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if (contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }

            //Enquanto o indice i for menor que o tamanho do array -1
            for (int i = indiceItem; i < _proximaPosicao-1; i++)
            {
                //Substitui o item encontrado pelo proximo do array
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void ExibirLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    var conta = _itens[i];
                    Console.WriteLine($"Indice[{i}] = Conta: {conta.Conta} - Nº da agencia: {conta.Numero_agencia}");
                }
            }
        }

        public ContaCorrente RecuperarContaDoIndice(int indice)
        {
            //Valida se o valor recebido é valido
            if (indice < 0 || indice >= _proximaPosicao)
            {
                //Entra se for inválido e grea uma exceção
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            //Retorna do array _itens que contém as contas o valor que está no índice indicado
            return _itens[indice];
        }

        public int Tamanho { 
            get
            {
                return _proximaPosicao;
            }
        }

        public ContaCorrente this[int indice]
        {
            get
            {
                return RecuperarContaDoIndice(indice);
            }
        }
    }
}
