#pragma once

class Component
{
private:
	const Component *parent;
	const char *name;

public:
	Component(const char *name);
	virtual ~Component() { }

	inline const Component *GetParent(void) const { return parent; }
	inline void SetParent(const Component *parent) { this->parent = parent; }
	inline const char *GetName(void) const { return name; }
	virtual string GetPath(void) const;
};
