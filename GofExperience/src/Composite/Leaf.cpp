#include "../stdafx.h"
#include "Leaf.h"

Leaf::Leaf(const char *name)
	: Component(name)
{
}

string Leaf::GetPath(void) const
{
	return Component::GetPath() + ".leaf";
}
