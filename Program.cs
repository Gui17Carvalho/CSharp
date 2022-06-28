using System;

namespace meuPrimeiroProjeto
{
   class Program
   {
       static void Main(string[] args)
       {
         ContaCorrente conta_do_Gui = new ContaCorrente ("Gui", 1909, 40, 20);
         ContaCorrente conta_do_Carvalho = new ContaCorrente ("Carvalho", 2806, 15, 10);
         ContaCorrente conta_do_Araujo = new ContaCorrente ("Araújo", 2004, 19, 09);

         Console.WriteLine("A conta é do (a) " + conta_do_Gui.Titular + ", a agência é " + conta_do_Gui.Agencia + ", o número é " + conta_do_Gui.Numero + " e o saldo é " + conta_do_Gui.Saldo + ".");
         Console.WriteLine("A conta é do (a) " + conta_do_Carvalho.Titular + ", a agência é " + conta_do_Carvalho.Agencia + ", o número é " + conta_do_Carvalho.Numero + " e o saldo é " + conta_do_Carvalho.Saldo + ".");
         Console.WriteLine("A conta é do (a) " + conta_do_Araujo.Titular + ", a agência é " + conta_do_Araujo.Agencia + ", o número é " + conta_do_Araujo.Numero + " e o saldo é " + conta_do_Araujo.Saldo + ".");

       }
   } 
}    

