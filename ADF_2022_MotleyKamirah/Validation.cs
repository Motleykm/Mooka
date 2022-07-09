//Motley Kamirah
//ADF
//07/05/2022
//synopsis: Project Innitation
using System;
namespace ADF_2022_MotleyKamirah
{
	public class Validation
	{// validates that the user string is not left blank
        public static string ValidateString(string input)
        {
            bool isValid = false;
            while(!isValid)
            {
                if (!string.IsNullOrEmpty(input))
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid input. Try again ");
                    input = Console.ReadLine();
                }
            }

            return input;
        }
        // validates that the user use an integer answer ,when prompted to 
        public static int ValidateInteger(string input)
        {
            bool isValid = false;
            int result = 0;
            while (!isValid)
            {
                if (int.TryParse(input, out result))
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid input. Try again ");
                    input = Console.ReadLine();
                }
            }

            return result;
        }
    }
}