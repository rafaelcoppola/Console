using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ExerciciosConsole;


class Program
{
	static void Main()
	{
		welcomeUser();
		calcule();
		countString();
		validateCarPlate();
		date();
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

				Console.WriteLine("\r\n---Informe o segundo valor---\r\n");

				value2 = Console.ReadLine();

				if (value1.Any() && value2.Any())
				{
					string result = Calculation.sum(value1, value2);

					Console.WriteLine($"\r\n---O resultado é {result}---");
					Console.WriteLine("\r\n********************************************\r\n");
				}

				break;
			case "2":
				Console.WriteLine("########### Voce Escolheu Subtrair ###########\r\n");
				Console.WriteLine("---Informe o primeiro valor---\r\n");

				value1 = Console.ReadLine();

				Console.WriteLine("\r\n---Informe o segundo valor---\r\n");

				value2 = Console.ReadLine();

				if (value1.Any() || value2.Any())
				{
					string result = Calculation.subtract(value1, value2);

					Console.WriteLine($"\r\n---O resultado é {result}---");
					Console.WriteLine("\r\n********************************************\r\n");
				}
				break;
			case "3":
				Console.WriteLine("########### Voce Escolheu Multiplicar ###########\r\n");
				Console.WriteLine("---Informe o primeiro valor---\r\n");

				value1 = Console.ReadLine();

				Console.WriteLine("\r\n---Informe o segundo valor---\r\n");

				value2 = Console.ReadLine();

				if (value1.Any() || value2.Any())
				{
					string result = Calculation.multiply(value1, value2);

					Console.WriteLine($"\r\n---O resultado é {result}---");
					Console.WriteLine("\r\n********************************************\r\n");
				}
				break;
			case "4":
				Console.WriteLine("########### Voce Escolheu Multiplicar ###########\r\n");
				Console.WriteLine("---Informe o primeiro valor---\r\n");

				value1 = Console.ReadLine();

				Console.WriteLine("\r\n---Informe o segundo valor---\r\n");

				value2 = Console.ReadLine();

				if (value1.Any() || value2.Any())
				{
					string result = Calculation.divide(value1, value2);

					Console.WriteLine($"\r\n---O resultado é {result}---");
					Console.WriteLine("\r\n********************************************\r\n");
				}

				break;
			case "5":
				Console.WriteLine("########### Voce Escolheu Para fazer a média ###########\r\n");
				Console.WriteLine("---Informe o primeiro valor---\r\n");

				value1 = Console.ReadLine();

				Console.WriteLine("\r\n---Informe o segundo valor---\r\n");

				value2 = Console.ReadLine();

				if (value1.Any() || value2.Any())
				{
					string result = Calculation.average(value1, value2);

					Console.WriteLine($"\r\n---O resultado é {result}---");
					Console.WriteLine("\r\n********************************************\r\n");
				}

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

	static void countString()
	{
		Console.WriteLine("########### Exercício Prático 4 - Contador de caracteres ###########\r\n");
		Console.WriteLine("********************************************");

		Console.WriteLine("---Digite qualquer palavra---\r\n");
		animation();

		string words = Console.ReadLine();

		int count = words.Length;

		Console.WriteLine("\r\n********************************************\r\n");

		Console.WriteLine($"sua palavra contem {count} caracteres\r\n");
		Console.WriteLine("********************************************\r\n");

	}

	static void validateCarPlate()
	{
		Console.WriteLine("########### Exercício Prático 5 - Validacao de placas automotivas ###########\r\n");
		Console.WriteLine("********************************************");

		Console.WriteLine("---Digite uma placa Ex: ABC-1234 ---\r\n");

		string pattern = @"^[A-Z]{3}-\d{4}$";

		animation();

		string plate = Console.ReadLine();

		bool plateIsValid = Regex.IsMatch(plate, pattern);

		string isValid = String.Empty;

		switch(plateIsValid)
		{
			case true:
				isValid = "valida";
				break;
			case false:	
				isValid = "invalida";
			break ;

		}

		Console.WriteLine("\r\n********************************************\r\n");
		Console.WriteLine($"Está placa é {isValid}\r\n");
		Console.WriteLine("********************************************\r\n");
	}

	static void date()
	{
		Console.WriteLine("########### Exercício Prático 6 - Datas ###########\r\n");
		Console.WriteLine("********************************************\r\n");

		DateTime fullDate = DateTime.Now;
		DateOnly _dateOnly = new DateOnly(fullDate.Year, fullDate.Month, fullDate.Day);
		
		string stringFullDate = fullDate.ToString();
		string stringdateOnly = fullDate.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"));
		string stringHourOlny = fullDate.ToString("HH:mm:ss", new CultureInfo("pt-BR"));
		string stringDateMonth = fullDate.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));

		Console.WriteLine($"Formato completo --- {stringFullDate} ---\r\n");
		Console.WriteLine($"Apenas a data no formato --- {stringdateOnly} ---\r\n");
		Console.WriteLine($"Apenas a hora no formato de 24 horas --- {stringHourOlny} ---\r\n");
		Console.WriteLine($"A data com o mês por extenso --- {stringDateMonth} ---\r\n");

		Console.WriteLine("********************************************");


	}
}