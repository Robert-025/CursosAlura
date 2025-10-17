using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;

namespace bytebank_ATENDIMENTO.ByteBank.Atendimento
{
//Desabilita os alertas que aparecerem nessa classe
#nullable disable
    internal class ByteBankAtendimento
    {

        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>(){
            new ContaCorrente(95){Saldo = 100, Titular = new Cliente{Cpf = "11111111111", Nome = "Tiago", Profissao = "DEV" } },
            new ContaCorrente(95){Saldo = 140, Titular = new Cliente{Cpf = "22222222222", Nome = "Lucas", Profissao = "DEVOPS" } },
            new ContaCorrente(94){Saldo = 60, Titular = new Cliente{Cpf = "33333333333", Nome = "Gabriel", Profissao = "REDES" } },
            new ContaCorrente(93){Saldo = 60}
        };

        public void AtendimentoCliente()
        {
            char opcao = '0';

            try
            {
                while (opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("=================================");
                    Console.WriteLine("====       Atendimento       ====");
                    Console.WriteLine("====   1 - Cadastrar Conta   ====");
                    Console.WriteLine("====   2 - Listar Conta      ====");
                    Console.WriteLine("====   3 - Remover Conta     ====");
                    Console.WriteLine("====   4 - Ordenar Conta     ====");
                    Console.WriteLine("====   5 - Pesquisar Conta   ====");
                    Console.WriteLine("====   6 - Sair do Sistema   ====");
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" Digite a opção desejada: ");

                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception erro)
                    {

                        throw new ByteBankException(erro.Message);
                    }


                    switch (opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarConta();
                            break;
                        case '3':
                            RemoverConta();
                            break;
                        case '4':
                            OrdenarConta();
                            break;
                        case '5':
                            PerquisarConta();
                            break;
                        case '6':
                            SairDaAplicação();
                            break;
                        default:
                            Console.WriteLine("Opcao não implementada");
                            break;
                    }

                }
            }
            catch (ByteBankException erro)
            {
                Console.WriteLine($"{erro.Message}");
            }
        }

        private void SairDaAplicação()
        {
            Console.WriteLine("Saindo da aplicação...");
            Console.ReadKey();
        }

        private void PerquisarConta()
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("==== Pesquisar Conta ====");
            Console.WriteLine("============================");
            Console.WriteLine("\n");

            Console.Write("Deseja pesquisar pelo NUMERO DA CONTA (1), CPF DO TITULAR (2) ou NUMERO DA AGENCIA (3) ? ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Informe o número da conta: ");
                        string _numeroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaContaPorNumero(_numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Informe o CPF do titular da conta: ");
                        string cpf = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaContaPorCpf(cpf);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Informe o numero da agencia: ");
                        int numeroAgencia = int.Parse(Console.ReadLine());
                        var contasPorAgencia = ConsultaPorAgencia(numeroAgencia);
                        ExibeListaDeContas(contasPorAgencia);
                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("Opcao nao disponivel.");
                    break;
            }
        }

        private void ExibeListaDeContas(List<ContaCorrente> contasPorAgencia)
        {
            if (contasPorAgencia != null)
            {
                foreach (var item in contasPorAgencia)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("A consulta nao retornou dados. ");
            }
        }

        private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
        {
            //Bem parecido com a linguagem SQL - LINQ
            var consulta = (
                    from conta in _listaDeContas
                    where conta.Numero_agencia == numeroAgencia
                    select conta).ToList();

            return consulta;
        }

        private ContaCorrente ConsultaContaPorCpf(string? cpf)
        {
            //Usa o FirstOrDefaut para trazer o cpf achado pelo where na _listaDeContas através da funcao lambda
            return _listaDeContas.Where(x => x.Titular.Cpf == cpf).FirstOrDefault();
        }

        private ContaCorrente ConsultaContaPorNumero(string numeroConta)
        {
            //return _listaDeContas.Where(x => x.Conta == numeroConta).FirstOrDefault();

            ContaCorrente consulta = (
                from conta in _listaDeContas
                where conta.Conta == numeroConta
                select conta).FirstOrDefault();

            return consulta;
        }

        private void OrdenarConta()
        {
            //Ordena a lista de contas baseado no saldo
            _listaDeContas.Sort();
            Console.WriteLine("==== Lista de contas ordenadas! ====");
            Console.ReadKey();
        }

        private void ListarConta()
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("==== Cadastro de Contas ====");
            Console.WriteLine("============================");
            Console.WriteLine("\n");

            if (_listaDeContas.Count <= 0)
            {
                Console.WriteLine("Não há contas cadastradas!");
                Console.ReadKey();
                return;
            }

            foreach (ContaCorrente item in _listaDeContas)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("============================");
                Console.ReadKey();
            }
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("==== Cadastro de Contas ====");
            Console.WriteLine("============================");
            Console.WriteLine("\n");
            Console.WriteLine(" ==== Informe dados da conta ====");

            Console.Write("Numero da Agencia: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(numeroAgencia);

            Console.WriteLine($"Número da nova conta: {conta.Conta}");

            Console.Write("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.Write("Informe o CPF do titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.Write("Informe a profissão do titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);

            Console.WriteLine("Conta cadastrada com sucesso!");
            Console.ReadKey();
        }

        private void RemoverConta()
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("==== Remover Contas ====");
            Console.WriteLine("============================");
            Console.WriteLine("\n");
            Console.WriteLine(" ==== Informe o numero da conta que será removida: ");

            string numeroConta = Console.ReadLine();

            ContaCorrente conta = null;

            //Percorre a lista de contas
            foreach (var item in _listaDeContas)
            {
                //Se ele achar um item com a conta igual a que foi passado
                if (item.Conta.Equals(numeroConta))
                {
                    //Define a variavevl conta achada igual ao item
                    conta = item;
                }
            }
            //Remove a conta da lista caso o objeto conta seja diferente de nulo
            if (conta != null)
            {
                _listaDeContas.Remove(conta);
                Console.WriteLine("==== Conta removida da lista! ====");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("==== Conta não encontrada! ====");
            }
            Console.ReadKey();

        }
    }
}
