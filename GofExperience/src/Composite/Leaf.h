#pragma once

#include "Component.h"

class Leaf : public Component
{
private:

public:
	Leaf(const Component *parent, const char *name);
	virtual ~Leaf() { }

	const char *GetSuffix() const { return ""; }
};
