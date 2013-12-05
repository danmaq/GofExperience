#include "../stdafx.h"
#include "Singleton.h"

Singleton &Singleton::GetInstance(void)
{
	static Singleton instance;
	return instance;
}

const char *Singleton::GetHelloWorld(void) const
{
	return "Hello, world!";
}

void SingletonTest(void)
{
	cout << Singleton::GetInstance().GetHelloWorld() << endl;
}
