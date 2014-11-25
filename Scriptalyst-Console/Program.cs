using System;
using MoonSharp.Interpreter;

namespace ScriptalystConsole
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			UserData.RegisterType<ScriptalystConsole>();

			Script script = new Script ();

			DynValue scriptalystConsole = UserData.Create(new ScriptalystConsole());

			script.Globals.Set("scriptalyst", scriptalystConsole);

			script.RunFile ("scriptalyst.lua");
		}
	}
}
