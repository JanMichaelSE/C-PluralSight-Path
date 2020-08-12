using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;
            Action<int> write = x => Console.WriteLine(x);

            write(square(add(3, 5)));

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" },
                new Employee { Id = 2, Name = "Frankie" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            // This is basically making a for each from scratch
            //IEnumerator<Employee> enumerator = developers.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name);
            //}

            // Method Syntax
            var query = developers.Where(d => d.Name.Length == 5).OrderBy(d => d.Name);

            var query2 = from employee in developers
                         where employee.Name.Length == 5
                         orderby employee.Name select employee;

            foreach (var employee in query2)
            {
                Console.WriteLine(employee.Name);
            }

            Console.ReadLine();
        }

        
    }
}
