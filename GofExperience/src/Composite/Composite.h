#pragma once

#include "Component.h"

class Composite : public Component
{
private:
	list<Component *> components;

public:
	Composite(const char *name);
	virtual ~Composite();

	string GetPath(void) const;

	void Add(Component *component);
	void Remove(Component *component);
	void Clear(void);
};

void CompositeTest(void);
