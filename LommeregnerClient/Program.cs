using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LommeregnerClient
{
	class Program
	{
		static void Main(string[] args)
		{
			using(var Client = new ServiceReference1.Service1Client())
			{
				Console.WriteLine("5+5= " + Client.Plus(5, 5));
				Console.WriteLine("5-5= " + Client.Minus(5, 5));
				Console.WriteLine("5*5= " + Client.Gange(5, 5));
				Console.WriteLine("5/5= " + Client.Divider(5, 5));

				Console.WriteLine("All in one method: " + Client.All(35, 4));

				Console.ReadLine();
			}
		}
	}
}
