using System.Collections.Generic;
using System.Linq;

namespace GoFExperienceCS.Behavioral.Memento
{
	sealed class CareTaker
	{

		private readonly List<IMemento> map = new List<IMemento>();

		public void AddMemento(IMemento memento)
		{
			map.Add(memento);
		}

		public IMemento GetLastMemento()
		{
			return map.Last();
		}
	}
}
