namespace GoFExperienceCS.Behavioral.Memento
{
	sealed class Memento<T>
		: IMemento
	{

		public Memento(T value)
		{
			Value = value;
		}

		public object Value
		{
			get;
			private set;
		}
	}
}
