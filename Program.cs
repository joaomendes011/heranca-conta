/*
Instancie um objeto do tipo Conta Corrente, e faça um Saque com os valores:
- igual ao saldo
- maior que o saldo
- menor que o saldo

Instancie um objeto do tipo Conta poupanca, e faça o teste do método Rendimento


*/  
        ContaCorrente conta1 = new ContaCorrente("Joao Mendes", 100);
        Console.WriteLine("Saque igual ao saldo:");
        conta1.Saque(100);

        ContaCorrente conta2 = new ContaCorrente("Joao Mendes", 100);
        Console.WriteLine("Saque maior que o saldo:");
        conta2.Saque(150);

        ContaCorrente conta3 = new ContaCorrente("Joao Mendes", 100);
        Console.WriteLine("Saque menor que o saldo:");
        conta3.Saque(50);

    

                                                                   