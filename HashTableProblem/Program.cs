using System;

namespace HashTableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program!");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");
            
            string result0 = hash.Get("0");
            Console.WriteLine("The Frequency of To : " + result0);

            string result1 = hash.Get("1");
            Console.WriteLine("The Frequency of be : " + result1);
            string result2 = hash.Get("2");
            Console.WriteLine("The Frequency of or : " + result2);
            string result3 = hash.Get("3");
            Console.WriteLine("The Frequency of not : " + result3);
        }
    }
}
