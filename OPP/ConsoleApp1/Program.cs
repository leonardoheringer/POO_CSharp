using OOP;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Aprendendo OOP!");

        //------------------------------------------------------------------------------------------------------------------------
        //Exercicio Aula 10 (Encapsulamento)
        //AnalistaDeTi analistaDeTi = new AnalistaDeTi();

        //analistaDeTi.AdicionarNome("Leonardo", " Heringer");
        //analistaDeTi.AdicionarSalarioPadrao (1000);
        //analistaDeTi.Reajustar();
        

        //Console.WriteLine($"Salario é: {analistaDeTi.Salario}");
        












        //------------------------------------------------------------------------------------------------------------------------
        //Exercicio Aula 9 (Interface/Virtual e Sobrescrita)
        //ContaPoupanca contaPoupanca = new ContaPoupanca(111, 0);
        //contaPoupanca.Deposita(100);
        //contaPoupanca.Saca(10);
        //double saldoPoupanca = contaPoupanca.ConsultaSaldoDisponivel();

        //Console.WriteLine($"Saldo Poupança é: {saldoPoupanca}");



        //ContaCorrente contaCorrente = new ContaCorrente(111, 100);
        //contaCorrente.Deposita(100);
        //contaCorrente.Saca(20);
        //double saldoCorrente = contaCorrente.ConsultaSaldoDisponivel();

        //Console.WriteLine($"Saldo Corrente é: {saldoCorrente}");


        //------------------------------------------------------------------------------------------------------------------------
        //Exercicio Aula 8 (Classes Abstratas e Polimorfismo)


        //AnalistaDeTi analistaDeTi = new AnalistaDeTi();
        //Gerente gerente = new Gerente();
        //GerenteDeAgencia gerenteDeAgencia = new GerenteDeAgencia();
        //GerenteDeTi gerenteDeTi = new GerenteDeTi();

        //analistaDeTi.Nome = "Leonardo Heringer";
        //analistaDeTi.Salario = 3000;
        //Console.WriteLine($"Salario do Analista de TI é: {analistaDeTi.Salario}");
        //analistaDeTi.Reajustar();
        //Console.WriteLine($"Salario do Analista de TI Reajuustado é: {analistaDeTi.Salario}");

        //Console.WriteLine("_____________________________________________________________________________");

        //gerente.Nome = "Ricardo Heringer";
        //gerente.Salario = 8000;
        //Console.WriteLine($"Salario do  Gerente é: {gerente.Salario}");
        //gerente.Reajustar();
        //Console.WriteLine($"Salario do  Gerente Reajuustado é: {gerente.Salario}");

        //Console.WriteLine("_____________________________________________________________________________");

        //gerenteDeAgencia.Nome = "Pedro Heringer";
        //gerenteDeAgencia.Salario = 10000;
        //Console.WriteLine($"Salario do  Gerente de Agencia  é: {gerenteDeAgencia.Salario}");
        // gerenteDeAgencia.Reajustar();
        //Console.WriteLine($"Salario do  Gerente de Agencia  Reajuustado é: {gerenteDeAgencia.Salario}");
        //Console.WriteLine("_____________________________________________________________________________");

        //gerenteDeTi.Nome = "Esther Heringer";
        //gerenteDeTi.Salario = 20000;
        //Console.WriteLine($"Salario do  Gerente de T.I é: {gerenteDeTi.Salario}");
        //gerenteDeTi.Reajustar();
        //Console.WriteLine($"Salario do  Gerente de T.I Reajuustado é: {gerenteDeTi.Salario}");

        //------------------------------------------------------------------------------------------------------------------------


        //Exercicio Aula 7 (Herança)

        //ContaPoupanca contaPoupanca = new ContaPoupanca(112, 0);

        //contaPoupanca.Deposita(100);
        //contaPoupanca.Saca(10);

        //double saldo = contaPoupanca.ConsultaSaldoDisponivel();


        //contaPoupanca.MostrarNumeroDaConta();
        //Console.WriteLine($"Saldo da conta poupança é: {saldo}");

        //Conta conta = new Conta(113, 100);

        // conta.Deposita(500);
        //conta.Saca(140);

        // double saldoContaCorrente = conta.ConsultaSaldoDisponivel();
        // Console.WriteLine($"Saldo da conta corrente é: {saldoContaCorrente}");


        //------------------------------------------------------------------------------------------------------------------------








        //Conta conta1 = new Conta(123, 500);
        // Conta conta2 = new Conta(456, 700);
        //Conta conta3 = new Conta(789,900);
        //Conta conta4 = new Conta(921,1100);

        //Console.WriteLine($"Total de contas: { Conta.TotalDeContasCriadas}");
        //int total = Conta.ProximoTotalContasCriadas();
        //Console.WriteLine($"Proximo total de contas: {total}");

        //------------------------------------------------------------------------------------------------------------------------


        // Criando um objeto de cada classe


        //CartaoDeCredito cdc = new CartaoDeCredito();
        //Cliente c = new Cliente();
        // Adicionando o nome do cliente
        //c.Nome = "Leonardo Heringer";
        //Adicionando o numero e data de validade do cartao
        //cdc.Numero = "5249754457145953";
        //cdc.DataDeValidade = "02/2025";
        //cdc.Cliente = c;



        //Console.WriteLine($"O nome do cliente é: {c.Nome}");
        //Console.WriteLine($"O numero do cartão é: {cdc.Numero}");
        //Console.WriteLine($"A data de validade do cartão é: {cdc.DataDeValidade}");
        //Console.WriteLine($"O nome do cliente do agregado é: {cdc.Cliente.Nome}");

        //------------------------------------------------------------------------------------------------------------------------



        // Criando instância da conta
        //Conta conta= new Conta(123,300);
        // conta.AdicionarLimite(1500);

        // conta.Deposita(1500);
        //conta.Deposita(2500);
        //conta.Deposita(4500);


        //bool  saca = conta.Saca(000);
        //if (saca)
        //{

        //------------------------------------------------------------------------------------------------------------------------

        //double saldo = conta.ConsultaSaldoDisponivel();


        //Console.WriteLine($"Seu Saldo é: {saldo}");
        //Console.WriteLine($"Seu limite é: {conta.Limite}");
        //Console.WriteLine($"O numero da sua conta é: {conta.Numero}");
        // }
    }
}