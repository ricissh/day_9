using System;
using System.Collections.Generic;
using System.Text;

namespace day_9
{
    class uzdevums
    {
        //public, private
        public  privatais11;

        public int skaitlis;
        public int Get1()
        {
            return privatais11;
        }
        public void Set1(string value1)
        {
            privatais11 = value1;
        }

        public int Saskaitisana1(string a, string b)
        {
            Izvade1();
            return a + b;
        }

        private void Izvade1()
        {
            Console.WriteLine("tests!");
        }
    }
}