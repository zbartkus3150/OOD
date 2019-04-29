using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Minotaur : IToy
    {
        public string name = "";
        public int age = 0;
        public float mass = 0;

        public Minotaur(string n, int a, float m)
        {
            name = n;
            age = a;
            mass = m;
        }
        public float Cost()
        {
            return 250f;
        }

        public string Summary()
        {
            return "I'm a minotaur! " + "My name is " + name + " I am "+ age + " years old " + "I weigh " + mass + "kg " + "I am " + Height() + "cm high ";
        }

        public float Height()
        {
            return 220;
        }
    }
}
