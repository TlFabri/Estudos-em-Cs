using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua pontuação: ");
        int pontuacao = Convert.ToInt32(Console.ReadLine());

        if (pontuacao >= 100)
        {
            Console.WriteLine("Parabéns! Você venceu!");
        }
        else
        {
            Console.WriteLine("Tente novamente!");
        }
    }
}
