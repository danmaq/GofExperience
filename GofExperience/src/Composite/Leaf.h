#pragma once

#include "Component.h"

class Leaf : public Component
{
private:

public:
	Leaf(const char *name);
	virtual ~Leaf() { }

	string GetPath(void) const;
};
