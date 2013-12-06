#pragma once

class Component
{
private:
	const Component *parent;
	const char *name;

public:
	Component(const Component *parent, const char *name);
	virtual ~Component() { }

	inline const Component *GetParent(void) const { return parent; }
	inline const char *GetName(void) const { return name; }
	virtual const char *GetSuffix() const = 0;
};
