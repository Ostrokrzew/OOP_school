using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    abstract class Banker
    {
        public string name;

        public Banker(string name)
        {
            this.name = name;
        }

        public abstract float Count(float x, float y);
    }

    class HonestBanker : Banker
    {
        public HonestBanker(string name) : base(name)
        {
            this.name = name;
        }

        public override float Count(float x, float y)
        {
            float sum = x + y;
            return sum;
        }
    }

    class SneakyBanker : Banker
    {
        public SneakyBanker(string name) : base(name)
        {
            this.name = name;
        }

        public override float Count(float x, float y)
        {
            float sum = (x + y) * 0.8f;
            return sum;
        }
    }
}
