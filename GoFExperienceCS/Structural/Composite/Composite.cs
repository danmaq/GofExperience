using System;
using System.Collections.Generic;
using System.Linq;

namespace GoFExperienceCS.Structural.Composite
{
	sealed class Composite
		: Component
	{

		private readonly ICollection<Component> childs = new List<Component>();

		private readonly string[] dump;

		public Composite(string name)
			: base(name)
		{
			dump = new string[] { Name + "/" };
		}

		public T Add<T>(T component)
			where T : Component
		{
			if (component != null)
			{
				childs.Add(component);
			}
			return component;
		}

		public override IEnumerable<string> GetDump()
		{
			var path = dump[0];
			var result = childs.SelectMany(c => c.GetDump(), (co, l) => path + l);
			return dump.Concat(result);
		}

		private static void Main()
		{
			var root = new Composite("");
			root.Add(new Leaf("boot"));
			root.Add(new Composite("bin")).Add(new Leaf("ls"));
			var usr = root.Add(new Composite("usr"));
			usr.Add(new Composite("local"));
			usr.Add(new Composite("bin")).Add(new Leaf("perl"));
			usr.Add(new Composite("share")).Add(new Leaf("redmine"));
			usr.Add(new Composite("src"));
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
