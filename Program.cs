using System;

//[console: Cebolinha] Solicite que o usuário digite uma frase. Exiba a frase como se ela fosse dita pelo Cebolinha, da Turma da Mônica.
namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite uma frase:");
            string frase = Console.ReadLine();
            string flase = frase.Replace("r", "l")
                                .Replace("R","L");
            Console.WriteLine(flase);
            
            //Console.WriteLine($"O usuário digitou {frase} e o Cebolinha falou {frase}");
        }
    }
}
