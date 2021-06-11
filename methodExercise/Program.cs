using System;

namespace methodExercise
{
	class Program
	{
		public static string Ask(string message)
		{

			Console.WriteLine(message);
			var message2 = Console.ReadLine();
			//Console.WriteLine($"Your name is {message2}");
			return message2;
		}
		static void Main(string[] args)
		{
			//Console.WriteLine("What is your name?");
			//string name = Console.ReadLine();

			//Console.WriteLine("What is your favorite color?");
			//string faveColor = Console.ReadLine();

			//Console.WriteLine("What is your favorite animal?");
			//string faveAnimal = Console.ReadLine();

			//Console.WriteLine("What is your favorite band?");
			//string faveBand = Console.ReadLine();

			//Console.WriteLine($"{name}, why are you painted {faveColor}? Your pet {faveAnimal} is running all around the place because you played {faveBand} on the radio!");

			var askCall = Ask("what is your name?");

			var askCall2 = Ask("What is your favorite color?");

			var askCall3 = Ask("What is your favorite animal?");

			var askCall4 = Ask("What is your favorite band?");

			Console.WriteLine($"{askCall}, why are you painted {askCall2}? Your pet {askCall3} is running all around the place because you played {askCall4} on the radio!");



		}
	}
}
