using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.SwapVariables
{
	class Program
	{
		static void Main(string[] args)
		{
			//paragraph A
			int number1 = 468;
			int number2 = 135;
			Console.WriteLine($"Original data: {number1} and {number2}.");

			int temp = number1;
			number1 = number2;
			number2 = temp;
			Console.WriteLine($"Result data: {number1} and {number2}.");

			//paragraph B
			number1 = 468;
			number2 = 135;
			Console.WriteLine($"Original data: {number1} and {number2}.");

			number1 ^= number2;
			number2 ^= number1;
			number1 ^= number2;
			Console.WriteLine($"Result data: {number1} and {number2}.");
		}
	}
}
