﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public class Layout
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();

        private static int opcao = 0;
        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("                                                                    ");
            Console.WriteLine("                      Digite a Opção desejada :                     ");
            Console.WriteLine("               ======================================               ");
            Console.WriteLine("                          1 - Criar Conta                           ");
            Console.WriteLine("               ======================================               ");
            Console.WriteLine("                     2 - Entrar com CPF e Senha                     ");
            Console.WriteLine("               ======================================               ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao) 
            {

                case 1: 
                        TelaCriarConta();
                    break;
                case 2:
                    TelaLogin();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }


        private static void TelaCriarConta()
        {
            Console.Clear();
            Console.WriteLine("                                                                     ");
            Console.WriteLine("                           Digite seu nome :                         ");
            string nome = Console.ReadLine();
            Console.WriteLine("               ======================================                ");
            Console.WriteLine("                             Digite o CPF                            ");
            string cpf = Console.ReadLine();
            Console.WriteLine("               ======================================                ");
            Console.WriteLine("                           Digite sua Senha                          ");
            string senha = Console.ReadLine();
            Console.WriteLine("               ======================================                ");
          
            // Criar conta
            ContaCorrente contaCorrente = new ContaCorrente();
            Pessoa pessoa = new Pessoa();
            pessoa.SetNome(nome);
            pessoa.SetCPF(cpf);
            pessoa.SetSenha(senha);
            pessoa.Conta = contaCorrente;

            pessoas.Add(pessoa);

            Console.Clear();
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                    Conta cadastrada com sucesso.                    ");
            Console.WriteLine("               ======================================                ");
            // Espera 1 segundo para ir para Tela Logada
            Thread.Sleep(1000);
            TelaContaLogada(pessoa);

        }

        private static void TelaLogin()
        {
            
            Console.Clear();
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                            Digite o CPF:                           ");
            string cpf = Console.ReadLine();
            Console.WriteLine("               ======================================               ");
            Console.WriteLine("                         Digite sua senha:                          ");
            string senha = Console.ReadLine();
            Console.WriteLine("               ======================================               ");
            
            // Logar no Sistema 
            Pessoa pessoa = pessoas.FirstOrDefault(x => x.CPF == cpf && x.Senha == senha);
            if (pessoa != null)
            {
                TelaBoasVindas(pessoa);
                TelaContaLogada(pessoa);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("                         Pessoa não cadastrada.                      ");
                Console.WriteLine("               ======================================                ");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        private static void TelaBoasVindas(Pessoa pessoa)
        {
            string msgTelaBemVindo =
            $"{pessoa.Nome} | Banco: {pessoa.Conta.GetCodigoDoBanco()} " +
            $"| Agencia: {pessoa.Conta.GetNumeroAgencia()} | Conta: {pessoa.Conta.GetNumeroDaConta()}";
            Console.WriteLine("");
            Console.WriteLine($"  Seja bem vindo,{msgTelaBemVindo}                ");
            Console.WriteLine("");
        }
        private static void TelaContaLogada(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                      Digite a Opção desejada :                     ");
            Console.WriteLine("               ======================================               ");
            Console.WriteLine("                     1 - Realizar um Deposito                       ");
            Console.WriteLine("               ======================================               ");
            Console.WriteLine("                       2 - Realizar um Saque                        ");
            Console.WriteLine("               ======================================               ");
            Console.WriteLine("                        3 - Consultar Saldo                         ");
            Console.WriteLine("               ======================================               ");
            Console.WriteLine("                            4 - Extrato                             ");
            Console.WriteLine("               ======================================               ");
            Console.WriteLine("                              5 - Sair                              ");
            Console.WriteLine("               ======================================               ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {

                case 1:
                    TelaDeposito(pessoa);
                    break;
                case 2:
                    TelaSaque(pessoa);
                    break;
                case 3:
                    TelaSaldo(pessoa);
                    break;
                case 4:
                    TelaExtrato(pessoa);
                    break;
                case 5:
                    TelaPrincipal();
                    break;
                default:
                    Console.Clear ();   
                    Console.WriteLine("                            Opção Inválida.                         ");
                    Console.WriteLine("               ======================================               ");
                    break;
            }
        }
        private static void TelaDeposito(Pessoa pessoa)
        {
        Console.Clear();
            TelaBoasVindas (pessoa);
            
            Console.WriteLine("                    Digite o valor do deposito:                      ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("               ======================================                ");
            pessoa.Conta.Deposita(valor);
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("                                                                    ");
            Console.WriteLine("              =======================================               ");
            Console.WriteLine("                  Deposito Realizado com Sucesso                    ");
            Console.WriteLine("              =======================================               ");
            Console.WriteLine("                                                                    ");
            Thread.Sleep(1000);
            OpcaoVoltarLogado (pessoa);
        }
        private static void TelaSaque(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);

            Console.WriteLine("                     Digite o valor do Saque:                        ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("               ======================================                ");
            bool okSaque = pessoa.Conta.Saca(valor);
            Console.Clear();
            TelaBoasVindas(pessoa);
            Console.WriteLine("                                                                    ");
            if (okSaque)
            {
                Console.WriteLine("              =======================================               ");
                Console.WriteLine("                 Saque foi Realizado com Sucesso                    ");
                Console.WriteLine("              =======================================               ");
            }
            else
            {
                Console.WriteLine("              =======================================               ");
                Console.WriteLine("                        Saldo Insuficiente!                         ");
                Console.WriteLine("              =======================================               ");
            }
            Console.WriteLine("                                                                    ");
            Thread.Sleep(1000);
            OpcaoVoltarLogado(pessoa);
        }
        private static void TelaSaldo(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("              =======================================               ");
            Console.WriteLine($"                        Seu saldo é: {pessoa.Conta.ConsultaSaldo()}                         ");
            Console.WriteLine("              =======================================               ");
            Thread.Sleep (1500);
            OpcaoVoltarLogado(pessoa);
        }
        private static void TelaExtrato(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);
            if (pessoa.Conta.Extrato().Any())
            {
                //Mostrar Extrato
                double total = pessoa.Conta.Extrato().Sum(x=> x.Valor);
                Console.WriteLine("              =======================================               ");
                foreach ( Extrato extrato in pessoa.Conta.Extrato())
                {
                    
                    Console.WriteLine($"                     Data: {extrato.Data.ToString("dd/MM/yyyy HH:mm:ss")} ");
                    Console.WriteLine($"                   Tipo de Movimentação: {extrato.Descricao}             ");
                    Console.WriteLine($"                    Valor da Movimentação: {extrato.Valor}             ");
                    Console.WriteLine("              =======================================               ");
                }
                Console.WriteLine("              =======================================               ");
                Console.WriteLine($"                         SUB TOTAl: {total}                        ");
                Console.WriteLine("              =======================================               ");
            }
            else 
            {
                //Mensagem Erro
                Console.WriteLine("              =======================================               ");
                Console.WriteLine("                   Não há extrato a ser exibido!                    ");
                Console.WriteLine("              =======================================               ");
            }
           
            Console.ReadKey();
            OpcaoVoltarLogado(pessoa);
        }
        private static void OpcaoVoltarLogado(Pessoa pessoa)
        {
            Console.Clear();
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                    Entre com uma opção abaixo:                     ");
            Console.WriteLine("              =======================================               ");
            Console.WriteLine("                    1 - Voltar para minha conta                     ");
            Console.WriteLine("               ======================================               ");
            Console.WriteLine("                              2 - Sair                              ");
            Console.WriteLine("               ======================================               ");
            opcao =int.Parse(Console.ReadLine());  
            
            if( opcao == 1)
            {

                TelaContaLogada(pessoa);
            }
            if (opcao == 2)
            {
                TelaPrincipal();
            }


        }
        private static void OpcaoVoltarDeslogado(Pessoa pessoa)
        {
            Console.WriteLine("                    Entre com uma opção abaixo:                     ");
            Console.WriteLine("              =======================================               ");
            Console.WriteLine("                    1 - Voltar para minha conta                     ");
            Console.WriteLine("               ======================================               ");
            Console.WriteLine("                              2 - Sair                              ");
            Console.WriteLine("               ======================================               ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {

                TelaContaLogada(pessoa);
            }
            
            else
            {
                Console.WriteLine("                           Opção Inválida                            ");
                Console.WriteLine("               ======================================                ");
            }
        }
       


    }

}
