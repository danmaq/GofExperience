#include "../stdafx.h"
#include "Composite.h"

void SafeDelete(Component *component)
{
	if (component != NULL)
	{
		delete component;
	}
}

Composite::Composite(const Component *parent, const char *name)
	: Component(parent, name)
{
}

Composite::~Composite()
{
	Clear();
}

void Composite::Add(Component *component)
{
	components.push_back(component);
}

void Composite::Remove(Component *component)
{
	components.remove(component);
}

void Composite::Clear(void)
{
	for_each(components.begin(), components.end(), SafeDelete);
}

void CompositeTest(void)
{
	cout << "Not implemented." << endl;
}
