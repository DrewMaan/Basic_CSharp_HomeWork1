using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Form
{
	class Program
	{
		/*

		 * Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
		 * В результате вся информация выводится в одну строчку:
		 *	а) используя  склеивание;
		 *	б) используя форматированный вывод;
		 *	в) используя вывод со знаком $.
		 
		 Выполнил: Касимовский Андрей

		*/

		static void Main(string[] args)
		{
			Console.WriteLine("Hello! Please, fill in form.");

			//Enter name
			Console.Write("Enter your name: ");
			var userName = Console.ReadLine();

			//Enter last name
			Console.Write("Enter your last name: ");
			var userLastName = Console.ReadLine();

			//Enter age
			Console.Write("Enter your age: ");
			var userAge = Console.ReadLine();

			//Enter height
			Console.Write("Enter your height: ");
			var userHeight = Console.ReadLine();

			//Enter weight
			Console.Write("Enter your weight: ");
			var userWeight = Console.ReadLine();

			Console.WriteLine("That is your data:");

			Console.WriteLine("1. Use gluing");
			Console.WriteLine("Name: " + userName + ", last name: " + userLastName + ", age: " + userAge + ", height: " 
							 + userHeight + ", weight: " + userWeight);

			Console.WriteLine("2. Use formatting");
			Console.WriteLine("Name: {0}, last name: {1}, age: {2}, height: {3}, weight: {4}", 
							 userName, userLastName, userAge, userHeight, userWeight);

			Console.WriteLine("3. Use interpolation");
			Console.WriteLine($"Name: {userName}, last name: {userLastName}, age: {userAge}, height: {userHeight}, weight: {userWeight}");
		}
	}
}
