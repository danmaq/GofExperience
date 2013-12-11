using GoFExperienceCS.Structural.Composite;
using System;

namespace GoFExperienceCS.Structural.Facade
{
	static class Facade
	{

		private static void Main()
		{
			// ある意味これだけでFacadeとして体を成しているので
			// わざわざダミーのモジュールなどを作るまでもない。
			var root = new Composite.Composite("");
			root.Add(new Leaf("boot"));
			root.Add(new Composite.Composite("bin")).Add(new Leaf("ls"));
			var usr = root.Add(new Composite.Composite("usr"));
			usr.Add(new Composite.Composite("local"));
			usr.Add(new Composite.Composite("bin")).Add(new Leaf("perl"));
			usr.Add(new Composite.Composite("share")).Add(new Leaf("redmine"));
			usr.Add(new Composite.Composite("src"));
			root.Add(new Leaf("sbin"));
			root.Add(new Leaf("swap"));
			foreach (var p in root.GetDump())
			{
				Console.WriteLine(p);
			}
			Console.ReadKey();
		}
	}
}
