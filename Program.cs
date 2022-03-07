using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    internal class Program
    {
        public abstract class Pens
        {
            public abstract void display();
        }

        public class Blue : Pens
        {
            public override void display()
            {
                Console.WriteLine("Blue");
            }
        }

        public class Black : Pens
        {
            public override void display()
            {
                Console.WriteLine("Black");
            }
        }

        public class Red : Pens
        {
            public override void display()
            {
                Console.WriteLine("Red");
            }
        }

            public class MyClass
        {
            public static void Main()
            {
                Pens p;
                p = new Blue();
                p.display();
                p = new Black();
                p.display();
                p = new Red();
                p.display();
                Console.ReadLine();
            }
        }
    }
}
