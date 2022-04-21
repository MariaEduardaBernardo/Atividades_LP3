Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

Console.WriteLine("\n--- Conta 1 ---");
c1.Despositar(200.00);
c1.Sacar(100.00);
Console.WriteLine("Saldo atual: " +c1.Saldo);

Console.WriteLine("\n--- Conta 2 ---");
c2.Despositar(100.00);
c2.Sacar(45.00);
Console.WriteLine("Saldo atual: " +c2.Saldo);