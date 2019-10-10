﻿using System;
using System.Globalization;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda conv = new ConversorDeMoeda();

            Console.Write("Qual é a cotação do dólar: ");
            conv.cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares voce vai comprar: ");
            conv.qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = "+conv.Valores().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}