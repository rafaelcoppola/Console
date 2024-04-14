using System;
using System.Text.RegularExpressions;

namespace ExerciciosConsole;

public static class Calculation
{
	private static bool validString(string value1, string value2)
	{
		string pattern = @"[\+\-\*\/]";
		bool value1IsNotValid = Regex.IsMatch(value1, pattern);
		bool value2IsNotValid = Regex.IsMatch(value2, pattern);

		return value1IsNotValid || value2IsNotValid;
	}

	public static string sum(string value1, string value2)
	{
		bool valuesIsNotValid = validString(value1, value2);

		if (valuesIsNotValid)
		{
			Console.WriteLine("\r\n########### Valores informados não são validos. Por favor tente novamente! ###########");
			Environment.Exit(0);
		}

		double _value1 = Convert.ToDouble(value1);
		double _value2 = Convert.ToDouble(value2);

		double result = _value1 + _value2;

		return result.ToString();
	}

	public static string subtract(string minuend, string subtrahend)
	{
		bool valuesIsNotValid = validString(minuend, subtrahend);

		if (valuesIsNotValid)
		{
			Console.WriteLine("\r\n########### Valores informados não são validos. Por favor tente novamente! ###########");
			Environment.Exit(0);
		}

		double _minuend = Convert.ToDouble(minuend);
		double _subtrahend = Convert.ToDouble(subtrahend);

		double result = _minuend - _subtrahend;

		return result.ToString();
	}

	public static string multiply(string multiplicand, string multiplier)
	{

		bool valuesIsNotValid = validString(multiplicand, multiplier);

		if (valuesIsNotValid)
		{
			Console.WriteLine("\r\n########### Valores informados não são validos. Por favor tente novamente! ###########");
			Environment.Exit(0);
		}

		double _multiplicand = Convert.ToDouble(multiplicand);
		double _multiplier = Convert.ToDouble(multiplier);

		double result = _multiplicand * _multiplier;

		return result.ToString();
	}

	public static string divide(string numerator, string denominator)
	{
		if (denominator == "0")
		{
			Console.WriteLine("\r\n########### Não é possivel fazer divisão por 0 ###########");
			Environment.Exit(0);
		}

		bool valuesIsNotValid = validString(numerator, denominator);

		if (valuesIsNotValid)
		{
			Console.WriteLine("\r\n########### Valores informados não são validos. Por favor tente novamente! ###########");
			Environment.Exit(0);
		}

		double _numerator = Convert.ToDouble(numerator);
		double _denominator = Convert.ToDouble(denominator);

		double result = _numerator / _denominator;

		return result.ToString();
	}

	public static string average(string value1, string value2)
	{
		bool valuesIsNotValid = validString(value1, value2);

		if (valuesIsNotValid)
		{
			Console.WriteLine("\r\n########### Valores informados não são validos. Por favor tente novamente! ###########");
			Environment.Exit(0);
		}

		string _sum = sum(value1, value2);
		string average = divide(_sum, "2");

		return average;
	}
}
