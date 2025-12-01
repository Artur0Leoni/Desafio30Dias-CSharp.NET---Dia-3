using System;
using System.ComponentModel;


class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;


        while (continuar)
        {
            Console.WriteLine("Conversor de Temperatura");


            Console.WriteLine("Escolha a unidade de origem:");
            Console.WriteLine("1 - Celsius");
            Console.WriteLine("2 - Fahrenheit");
            Console.Write("Opção: ");


            if (!int.TryParse(Console.ReadLine(), out int origem) || origem < 1 || origem > 2)
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }
            Console.WriteLine("Escolha a unidade de destino: ");
            Console.WriteLine("1 - Celsius");
            Console.WriteLine("2 - Fahrenheit");
            Console.Write("Opção: ");

            if (!int.TryParse(Console.ReadLine(), out int destino) || destino < 1 || destino > 2)
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }

            Console.Write("Digite o valor da temperatura: ");
            if (!double.TryParse(Console.ReadLine(), out double valor))
            {
                Console.WriteLine("Valor inválido!");
                continue;
            }


            double resultado = ConverterTemperatura(origem, destino, valor);
            Console.WriteLine($"Resultado: {resultado}");


            Console.Write("Deseja converter novamente ? (s / n) : ");
            continuar = Console.ReadLine().ToLower() == "s";


            Console.Clear();
        }


        Console.WriteLine("Encerrando o programa.");
    }


    static double ConverterTemperatura(int origem, int destino, double valor)
    {
        if (origem == destino)
            return valor;


        // Celsius → Fahrenheit
        if (origem == 1 && destino == 2)
            return (valor * 9 / 5) + 32;


        // Fahrenheit → Celsius
        if (origem == 2 && destino == 1)
            return (valor - 32) * 5 / 9;


        return valor;
    }
}