using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number1 = 9;
			int number2 = 202;
			const int remainder = 1;
			const int dividend = 2;
			string isOddOrEven1 = (number1 % dividend == remainder) ? number1 + "是奇數" : number1 + "是偶數";
			string isOddOrEven2 = (number2 % dividend == remainder) ? number2 + "是奇數" : number2 + "是偶數";
			Console.WriteLine(isOddOrEven1);
			Console.WriteLine(isOddOrEven2);
		}
	}
}
