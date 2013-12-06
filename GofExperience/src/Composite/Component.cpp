#include "../stdafx.h"
#include "Component.h"

Component::Component(const Component *parent, const char *name)
{
	this->name = name;
	this->parent = parent;
}
