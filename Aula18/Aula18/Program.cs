using System;
using System.Globalization;
using Microsoft.Win32.SafeHandles;

namespace Aula18
{
    class Aula18
    {
        static void Main()
        {
            string p1 = "computador";
            string p2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5309;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 640.50;
            double medida = 53.234567;

            System.Console.WriteLine($"{p1}, cujo o preço é ${preco1}");
            System.Console.WriteLine($"{p2}, cujo o preco é  ${preco2}");

            System.Console.WriteLine($"\nRegistro: {idade} anos de idade, codigo {codigo} e genero: {genero}");

            System.Console.WriteLine(medida.ToString("F8", CultureInfo.InvariantCulture));


        }
    }
}