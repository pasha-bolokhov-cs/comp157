// Assignment 2
// By: Pasha Bolokhov <pasha.bolokhov@gmail.com>
//

using System;

namespace assign2 {

	class Trig {

		static void Main() {
			Console.Write("Trig: ");

			string input = Console.ReadLine();

			string[] parts = input.Split(' ');

			if (parts.Length != 2) {
				Console.Error.WriteLine("need two parameters");
				return;
			}

			double degree;
			if (double.TryParse(parts[1], out degree) == false) {
				Console.Error.WriteLine("second parameter must be a number");
				return;
			}

			double radians = degree * Math.PI / 180.0;

			string trig = parts[0].Trim().ToLower();

			switch (trig) {
			case "sin":
				Console.WriteLine(Math.Sin(radians));
				break;
			case "cos":
				Console.WriteLine(Math.Cos(radians));
				break;
			case "tan":
				Console.WriteLine(Math.Tan(radians));
				break;
			default:
				Console.Error.WriteLine("unknown function `" + trig + "'");
				return;
				break;
			}
		}

	}
}


