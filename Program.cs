using System;

namespace RandomPassGen
{
    class RandomPicker
    {
        
        public static string GeneratePassword(int length, string characterset)
        {
            Random random = new Random();
            string password = "";

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, characterset.Length);
                password += characterset[index];
            }

            return password;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Random Password Generator app.");

            //defining the characters to be used in the password
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789"!;
            string specialChars = "!@#$%^&*()_+[]{}|;:,.<>?";
            // end of defining the characters


            // questions to determine the password
            Console.Write("Please enter the length of the password: ");
            var passwordLength = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Do you want to include uppercase ? y/n :  ");
            var includeUppercase = Console.ReadLine().ToLower() == "y";

            Console.WriteLine();

            Console.Write("Do you want to include lowercase ? y/n : ");
            var includeLowercase = Console.ReadLine().ToLower() == "y";

            Console.WriteLine();

            Console.Write("Do you want to include numbers ? y/n :  ");
            var includeNumbers = Console.ReadLine().ToLower() == "y";

            Console.WriteLine();

            Console.Write("Do you want to include symbols ? y/n :  ");
            var includeSymbols = Console.ReadLine().ToLower() == "y";

            Console.WriteLine();

            // questions end

            // inclusion of characters

            string characterset = "";

            if (includeUppercase) characterset += upperCase;

            if (includeLowercase) characterset += lowerCase;
         
            if (includeNumbers) characterset += numbers;
            
            if (includeSymbols) characterset += specialChars;

            // end of inclusion

            if(string.IsNullOrEmpty(characterset))
            {
                Console.WriteLine("Please select at least one character set.");
                return;
            }

            // generating the password
            string password = RandomPicker.GeneratePassword(passwordLength, characterset);

            // end of generating the password

            // displaying the password
            Console.WriteLine($"Your password is: {password}");

            Console.WriteLine($"");

            Console.ReadLine();
        }
    }
}
