using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Distance
{
	/*
	  
	 * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
	 *Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
	 * б) Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
	  
	 Выполнил: Касимовский Андрей

	*/
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello! Let's calculate distance among two point.");

			Console.WriteLine("Enter coordinates first point: ");
			Console.Write("X1: ");
			double x1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Y1: ");
			double y1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter coordinates second point: ");
			Console.Write("X2: ");
			double x2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Y2: ");
			double y2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Result (a): {0:F2}.", Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

			Console.WriteLine("Result (b): {0:F2}.", CalculateDistance_TwoPoint(x1, y1, x2, y2));
		}

		static double CalculateDistance_TwoPoint(double x1, double y1, double x2, double y2)
		{
			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		}
	}
}
