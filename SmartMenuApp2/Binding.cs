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
					getTwoDoubleWithStringSeperator(out num1, "+", out num2);
					displayResult(CalculatorClass.Add(num1, num2).ToString());
					break;
				case "Subtract":
					getTwoDoubleWithStringSeperator(out num1, "-", out num2);
					displayResult(CalculatorClass.Subtract(num1, num2).ToString());
					break;
				case "Multiply":
					getTwoDoubleWithStringSeperator(out num1, "x", out num2);
					displayResult(CalculatorClass.Multiply(num1, num2).ToString());
					break;
				case "Divide":
					getTwoDoubleWithStringSeperator(out num1, "/", out num2);
					displayResult(CalculatorClass.Divide(num1, num2).ToString());
					break;
				case "Sum":
					doubleArray = getDoubleArray();
					displayResult(CalculatorClass.Sum(doubleArray).ToString());
					break;
				case "Minimum":
					doubleArray = getDoubleArray();
					displayResult(CalculatorClass.Minimum(doubleArray).ToString());
					break;
				case "Maximum":
					doubleArray = getDoubleArray();
					displayResult(CalculatorClass.Maximum(doubleArray).ToString());
					break;
				case "Average":
					doubleArray = getDoubleArray();
					displayResult(CalculatorClass.Average(doubleArray).ToString());
					break;
				default:
					break;
			}
			if (id != "exit") Console.ReadKey();
		}

		private void getTwoDoubleWithStringSeperator(out double num1, string seperator, out double num2)
		{
			tryGetDouble(out num1);
			Console.WriteLine(seperator);
			tryGetDouble(out num2);
		}

		private bool tryGetDouble(out double num)
		{
			ConsoleColor c = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Red;
			bool value = double.TryParse(Console.ReadLine(), out num);
			Console.ForegroundColor = c;
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

		private void displayResult(string str)
		{
			ConsoleColor FC = Console.ForegroundColor;
			ConsoleColor BC = Console.BackgroundColor;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.White;
			Console.WriteLine($"= {str}");
			Console.ForegroundColor = FC;
			Console.BackgroundColor = BC;
		}
	}
}