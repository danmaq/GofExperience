#include "stdafx.h"
#include "Composite/Composite.h"

int main(int, char *[])
{
	CompositeTest();
	cout << "Push any key to exit." << endl;
#pragma warning(suppress: 6031)
	_getch();
	return EXIT_SUCCESS;
}
