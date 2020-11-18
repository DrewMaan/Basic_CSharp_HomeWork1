using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.HelpClass
{
	public static class HelpClass
	{
		public static void Print(string message, int x = 0, int y = 0)
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(message);
		}

		public static void Print(string message, int x = 0, int y = 0, ConsoleColor color = ConsoleColor.Green)
		{
			Console.ForegroundColor = color;
			Print(message, x, y);
		}

		public static void Pause()
		{
			Console.ReadKey();
		}

		public static void Pause(string message)
		{
			Console.WriteLine(message);
			Console.ReadKey();
		}
	}
}
