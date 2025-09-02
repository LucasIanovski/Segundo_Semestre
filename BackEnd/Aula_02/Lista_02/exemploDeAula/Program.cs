using System.Security.Cryptography;

Console.WriteLine("Criando Contas");
Conta c1 = new Conta(1, "Lucas"); // agora estamos trabalhando no mundo real
/* Conta c2 = new Conta(2, "Ianovski");
Console.WriteLine(c1);
Console.WriteLine(c2);

Console.WriteLine("Fazendo Depósitos");
c1.Depositar(2000, 1);
c2.Depositar(5000, 2);
Console.WriteLine(c1);
Console.WriteLine(c2);

Console.WriteLine("Realizando Saques");
c1.Sacar(500, 1);
c2.Sacar(1500, 2); */
Console.WriteLine(c1);
// defina encapsulamento: é uma tecnica para proteger informações de uma classe 
// como implementar? mantem atributos privado e atribui get e set apenas aos atirbutos que voce quer seder acesso 