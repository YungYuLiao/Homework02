using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//呈現1~20, 若是3的倍數顯示 foo, 若是5的倍數顯示bar, 若是15的倍數顯示foobar, 其餘顯示數值

			for (int value = 1; value <= 20; value++)
			{
				int value1 = value % 3;
				int value2 = value % 5;

				if (value1 == 0 && value2 == 0)
				{
					Console.WriteLine("foobar");
				}
				else if (value1 == 0)
				{
					Console.WriteLine("foo");
				}
				else if (value2 == 0)
				{
					Console.WriteLine("bar");
				}
				else
				{
					Console.WriteLine(value);
				}
				

			}
			
		}
		}
	}

