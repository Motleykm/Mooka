//Motley Kamirah
//ADF
//07/05/2022
//synopsis: Project Innitation
using System;

namespace ADF_2022_MotleyKamirah
{
    public class User
	{// constructors for user Id and password
		public string Name { get; set; }
		public int Id { get; set; }
		public string Password { get; set; }

		public User(string name=  "Kamirah", int id=128907, string password="Kmooka89@")
		{
			Name =name;
			Id = id;
			Password =password ;
		}
        // function logging with user Id and Password
		public static bool Login(User user)
        {
			Console.Clear();
            // validates that the ID is entered correctly
            int userId;
            Console.Write("User ID: ");
            var userIdInput = Console.ReadLine();
            userId = Validation.ValidateInteger(userIdInput);

            string userPassword;
            // validates that the password is entered correctly 
            Console.Write("User Password: ");
            var userPasswordInput = Console.ReadLine();
            userPassword = Validation.ValidateString(userPasswordInput);

            if (user.Id == userId && user.Password == userPassword)
            {// lets us know  that they entered the correct information
                Console.WriteLine("User Found");
                return true;
            }
            // will be displayed if the user enters the wrong information
            Console.WriteLine("User login not recognized");

            return false;
        }
	}
}