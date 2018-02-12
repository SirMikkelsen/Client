using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new ServiceReference1.Service1Client())
            {
               var s1 = client.AddStudent("Bruce wayne", "13b", 7);
                

                Console.WriteLine(s1.Name);

                var s2 = client.FindStudent(s1.Name);

                Console.WriteLine(s2.Name);

            }

            Console.ReadKey();
        }
    }
}
