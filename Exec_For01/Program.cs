using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//倒星形三角形
			for (int lenth =5 ; lenth >=1 ; lenth--)
			{
				Console.WriteLine(new string('*',lenth));
			}
		}
	}
}
