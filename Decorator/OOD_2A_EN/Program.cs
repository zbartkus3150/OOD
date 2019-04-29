using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IToy doll = new Doll();
            IToy warrior = new Warrior();
            IToy raceDriver = new RaceDriver();
            // Please make sure to put here the code which shows what you've implemented
            doll = new SwordDecorator(doll);
            Console.WriteLine(doll.Cost());
            Console.WriteLine(doll.Summary());
            doll = new HelmetDecorator(doll);
            Console.WriteLine(doll.Cost());
            Console.WriteLine(doll.Summary());
            raceDriver = new DressDecorator(raceDriver, true);
            Console.WriteLine(raceDriver.Cost());
            Console.WriteLine(raceDriver.Summary());
            doll = new JumpDecorator(doll);
            Console.WriteLine(doll.Cost());
            Console.WriteLine(doll.Summary());
            Console.WriteLine(doll.Summary());
            Console.WriteLine(doll.Summary());
            Console.WriteLine(doll.Summary());
            Console.WriteLine(doll.Summary());
            Console.WriteLine(doll.Summary());
            warrior = new DanceDecorator(warrior, "breakdance");
            warrior = new DanceDecorator(warrior, "solo capoeira");
            Console.WriteLine(warrior.Cost());
            Console.WriteLine(warrior.Summary());

            IToy minotaur = new Minotaur("Bob", 32, 86);
            Console.WriteLine(minotaur.Cost());
            Console.WriteLine(minotaur.Summary());
            IToy centaur = new Centaur("Jeff", 42, true);
            Console.WriteLine(centaur.Cost());
            Console.WriteLine(centaur.Summary());
        }
    }
}
