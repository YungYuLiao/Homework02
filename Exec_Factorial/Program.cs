using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算數值的階乘
			Console.Write("請輸入欲求階乘之數值: ");
			string input = Console.ReadLine();
			int value = Convert.ToInt32(input);
			int factorial = 1 ;

			for (int i = 1	; i <=value ; i++)
			{
				factorial *= i; //把左方乘右方後再指定給左方
			}
			Console.WriteLine("階乘為 " + factorial);
		}
			
			}

}
