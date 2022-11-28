using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma();
                        break;
                case 2: Subtracao();
                        break;
                case 3: Divisao();
                        break;
                case 4: Multiplicacao();
                        break;
                default: Menu();break;
            }

        }

        static void Decisao()
        {
            Console.WriteLine("Você deseja realizar outra operação?");
            Console.WriteLine("1 - Sim ");
            Console.WriteLine("2 - Não ");
            short stay = short.Parse(Console.ReadLine());
            switch(stay)
            {
                case 1: Menu();break;
                default:   Console.WriteLine("Obrigado por utilizar a calculadora C Sharp!");
                           System.Environment.Exit(0);
                           break;
            }

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = valor1 + valor2;

            //Console.WriteLine("O resultado da soma é " + resultado);

            //Interpolando string. $ no começo da string.
            Console.WriteLine($"O resultado da soma é {resultado}");

            //Interpolando string e somando dentro das {}
            //Console.WriteLine($"O resultado da soma é {valor1 + valor2}");
            Console.ReadKey();
            Decisao();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Decisao();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1/valor2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Decisao();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Priemiro valor:");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1*valor2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.ReadKey();
            Decisao();

        }
        
    }
}
