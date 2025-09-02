using System;

public class Conta
{
    // Atributos
    public int Numero { get; private set; }
    public double Saldo { get; private set; }
    public string Titular;

    // Construtor
    public Conta(int numero, string titular)
    {
        Numero = numero; 
        Saldo = 0.0;
        Titular = titular;
    }

    // Métodos
    public bool Depositar(double valor, int numero)
    {
        if (Numero != numero || valor <= 0) 
            return false;
        Saldo += valor;       
        return true;
    }

    public bool Sacar(double valor, int numero)
    {
        if (Saldo < valor || Numero != numero || valor < 0) 
            return false;
        Saldo -= valor;
        return true;
    }

    // Getters e Setters
  /*   public int GetNumero()
    {
        return Numero;
    }

    public string GetTitular()
    {
        return Titular;
    }

    public void SetTitular(string titular)
    {
        this.Titular = titular;
    }

    public double GetSaldo()
    {
        return Saldo;
    } */

    // ToString
    public override string ToString()
    {
        return $"\nNúmero: {Numero}\nTitular: {Titular}\nSaldo: {Saldo}";
    }
}
