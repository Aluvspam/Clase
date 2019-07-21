using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teme
{
	class TemeMain
	{
		static void Main(string[] args)
		{
			//CountDown(20);
			
			Console.WriteLine(Euclid(30, 20));
		
			Cmmdc(20, 15);
			Console.Read();
		}

		static void CountDown(int num)
		{
			if (num < 0)
				return;

			Console.WriteLine(num + "...");
			CountDown(num - 1);

			Factorial factorial = new Factorial();
			Console.WriteLine(factorial.Factorial1(3));
		}
		static int Cmmdc(int a, int b)
		{
			if (a == b)
			{
				return a;
			}
			if (a > b)
			{
				return Cmmdc(b,a-b);
			}
			else
			{
				return Cmmdc(a, b - a);
			}
		}

	  

		static int Euclid(int a, int b)
		{
			int c;
		   
			while (b != 0) {
				c = a % b;
				a = b;
				b = c;
			}
			return a;
		}

		static int Cmmdc(int[] array)
			{
			if(array.Length <= 2)
				{
				// toDo: write code for cases when array has no elements
				return Cmmdc(array[0], array[array.Length -1]);
				}
			else
				int[] numere = new int[array.Length-1];
			for (int i = 0; i < numere.Length-2; i++)
			{
				numere[i] = array[i];
			}
			numere[array.Length-2] = Cmmdc(array[array.Length-2], array[array.Length-2]);

		   return Cmmdc(numere);
		}
	}
				 
}
