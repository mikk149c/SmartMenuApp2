using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp2
{
	public class Binding : IBinding
	{
		public void Call(string id)
		{
			double num1;
			double num2;
			double[] doubleArray;
			Console.Clear();
			switch (id)
			{
				case "Add":
					tryGetDouble(out num1);
					Console.WriteLine("+");
					tryGetDouble(out num2);
					display(CalculatorClass.Add(num1, num2).ToString());
					Console.ReadKey();
					break;
				case "Subtract":
					tryGetDouble(out num1);
					Console.WriteLine("-");
					tryGetDouble(out num2);
					display(CalculatorClass.Subtract(num1, num2).ToString());
					Console.ReadKey();
					break;
				case "Multiply":
					tryGetDouble(out num1);
					Console.WriteLine("x");
					tryGetDouble(out num2);
					display(CalculatorClass.Multiply(num1, num2).ToString());
					Console.ReadKey();
					break;
				case "Divide":
					tryGetDouble(out num1);
					Console.WriteLine("/");
					tryGetDouble(out num2);
					display(CalculatorClass.Divide(num1, num2).ToString());
					Console.ReadKey();
					break;
				case "Sum":
					doubleArray = getDoubleArray();
					display(CalculatorClass.Sum(doubleArray).ToString());
					Console.ReadKey();
					break;
				case "Minimum":
					doubleArray = getDoubleArray();
					display(CalculatorClass.Minimum(doubleArray).ToString());
					Console.ReadKey();
					break;
				case "Maximum":
					doubleArray = getDoubleArray();
					display(CalculatorClass.Maximum(doubleArray).ToString());
					Console.ReadKey();
					break;
				case "Average":
					doubleArray = getDoubleArray();
					display(CalculatorClass.Average(doubleArray).ToString());
					Console.ReadKey();
					break;
				default:
					break;
			}
		}

		private bool tryGetDouble(out double num)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			bool value = double.TryParse(Console.ReadLine(), out num);
			Console.ForegroundColor = ConsoleColor.White;
			return value;
		}

		private double[] getDoubleArray()
		{
			double[] doubleArray = new double[0];
			double num;
			while (tryGetDouble(out num))
			{
				Array.Resize(ref doubleArray, doubleArray.Length+1);
				doubleArray[doubleArray.Length-1] = num;
			}
			return doubleArray;
		}

		private void display(string str)
		{
			Console.WriteLine($"= {str}");
		}
	}
}
