#include "card.h"

#include <string>

const char* Card::_names[] = { "2","3","4","5","6","7","8","9","10","J","Q","K","A" };
const char* Card::_suits[] = { "\x05","\x04","\x03","\x06" };

Card::Card(Name n, Suit s)
	: _suit(s)
	, _name(n)
{
	// инициализируем текстовое название карты
	_strName = _names[_name];
	_strName += _suits[_suit];
}

const std::string& Card::fullName() const
{
	return _strName;
}

int Card::name() const
{
	return _name + 2;
}

int Card::suit() const
{
	return _suit;
}