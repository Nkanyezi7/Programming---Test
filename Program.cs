using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Password_Generator
{
    class Program
    {
        //list holds characters which are going to be used when password is randomly generated
        static List<char> characters = new List<char>();

        static void Main(string[] args)
        {
            Console.Write("-------------------------------------------");

            Console.Write("Random Password Generator Program");

            Console.Write("--------------------------------------------");

            Console.WriteLine("\n\nHello user, welcome to Nkanyezi's Random Password Generator");

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("\nRule of the program: \nYou will be required to enter a value which will be the length of your password then the program will generate a random password for you");

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");

            //ref needs to be infront of it as it will pass it out
            //addingcharacters is a method which will be called
            AddingCharacters(ref characters);

            //this adds every character in the alphabet
            //foreach (char c in characters)
            //{
            //    Console.WriteLine(c);
            //}

           //it will continuously loop
            //while (true)
            //{
                
            //prompt a user to enter the length of their random password
            Console.WriteLine("Please enter the length of your random password");

            //this will overwrite the passwordlength which will generate the length of password
            int PasswordLength = 0;

            //if it does not work the program will crash
            if (int.TryParse(Console.ReadLine(), out PasswordLength))
            {
                //if it does work
                Console.WriteLine("Your randomly generated password is: " + GeneratingPassword(PasswordLength));
            }
            //}

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("\nThank you and Goodbye user");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }

        //this will restrict the user in terms of the length of the password
        static string GeneratingPassword(int PasswordLength)
        {
            //pass through size or length of password
            StringBuilder stringbuilder = new StringBuilder();

            //as it is a random password generator therefore this is essential
            Random random = new Random();

            int x = 0;

            //x is lower than the length
            while (x < PasswordLength)
            {
                //between 0 and 10
                stringbuilder.Append(characters[random.Next(0, characters.Count)]);

                //increment by 1
                x++;
            }

            return stringbuilder.ToString();
        }

        //going to pass characters through here
        static void AddingCharacters(ref List<char> characters)
        {
            //characters.Add('a'); this would require each character to be typed in manually so a for loop is used instead
            //this loop will add all these characters to the list at the top 
            //lowercase characters
            for (char c = 'a'; c <= 'z'; c++)
            {
                characters.Add(c);
            }

            //uppercase characters
            for (char c = 'A'; c <= 'Z'; c++)
            {
                characters.Add(c);
            }

            //symbols
            for (char c = '!'; c <= '?'; c++)
            {
                characters.Add(c);
            }

            //numbers
            for (char c = '0'; c <= '9'; c++)
            {
                characters.Add(c);
            }
        }   
    }
}