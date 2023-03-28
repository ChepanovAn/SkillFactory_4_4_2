using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_4_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.WriteLine("Введитя имя");
            anketa.name = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            anketa.age =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя - {0}", anketa.name);
            Console.WriteLine("Ваш возраст - {0}", anketa.age);
            Console.ReadKey();


        }
    }
}
