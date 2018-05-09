using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> SchoolList = new List<Object> { new Student("Mike", "1400 Milwaukee St.", "C#.Net", 2017, 500), new Staff("Martha", "5057 Woodward Ave.", "Wayne State", 1000), new Person("Shawn", "890 Edison") };

            foreach (Object o in SchoolList)
            {
                Console.WriteLine(o.ToString());
            }

        }
    }
}
