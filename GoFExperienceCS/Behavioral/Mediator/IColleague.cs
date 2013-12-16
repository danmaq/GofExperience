using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFExperienceCS.Behavioral.Mediator
{
	interface IColleague
	{

		IMediator mediator
		{
			set;
			get;
		}

	}
}
