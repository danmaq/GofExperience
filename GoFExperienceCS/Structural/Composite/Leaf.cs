using System.Collections.Generic;

namespace GoFExperienceCS.Structural.Composite
{
	sealed class Leaf
		: Component
	{

		private readonly IEnumerable<string> dump;

		public Leaf(string name)
			: base(name)
		{
			dump = new string[] { Name };
		}

		public override IEnumerable<string> GetDump()
		{
			return dump;
		}
	}
}
