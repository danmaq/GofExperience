using GoFExperienceCS.Properties;
using System;

namespace GoFExperienceCS.Creational.Singleton
{
	sealed class Singleton
	{

		private readonly string helloWorld = Resources.HELLO_WORLD;

		public static Singleton Instance
		{
			get;
			private set;
		}

		static Singleton()
		{
			Instance = new Singleton();
		}

		private Singleton()
		{
		}

		public void HelloWorld()
		{
			Console.WriteLine(helloWorld);
		}
	}
}
