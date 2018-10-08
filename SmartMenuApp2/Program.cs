using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Program myProgram = new Program();
			myProgram.Run();
		}

		private void Run()
		{
			SmartMenu menu = new SmartMenu();
			menu.LoadMenu("TestMenu.txt");
			menu.Activate();
		}
	}
}
