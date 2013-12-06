#pragma once

#include "Component.h"

class Composite : public Component
{
private:
	list<Component *> components;

public:
	Composite(const Component *parent, const char *name);
	virtual ~Composite();

	const char *GetSuffix() const { return "/"; }

	void Add(Component *component);
	void Remove(Component *component);
	void Clear(void);
};

void CompositeTest(void);
