using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.HelpClass
{
	/*
	 
	 * Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
	 
	 Выполнил: Касимовский Андрей
	 */
	class Program
	{
		static void Main(string[] args)
		{
			HelpClass.Print("String 1. Color = Red", 0, 0, ConsoleColor.Red);
			HelpClass.Pause();
		}
	}
}
