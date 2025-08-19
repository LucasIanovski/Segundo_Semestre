Conta c1 = new Conta (1,"Lucas"); // agora estamos trabalhando no mundo real
Conta c2 = new Conta (2,"Ianovski");

Console.Writeline(c1.Depositar(1000, 1)); // para acessarmos os metodos de c1 temos que usar c1.
Console.Writeline(c1.Depositar(1000, 2));
Console.Writeline(c1.Saldo);

Console.Writeline(c2,Titular + c2.Saldo);

c2.Saldo = 100000;

Console.Writeline(c2,Titular + c2.Saldo);
