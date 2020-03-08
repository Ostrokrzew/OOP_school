using System;

namespace Figury
{
    class Program
    {
        static void Main(string[] args)
        {
            UseFigure1();
            UseFigure2();
            UseFigure3();
            Square2 square = new Square2(24);
            Line2 line = new Line2(32);
            int number = new Random().Next(64);
            if (number % 2 == 0)
            {
                Test(line);
                Console.WriteLine();
            }
            else
            {
                Test(square);
                Console.WriteLine();
            }
        }

        static void UseFigure1() // Nie robi nic, bo klasa bazowa nie jest abstrakcyjna.
        {
            uint size = 8;
            Figure1[] figures = new Figure1[size];
            for (uint i = 0; i < size; i++) 
            {
                if (i % 2 == 0)
                    figures[i] = new Line1(size);
                else
                    figures[i] = new Square1(size);
            }
            foreach (var figure in figures)
            {
                figure.Draw();
                Console.WriteLine();
            }
        }

        static void UseFigure2()
        {
            string key;
            string readline;
            ulong length = 0;
            do
            {
                Console.WriteLine("Which figure would You like do draw?");
                Console.WriteLine("Line (l) or square (s)");
                key = Console.ReadLine().ToString();
            } while (!(key.ToLower() == "s" || key.ToLower() == "l"));
            if (key == "s")
            {
                do
                {
                    Console.WriteLine("Please, set length of square's side.");
                    readline = Console.ReadLine();
                    try
                    {
                        length = Convert.ToUInt64(readline);
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("You hadn't set proper length");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("You hadn't set proper length");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You hadn't set proper length");
                    }
                } while (length == 0);
                Square2 square = new Square2(length);
                square.Draw();
            }
            if (key == "l")
            {
                do
                {
                    Console.WriteLine("Please, set length of line.");
                    readline = Console.ReadLine();
                    try
                    {
                        length = Convert.ToUInt64(readline);
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("You hadn't set proper length");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("You hadn't set proper length");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You hadn't set proper length");
                    }
                } while (length == 0);
                Line2 line = new Line2(length);
                line.Draw();
            }
            Console.WriteLine();
        }

        static void UseFigure3()
        {
            int length = new Random().Next(64);
            if (length % 2 != 0)
            {
                Square2 square = new Square2(Convert.ToUInt64(length));
                square.Draw();
                Console.WriteLine(square.GetType().ToString());
            }
            if (length % 2 == 0)
            {
                Line2 line = new Line2(Convert.ToUInt64(length));
                line.Draw();
                Console.WriteLine(line.GetType().ToString());
            }
            Console.WriteLine();
        }

        static void Test(Figure2 figure)
        {
            figure.Draw();
            Console.WriteLine();
            if (figure.GetType() == typeof(Square2))
            {
                Console.Write(figure.length ^ 2);
                Console.WriteLine("j^2");
            }
        }
    }
}
