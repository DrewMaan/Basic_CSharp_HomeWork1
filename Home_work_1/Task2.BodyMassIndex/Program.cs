using System;

namespace Task2.BodyMassIndex
{
	/*
	  
	 *Ввести вес и рост человека. 
	 *Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
	 *где m — масса тела в килограммах, h — рост в метрах.
	 
	 Выполнил: Касимовский Андрей

	*/
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

			Console.WriteLine($"You body mass index: {bodyMassIndex:F}.");
		}
	}
}
