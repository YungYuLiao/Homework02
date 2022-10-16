using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//等腰星形三角形
			for (int i = 2  ; i >= 0 ; i--)
			{
				int lenth = 5-2*i ;
				int space = i ;	
				
				string result = new string(' ',space) + new string('*',lenth);
				Console.WriteLine(result);	
			}
		}
	}
}
