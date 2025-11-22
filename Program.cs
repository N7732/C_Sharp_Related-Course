using System;

namespace Account
{
    class Active
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The ACTIVE Account!\n\n");
            Console.WriteLine("Enter Your Full Names:");
            string FullName = Console.ReadLine();
            Console.WriteLine("Enter Your Email:");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter Your AGE:");
            int Age = int.Parse(Console.ReadLine());
            try
            {
                if (Age > 18)
                {
                    Console.WriteLine("Enter your Phone Number:");
                    string Phone=Console.ReadLine();
                }

                else if (Age < 18 && Age > 10)
                {
                    Console.WriteLine("Enter Your Parent Name:");
                    string ParentName=Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Child Not Allowed to use This Site!:");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Your Input Is Invalid");
            }

            Console.WriteLine("\nThanks For Registering Your Account");
            
        }
    }
}
