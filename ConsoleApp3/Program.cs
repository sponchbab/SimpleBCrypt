using System;
using BC = BCrypt.Net.BCrypt;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Password Hashers!");
            Console.WriteLine();
            Console.WriteLine("Enter a password:");

            string password = Console.ReadLine();

            string passwordHash = BC.HashPassword(password);

            Console.WriteLine("Entered password: " + password);
            Console.WriteLine("Hashed password: " + passwordHash);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Verifying...");

            Console.WriteLine("Enter a password:");
            string testPassword = Console.ReadLine();

            if (BC.Verify(testPassword, passwordHash))
            {
                Console.WriteLine("Login successful.");

            }
            else
            { 
                Console.WriteLine("Login FAILED.");             
            }
        }
    }
}
