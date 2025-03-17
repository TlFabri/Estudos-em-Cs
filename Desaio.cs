//🔥 Desafio do Dia
//Crie um programa que peça para o usuário digitar seu nome e idade e, em seguida, exiba uma mensagem personalizada:

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");
    }
}
