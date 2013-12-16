using GoFExperienceCS.Properties;
using System;

namespace GoFExperienceCS.Structural.Proxy
{
	sealed class RealSubject
		: ISubject
	{

		private readonly string helloWorld = Resources.HELLO_WORLD;

		public static ISubject Instance
		{
			get;
			private set;
		}

		static RealSubject()
		{
			Instance = new RealSubject();
		}

		private RealSubject()
		{
		}

		public void HelloWorld()
		{
			Console.WriteLine(helloWorld);
		}
	}
}
