using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace ReflectionTask
{
    class User
    {
        private int id;
        private string name;
        private string surname;
        private static int age;

        void GetFullName()
        {
            Console.WriteLine(name+" "+surname);
        }
        void ChangeAge(int newAge)
        {
            age = newAge;
            Console.WriteLine("New age =" + age);
        }

    }
}
