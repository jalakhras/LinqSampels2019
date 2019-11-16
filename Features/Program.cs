using System;
using System.Collections.Generic;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> sequre = sequreFunction;
            Func<int, int> sequre2 = number => number * number;
            Func<int, int, int> Add = (x, y) => x + y;
            Action<string> write = x => Console.WriteLine(x);

            Action<string,string> writeFullName =(FName,LName) => Console.WriteLine($"Full Name is : {FName} {LName}");

            Console.WriteLine(sequre(10));
            Console.WriteLine(sequre2(10));
            Console.WriteLine(sequre(Add(10,20)));
            write("called Action");

            writeFullName("Jassar", "Mahmoud");

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id=1,Name="Jassar"},
                new Employee {Id=2,Name="Mahmoud"}
            };
            IEnumerable<Employee> sales = new List<Employee>()
            {

                new Employee{Id=3,Name="Jaffar"}
            };
            IEnumerator<Employee> enumerator = developers.GetEnumerator();
            Console.WriteLine(developers.Count());

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }
        }

        private static int sequreFunction(int arg)
        {
            return arg * arg;
        }
    }
}
