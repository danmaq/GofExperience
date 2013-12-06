#include "stdafx.h"
#include "Singleton/Singleton.h"
#include "Composite/Composite.h"

int main(int, char *[])
{
	SingletonTest();
	cout << "Push any key to exit." << endl;
#pragma warning(suppress: 6031)
	_getch();
	return EXIT_SUCCESS;
}
