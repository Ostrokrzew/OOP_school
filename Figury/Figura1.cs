using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    class Figure1
    {
        public ulong length;

        public Figure1(ulong length)
        {
            this.length = length;
        }

        public void Draw() { }
    }

    class Line1 : Figure1
    {
        public Line1(ulong length) : base(length) { }
        public new void Draw()
        {
            for (ulong i = 0; i < this.length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    class Square1 : Figure1
    {
        public Square1(ulong length) : base(length) { }
        public new void Draw()
        {
            for (ulong j = 0; j < this.length; ++j)
            {
                for (ulong i = 1; i < this.length; ++i)
                {
                    if (j == 0 || j == (this.length - 1) || i == 1)
                        Console.Write("* ");
                    if (j > 0 && j < (this.length - 1) && i > 0 && i < (this.length - 1))
                        Console.Write("  ");
                    if (i == (this.length - 1))
                        Console.WriteLine("*");

                }
            }
        }
    }
}
