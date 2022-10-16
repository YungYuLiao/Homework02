using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//用迴圈呈現指定的結果
			/* 
			    ++++1
			    +++22
                ++333
                +4444
                5555 */

			for (int number = 1; number <= 5; number++)
			{
				string plus = new string('+', 5 - number); //+號遞減
				Console.Write(plus);

				if (number < 5) //1 22 333 4444
				{
					
					for (int numberOfnumber1_4 = 1 ; numberOfnumber1_4 <= number; numberOfnumber1_4++)
					{
						Console.Write(number);	
					}
					
					Console.Write("\n");
				}
				else //5555
				{
					for (int numberOfnumber5 = 1 ; numberOfnumber5 <=number-1; numberOfnumber5++)
					{
						Console.Write(number);
					}
				}
			}
			Console.WriteLine(); 


		}
	}
}
