using System;

namespace inicial2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Meu segundo programa C#!");
            Console.WriteLine("Digite o que compraria com 100 reais");
            

            string bolso =Console.ReadLine();
            Console.WriteLine("Com 100 reais você compraria: " + bolso);
            Console.WriteLine("Dinheiro não traz felicidade, me da o seu dinheiro e seja feliz!");
            
            Console.WriteLine("E o que compraria com 1000 reais?");
            string bolso1 =Console.ReadLine();
            Console.WriteLine("Com 1000.00 reais você compraria: " + bolso1);

            Console.WriteLine("Ainda não está feliz? Não tem dinheiro? ");
            string bolso3 =Console.ReadLine();
            Console.WriteLine("Resposta: " + bolso3);
            Console.WriteLine("vai trabalhar que você fica feliz!");   


        }
    }
}
