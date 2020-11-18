using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.OutPutDataFormat
{
	/*
	  
	 * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
	 * б) Сделать задание, только вывод организовать в центре экрана.
	 * в) Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
	 
	 Выполнил: Касимовский Андрей
	*/
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();

			Console.Write("Enter your last name: ");
			string lastName = Console.ReadLine();

			Console.Write("Enter your city: ");
			string city = Console.ReadLine();

			//paragraph A
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Last name: {lastName}");
			Console.WriteLine($"City: {city}");

			//paragraph B
			int centerX = Console.WindowWidth / 2;
			int centerY = Console.WindowHeight / 2;

			Console.SetCursorPosition(centerX, centerY);
			Console.WriteLine($"Name: {name}");
			Console.SetCursorPosition(centerX, centerY + 1);
			Console.WriteLine($"Last name: {lastName}");
			Console.SetCursorPosition(centerX, centerY + 2);
			Console.WriteLine($"City: {city}");

			//paragraph C
			int newX = Convert.ToInt32(Console.WindowWidth / 2);
			int newY = Convert.ToInt32(Console.WindowHeight * 0.75);
			string message = "Some message";
			Print(newX, newY, message);
		}

		public static void Print(int x, int y, string message)
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(message);
		}
	}
}
