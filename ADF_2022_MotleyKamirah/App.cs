//Motley Kamirah
//ADF
//07/05/2022
//synopsis: Project Innitation
using System;
using System.Collections.Generic;

namespace ADF_2022_MotleyKamirah
{
	public class App
	{
		private User _activeUser;
		private bool _loggedIn;
		private Menu _menu;

		public App()
		{// variables  for menu  options 
			 _menu = new Menu();
			_menu.Init("Main Menu", new List<string>
			{   "Create User",
				"Login",
				"About",
				"Exit"
			}) ;

			_menu.Display();

			_loggedIn = false;

			Selection();
		}
		// function to allow user to select their option
		public void Selection()
        {
			Console.Write("Select a Menu Option: _");
			var optionInput = Console.ReadLine();
			int option;
            
            
				option = Validation.ValidateInteger(optionInput);

			if (_loggedIn == true)
            {
				switch (option)
				{
					case 0:
						Exit();
						break;
					case 1:
						About();
						break;
					case 2:
						SignOut();
						break;
					default:
						break;
				}
			}
            else {
				switch (option)
				{
					case 0:
						Exit();
						break;
					case 1:
						CreateUser();
						break;
					case 2:
						SignIn();
						break;
					case 3:
						About();
						break;
					default:
						break;
				}
			}
			
        }
		public void CreateUser()
        {
			Console.Clear();
			Console.Write("UserName: ");
			string userName = Console.ReadLine();
			userName = Validation.ValidateString(userName);
			Console.Write("Password: ");
			string password = Console.ReadLine();
			password = Validation.ValidateString(password);
			_activeUser = new User(userName,123456,password);
			Continue();
		
        }




		// allows user to login
		public void SignIn()
        {
			Console.Clear();
			bool loggedIn = User.Login(_activeUser);
			if (loggedIn == true)
			{
				_menu.Init("Welcome " + _activeUser.Name + "!", new List<string> { "About", "Logout", "Exit" });
				_loggedIn = true;
			}
			Continue();
        }
		public void SignOut()
        {
			_loggedIn = false;
			Continue();
        }

		// tells use about the program 
		public void About()
        {
			Console.Clear();
			Console.WriteLine("This is the about section.");
			Continue();
        }
		// allows user to exit the program
		public void Exit()
        {
			Console.Clear();
			Console.WriteLine("Exiting");
			return;
        }
		// if the user wants to continue with the program 
		public void Continue()
        {
			Console.Write("Press any key to continue...");
			Console.ReadKey();
			Console.Clear();
			_menu.Display();
			Selection();

            
        }
	}
}