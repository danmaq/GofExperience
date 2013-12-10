
using System.Collections.Generic;
namespace GoFExperienceCS.Structural.Composite
{
	abstract class Component
	{

		private readonly string name;

		public string Name
		{
			get
			{
				return name;
			}
		}

		public Component(string name)
		{
			this.name = name;
		}

		abstract public IEnumerable<string> GetDump();
	}
}
