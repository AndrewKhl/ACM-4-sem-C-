using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkABC1_3
{
	public static class Tasks
	{
		static public void FirstTasks()
		{
			double a, b, c;	
			while (true)
			{
				Console.Write("Please input a = ");
				string s = Console.ReadLine();
				if (double.TryParse(s, out a))
					break;
				else
					Console.WriteLine("Repeat the command!");
			}

			while (true)
			{
				Console.Write("Please input b = ");
				string s = Console.ReadLine();
				if (double.TryParse(s, out b))
					break;
				else
					Console.WriteLine("Repeat the command!");
			}

			while (true)
			{
				Console.Write("Please input c = ");
				string s = Console.ReadLine();
				if (double.TryParse(s, out c))
					break;
				else
					Console.WriteLine("Repeat the command!");
			}

			SCPU.Task1(a, b, c);
		}

		static public void SecondTasks()
		{
			double a, b, h, e;
			while (true)
			{
				Console.Write("Please input A = ");
				string s = Console.ReadLine();
				if (double.TryParse(s, out a))
					break;
				else
					Console.WriteLine("Repeat the command!");
			}

			while (true)
			{
				Console.Write("Please input B = ");
				string s = Console.ReadLine();
				if (double.TryParse(s, out b))
					break;
				else
					Console.WriteLine("Repeat the command!");
			}

			while (true)
			{
				Console.Write("Please input H = ");
				string s = Console.ReadLine();
				if (double.TryParse(s, out h))
					break;
				else
					Console.WriteLine("Repeat the command!");
			}

			if (a > b)
			{
				Console.WriteLine("Error a > b");
				return;
			}

			if (a + h < a)
			{
				Console.WriteLine("Error a + n < a");
				return;
			}

			while (true)
			{
				Console.Write("Please input e = ");
				string s = Console.ReadLine();
				if (double.TryParse(s, out e))
					break;
				else
					Console.WriteLine("Repeat the command!");
			}

			string ans = "";

			for (double i = a; i <= b; i += h)
			{
				ans += SCPU.Task2(i, e);
				ans += "\n";
			}

			Console.WriteLine(ans);
		}
	}
}
