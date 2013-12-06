#include "../stdafx.h"
#include "Composite.h"

void SafeDelete(Component *component)
{
	if (component != NULL)
	{
		delete component;
	}
}

Composite::Composite(const char *name)
	: Component(name)
{
}

Composite::~Composite()
{
	Clear();
}

string Composite::GetPath(void) const
{
	return Component::GetPath() + "/";
}

void Composite::Add(Component *component)
{
	components.push_back(component);
	component->SetParent(this);
}

void Composite::Remove(Component *component)
{
	if (component != NULL)
	{
		components.remove(component);
		component->SetParent(NULL);
		delete component;
	}
}

void Composite::Clear(void)
{
	for_each(components.begin(), components.end(), SafeDelete);
}

void CompositeTest(void)
{
	cout << "Not implemented." << endl;
}
