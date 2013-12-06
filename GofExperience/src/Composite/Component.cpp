#include "../stdafx.h"
#include "Component.h"

Component::Component(const char *name)
{
	this->name = name;
	SetParent(NULL);
}

string Component::GetPath(void) const
{
	const Component *parent = GetParent();
	string result = parent == NULL ? "/" : parent->GetPath();
	return result + GetName();
}
