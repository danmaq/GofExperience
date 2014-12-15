namespace GoFExperienceCS.Behavioral.State
{
	static class Context
	{

		public interface IState
		{
			Func<IContext, IContext> Setup(IContext context);
		}

		public interface IContext
		{

			Func<IContext, IContext> State
			{
				get;
			}

			IState NextState
			{
				get;
			}
		}

	}
}
