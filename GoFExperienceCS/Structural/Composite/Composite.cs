using System;
using System.Collections.Generic;
using System.Linq;

namespace GoFExperienceCS.Structural.Composite
{
	sealed class Composite
		: Component
	{

		private readonly ICollection<Component> childs = new List<Component>();

		public Composite(string name)
			: base(name)
		{
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

		public void Remove(Component component)
		{
			childs.Remove(component);
		}

		public void Clear()
		{
			childs.Clear();
		}

		public override IEnumerable<string> GetDump()
		{
			var path = Name + "/";
			var r = childs.SelectMany(c => c.GetDump());
			return r.ToArray();
		}

		private static void Main()
		{
			var root = new Composite("");
			root.Add(new Composite("usr"));
			root.Add(new Composite("local")).Add(new Leaf("Hoge"));
			foreach (var p in root.GetDump())
			{
				Console.WriteLine(p);
			}
			Console.ReadKey();
		}
	}
}
