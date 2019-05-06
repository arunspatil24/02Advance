using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeExcpetionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() { Name = "Arun", Age = -25 };
            try
            {
                ValidateAge(s.Age);
            }
            catch(InvaildAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(s.Name+"\t"+s.Age);   
        }
        public static void ValidateAge(int age)
        {
                if (age < 0)
                    throw new InvaildAgeException();
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    class InvaildAgeException:Exception
    {
        public InvaildAgeException():base("Invalid Age")
        {
        }


    }

}
