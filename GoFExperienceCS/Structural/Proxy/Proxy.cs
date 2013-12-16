using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFExperienceCS.Structural.Proxy
{
	sealed class Proxy
		: ISubject
	{

		public static ISubject Instance
		{
			get;
			private set;
		}

		static Proxy()
		{
			Instance = new Proxy();
		}

		private Proxy()
		{
			Subject = RealSubject.Instance;
		}

		public ISubject Subject
		{
			get;
			set;
		}

		public void HelloWorld()
		{
			Subject.HelloWorld();
		}

		private void Main()
		{
			// ある意味Builderパターンと似ているというかほぼ同じ。
			// 基底クラスが共通なので代理人として成り立つ。
			// さらに極論するとただのラッパー。
			Proxy.Instance.HelloWorld();
		}
	}
}
