using GoFExperienceCS.Creational.Singleton;
using System;
using System.Diagnostics.CodeAnalysis;

namespace GoFExperienceCS
{
	class Program
	{
		[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "args")]
		static void Main(string[] args)
		{
			Singleton.Instance.HelloWorld();
			Console.ReadKey();
		}
	}
}
