using System;

class Program
{
    static void Main()
    {
        string senha = "1234";
        string tentativa = "";

        while (tentativa != senha)
        {
            Console.Write("Digite a senha: ");
            tentativa = Console.ReadLine();
        }

        Console.WriteLine("Acesso permitido!");
    }
}
