using System;

namespace Week14_Pratikum_0706022110042_AngellieEnnovarynM
{
	internal class Program
	{
		public static void PrimeSeries(int InputNumber) //method of Prime Number 
		{
			int Factorial = 0; int NextNumber = 0; int CheckPrimeNumber = 0; int i; int j;
			for (i = 0; i < InputNumber; i++) 
			{
				for (j = 0; j < InputNumber; j++)
				{
					CheckPrimeNumber = 0;
					while (CheckPrimeNumber == 0)
					{
						NextNumber++; Factorial = 0; int k;
						for (k = 1; k <= NextNumber; k++)
						{
							if (NextNumber % k == 0)
							{
								Factorial++;
							}
						}
						if (Factorial == 2)
							CheckPrimeNumber = 1;
						else
							CheckPrimeNumber = 0;
					}
					Console.Write($"{NextNumber} ".PadLeft(5));
				}
				Console.WriteLine();
			}
		}
		public static void NonPrimeSeries(int InputNumber) //methods of Non Prime Number 
		{
			int Factorial = 0; int NextNumber = 0; int CheckPrimeNumber = 0; int i; int j;
			for (i = 0; i < InputNumber; i++)
			{
				for (j = 0; j < InputNumber; j++)
				{
					CheckPrimeNumber = 0;
					while (CheckPrimeNumber == 0)
					{
						NextNumber++; Factorial = 0;int k;
						for (k = 1; k <= NextNumber; k++)
						{
							if (NextNumber % k == 0)
							{
								Factorial++;
							}
						}
						if (Factorial == 2)
							CheckPrimeNumber = 0;
						else
							CheckPrimeNumber = 1;
					}
					Console.Write($"{NextNumber} ".PadLeft(4));
				}
				Console.WriteLine();
			}

			static void Main(string[] args)
			{
				Console.Write("Input the number: ");
				int InputNumber = Convert.ToInt32(Console.ReadLine());
				if (InputNumber < 2) //the number 1 is not a prime number  
				{
					Console.WriteLine("Sorry your input is wrong, please try it again!");
				}
				else
				{
					Console.WriteLine("The Output : ");
					int Factorial = 0; int i;
					for (i = 1; i <= InputNumber; i++) //checking if that prime number 
					{
						if (InputNumber % i == 0)
						{
							Factorial++;
						}
					}
					if (Factorial == 2)
					{
						PrimeSeries(InputNumber);
					}
					else
					{
						NonPrimeSeries(InputNumber);
					}
				}
			}
		}
	}
}
