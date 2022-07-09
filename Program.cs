using System;

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDoGui = new ContaCorrente  ("Gui", 12345, 678, 100);
            ContaCorrente ContaDoKevin = new ContaCorrente  ("Kevin", 12345, 123, 10);
            ContaCorrente ContaDoPhil = new ContaCorrente  ("Phil", 12345, 790, 1000);
            
            Console.WriteLine("A conta é do (a) " + ContaDoGui.Titular + 
            ", a agência é " + ContaDoGui.Agencia + " e o número é " 
            + ContaDoGui.Numero + "Saldo: " + ContaDoGui.Saldo + ".");

            Console.WriteLine("A conta é do (a) " + ContaDoKevin.Titular + 
            ", a agência é " + ContaDoKevin.Agencia + " e o número é " 
            + ContaDoKevin.Numero + "Saldo: " + ContaDoKevin.Saldo  + ".");

            Console.WriteLine("A conta é do (a) " + ContaDoPhil.Titular + 
            ", a agência é " + ContaDoPhil.Agencia + " e o número é " 
            + ContaDoPhil.Numero +  "Saldo: " + ContaDoPhil.Saldo + ".");

            bool sacar_conta1 = ContaDoGui.Sacar(100);
            bool sacar_conta2 = ContaDoKevin.Sacar(100);
            bool sacar_conta3 = ContaDoPhil.Sacar(100);

            Console.WriteLine("A conta é do (a) " + ContaDoGui.Titular + 
            ", a agência é " + ContaDoGui.Agencia + " e o número é " 
            + ContaDoGui.Numero + "Saldo: " + ContaDoGui.Saldo + ".");

            Console.WriteLine("A conta é do (a) " + ContaDoKevin.Titular + 
            ", a agência é " + ContaDoKevin.Agencia + " e o número é " 
            + ContaDoKevin.Numero + "Saldo: " + ContaDoKevin.Saldo  + ".");

            Console.WriteLine("A conta é do (a) " + ContaDoPhil.Titular + 
            ", a agência é " + ContaDoPhil.Agencia + " e o número é " 
            + ContaDoPhil.Numero +  "Saldo: " + ContaDoPhil.Saldo + ".");

            bool Depositar_conta1 = ContaDoGui.Depositar(50);
            bool Depositar_conta2 = ContaDoKevin.Depositar(60);
            bool Depositar_conta3 = ContaDoPhil.Depositar(40);

            Console.WriteLine("A conta é do (a) " + ContaDoGui.Titular + 
            ", a agência é " + ContaDoGui.Agencia + " e o número é " 
            + ContaDoGui.Numero + "Saldo novo: " + ContaDoGui.Saldo + ".");

            Console.WriteLine("A conta é do (a) " + ContaDoKevin.Titular + 
            ", a agência é " + ContaDoKevin.Agencia + " e o número é " 
            + ContaDoKevin.Numero + "Saldo novo: " + ContaDoKevin.Saldo  + ".");

            Console.WriteLine("A conta é do (a) " + ContaDoPhil.Titular + 
            ", a agência é " + ContaDoPhil.Agencia + " e o número é " 
            + ContaDoPhil.Numero +  "Saldo novo: " + ContaDoPhil.Saldo + ".");
        
        }
    }
}

