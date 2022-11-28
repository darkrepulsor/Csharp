using System;
using System.Threading;

namespace Stopwatch
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
            Console.WriteLine("S - 10s = 10 segundos");
            Console.WriteLine("M - 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("");
            string data = Console.ReadLine().ToLower();
            int size = data.Length;

            if (size > 1)
            {
                Console.WriteLine("Como deseja a contagem:");
                Console.WriteLine("1 - Progressiva");
                Console.WriteLine("2 - regressiva");
                int count = int.Parse(Console.ReadLine());

                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int time = int.Parse(data.Substring(0, data.Length - 1));
                int multiplier = 1;

                if (type == 'm')
                    multiplier = 60;

                PreStart(time * multiplier, count);
            }

            if (size == 1 & int.Parse(data) == 0)
            {
                Console.WriteLine("Bye bye!!");
                Thread.Sleep(1000);
                System.Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("DIGITE UMA OPÇÃO VÁLIDA!!!");
                Thread.Sleep(1000);
                Menu();
            }

        }

        static void PreStart(int time, int count)
        {
            if (count != 1 & count != 2)
            {
                Console.Clear();
                Console.WriteLine("DIGITE UMA OPÇÃO VALIDA!");
            }

            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(500);
            Console.WriteLine("Set...");
            Thread.Sleep(500);
            Console.WriteLine("Go!!!");
            Thread.Sleep(500);

            Start(time, count);
        }
        static void Start(int time, int count)
        {
            switch (count)
            {
                case 1:
                    int currentTime = 0;

                    while (currentTime != time)
                    {
                        Console.Clear();
                        currentTime++;
                        Console.WriteLine(currentTime);
                        Thread.Sleep(1000);
                    }
                    break;

                case 2:
                    for (int backward = time; backward >= 0; backward--)
                    {
                        Console.Clear();
                        Console.WriteLine(backward);
                        Thread.Sleep(1000);
                    }
                    break;
                default:

                    break;
            }


            Console.Clear();
            Console.WriteLine("The End!!!");
            Thread.Sleep(2500);

            Menu();

        }

    }
}

