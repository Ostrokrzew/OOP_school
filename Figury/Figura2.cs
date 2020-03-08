using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    abstract class Figure2
    {
        public ulong length;

        public Figure2(ulong length)
        {
            this.length = length;
        }

        public abstract void Draw();
    }

    class Line2 : Figure2
    {
        public Line2(ulong length) : base(length) { }
        public override void Draw()
        {
            for (ulong i = 0; i < this.length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    class Square2 : Figure2
    {
        public Square2(ulong length) : base(length) { }
        public override void Draw()
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
