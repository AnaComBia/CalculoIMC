using System;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Calculo IMC---");

            Console.Write("\nInforme seu peso em KG: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe sua altura em m: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"\nseu IMC é {imc:N2} Kg/m²");

            if (imc < 17)
            {
                Console.WriteLine("Diagnóstico: Muito abaixo do peso\n");
            }
            else if (imc == 17 || imc <= 18.49 )
            {
                Console.WriteLine("Diagnóstico: Abaixo do peso\n");
            }
            else if (imc == 18.5 || imc <= 24.99)
            {
                Console.WriteLine("Diagnóstico: Peso Normal\n");
            }
            else if (imc == 25 || imc <= 29.99)
            {
                Console.WriteLine("Diagnóstico: Acima do Peso\n");
            }
            else if (imc == 30 || imc <= 34.99)
            {
                Console.WriteLine("Diagnóstico: Obesidade I\n");
            }
            else if (imc == 35 || imc <= 39.99)
            {
                Console.WriteLine("Diagnóstico: Obesidade II (severa)\n");
            }
            else
            {
                Console.WriteLine("Diagnóstico: Obesidade III (mórbida)\n");
            }

        }
    }
}
