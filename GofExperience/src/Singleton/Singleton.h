#pragma once

class Singleton
{
private:
	Singleton(void) { }
	Singleton(const Singleton &) { }
	Singleton &operator=(const Singleton &) { }
public:
	static Singleton &GetInstance(void);
	const char *GetHelloWorld(void) const;
};

void SingletonTest(void);
