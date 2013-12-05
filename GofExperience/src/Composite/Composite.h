#pragma once

#include "Component.h"

class Composite : public Component
{
private:
	list<Component *> components;

public:
	virtual ~Composite();

	void Add(Component *component);
	void Remove(Component *component);
	void Clear(void);
};

void CompositeTest(void);
