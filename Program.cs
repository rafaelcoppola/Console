using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;

namespace ExerciciosConsole;


class Program
{
	static void Main()
	{
		//welcomeUser();
		calcule();
	}

	static void welcomeUser()
	{

		Console.WriteLine("########### Exercícios Práticos 1 e 2 ###########\r\n");

		string inputFirstName;
		string inputLastName = String.Empty;

		do
		{
			Console.WriteLine("********************************************");
			Console.WriteLine("---Digite seu primeiro nome---\r\n");

			animation();

			inputFirstName = Console.ReadLine();

			if (inputFirstName.Any())
			{
				Console.WriteLine("\r\n********************************************");
				Console.WriteLine("---Digite seu sobrenome---\r\n");

				animation();

				inputLastName = Console.ReadLine();
			}


			if (inputLastName.Any())
			{
				Console.WriteLine("\r\n********************************************\r\n");

				string welcome = "---Seja bem vindo {0} {1}---";
				string result = string.Format(welcome, inputFirstName, inputLastName);

				Console.WriteLine(result);
				Console.WriteLine("\r\n********************************************\r\n");
				//calcule();

			}

		} while (string.IsNullOrEmpty(inputFirstName) || string.IsNullOrEmpty(inputLastName));

	}

	static void calcule()
	{
		List<string> options = new List<string> { "1 - Soma", "2 - Subtração", "3 - Multiplicação", "4 - Divisão", "5 - Média entre 2 números" };

		Console.WriteLine("########### Exercício Prático 3 - Cálculos Simples ###########\r\n");
		Console.WriteLine("********************************************");

		Console.WriteLine("---Selecione um calculo---\r\n");

		foreach (string option in options)
		{
			Console.WriteLine(option);
		}

		string optionSelected = Console.ReadLine();
		bool optionSelectedIsValid = options.Any(option => option.Contains(optionSelected));

		while (!optionSelectedIsValid)
		{
			Console.WriteLine("---Opção Não Encontrada Selecione Outro Calculo---\r\n");

			optionSelected = Console.ReadLine();
			optionSelectedIsValid = options.Any(option => option.Contains(optionSelected));

		};

		string value1 = String.Empty;
		string value2 = String.Empty;

		switch (optionSelected)
		{
			case "1":
				Console.WriteLine("########### Voce Escolheu Somar ###########\r\n");
				Console.WriteLine("---Informe o primeiro valor---\r\n");

				value1 = Console.ReadLine();

				Console.WriteLine("---Informe o segundo valor---\r\n");

				value2 = Console.ReadLine();

				if (value1.Any() || value2.Any())
				{
					string result = sum(value1, value2);

					Console.WriteLine($"O resultado é {result}\r\n");
				}

				break;
			case "2":
				Console.WriteLine("########### Voce Escolheu Subtrair ###########\r\n");
				Console.WriteLine("---Informe o primeiro valor---\r\n");

				value1 = Console.ReadLine();

				Console.WriteLine("---Informe o segundo valor---\r\n");

				value2 = Console.ReadLine();

				if (value1.Any() || value2.Any())
				{
					string result = subtract(value1, value2);

					Console.WriteLine($"O resultado é {result}\r\n");
				}
				break;
			case "3":
				Console.WriteLine("Multiplicação");
				break;
			case "4":
				Console.WriteLine("Divisão");
				break;
			case "5":
				Console.WriteLine("Média entre 2 números");
				break;
		}

	}

	static void animation()
	{
		string[] animationFrames = ["=)", "=("];
		int animationIndex = 0;

		while (!Console.KeyAvailable)
		{
			Console.Write("\rAguardando " + animationFrames[animationIndex]);

			animationIndex = (animationIndex + 1) % animationFrames.Length;

			Thread.Sleep(500);
		}

		Console.WriteLine("\r\n"); // Limpa a linha da animação
	}

	static string sum(string value1, string value2)
	{
		string pattern = @"[\+\-\*\/]";
		bool value1IsNotValid = Regex.IsMatch(value1, pattern);
		bool value2IsNotValid = Regex.IsMatch(value2, pattern);

		if (value1IsNotValid || value2IsNotValid)
		{
			Console.WriteLine("Valores informados não são validos. Por favor tente novamente!");
			Environment.Exit(0);
		}

		double _value1 = Convert.ToDouble(value1);
		double _value2 = Convert.ToDouble(value2);

		double result = _value1 + _value2;

		return result.ToString();
	}

	static string subtract(string value1, string value2)
	{

		string pattern = @"[\+\-\*\/]";
		bool value1IsNotValid = Regex.IsMatch(value1, pattern);
		bool value2IsNotValid = Regex.IsMatch(value2, pattern);

		if (value1IsNotValid || value2IsNotValid)
		{
			Console.WriteLine("Valores informados não são validos. Por favor tente novamente!");
			Environment.Exit(0);
		}

		double _value1 = Convert.ToDouble(value1);
		double _value2 = Convert.ToDouble(value2);

		double result = _value1 - _value2;

		return result.ToString();
	}
}