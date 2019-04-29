using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Centaur : IToy
    {
        public string name = "";
        public int age = 0;
        public bool beard = true;

        public Centaur(string n, int a, bool b)
        {
            name = n;
            age = a;
            beard = b;
        }
        public float Cost()
        {
            return 250f;
        }

        public string Summary()
        {
            if (beard == true)
                return "I'm a centaur! " + "My name is " + name + " I am " + age + " years old " + "I have a beard " + "I am " + Height() + "cm high ";
            else
                return "I'm a centaur! " + "My name is " + name + " I am " + age + " years old " + "I don't have a beard " + "I am " + Height() + "cm high ";
        }

        public float Height()
        {
            return 210;
        }
    }
}
