using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BodyMassIndex
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello! Let's calculate your body mass index.");

			//Enter height
			Console.Write("Enter your height (in metres): ");
			var userHeight = Convert.ToDouble(Console.ReadLine());

			//Enter weight
			Console.Write("Enter your weight: ");
			var userWeight = Convert.ToDouble(Console.ReadLine());

			var bodyMassIndex = userWeight / (userHeight * userHeight);

			Console.WriteLine($"You body mass index: {bodyMassIndex:N}.");
		}
	}
}
