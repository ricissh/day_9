using System;
using System.Collections.Generic;
using System.Text;

namespace day_9
{
    class Test
    {
        //public, private
        public int privatais1;

        public int skaitlis;
        public int Get()
        {
            return privatais1;
        }
        public void Set(int value)
        {
            privatais1 = value;
        }

        public int Saskaitisana(int a, int b)
        {
            Izvade();
            return a + b;
        }

        private void Izvade()
        {
            Console.WriteLine("tests!");
        }
    }
}