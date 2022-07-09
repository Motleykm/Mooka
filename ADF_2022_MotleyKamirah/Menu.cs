
//Motley Kamirah
//ADF
//07/05/2022
//synopsis: Project Innitation
using System;
using System.Collections.Generic;

namespace ADF_2022_MotleyKamirah
{
	public class Menu
	{
		private string _title;
		private List<string> _menuItems;

		public Menu()
		{
		}

		public void Init(string title, List<string> menuItems)
        {
			_title = title;
			_menuItems = menuItems;
        }
		// gives the program its display color
		public void Display()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=============================");
			Console.WriteLine(_title);
			Console.WriteLine("=============================");
			Console.WriteLine();
			for (int i = 0; i < _menuItems.Count; i++)
			{
				if (_menuItems[i] == "Exit")
				{
					Console.WriteLine();
					Console.WriteLine("[0] " + _menuItems[i]);
					Console.WriteLine();
					Console.WriteLine("---------------------");
				}
				else
				{
					Console.WriteLine($"[{i + 1}] {_menuItems[i]}");
				}
			}
		}
	}
}