using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//右側對齊星形三角形
			for (int i = 1 ; i < 6 ; i++)
			{
				int length = i;
				int space = 5 - i;

				string result = new string(' ', space) + new string('*', length);
				Console.WriteLine(result);	

			}
			}

			
		}
	}
