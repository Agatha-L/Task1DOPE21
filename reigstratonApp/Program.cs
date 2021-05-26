using System;

namespace reigstratonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USER REGISTRATION");
            Console.WriteLine("Account with UserName: ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.WriteLine("Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}  {1} years", name, age);
            
         }
    }
}
