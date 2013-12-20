using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFExperienceCS.Behavioral.Command
{
	class CommandHello
		: ICommand
	{

		private Receiver receiver;

		public void Execute()
		{
			receiver.Action();
		}
	}
}
