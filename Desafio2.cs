using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int numero = rnd.Next(1, 11); // Número entre 1 e 10
        int tentativa = 0;

        Console.WriteLine("Tente adivinhar o número de 1 a 10!");

        while (tentativa != numero)
        {
            Console.Write("Digite um número: ");
            tentativa = Convert.ToInt32(Console.ReadLine());

            if (tentativa > numero)
            {
                Console.WriteLine("O número é menor!");
            }
            else if (tentativa < numero)
            {
                Console.WriteLine("O número é maior!");
            }
        }

        Console.WriteLine("Parabéns! Você acertou!");
    }
}
