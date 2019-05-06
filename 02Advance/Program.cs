using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Advance
{
    [Author("Guru")]
    class Program
    {
        [Author("Arun")]
        static void Main(string[] args)
        {
            int c = Add(10, 20);
            Console.WriteLine(c);
        }

        [Obsolete(message:"Hello")]
        public static int Add(int a,int b)
        {
            return a + b;
        }
    }
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string author)
        {
            Author = author;
        }
        public string Author { get; set; }
    }
}