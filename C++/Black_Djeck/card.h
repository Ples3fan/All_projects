#pragma once
#include <string>

enum Suit {
	clubs
	, diamonds
	, hearts
	, spades
	, first_suit = clubs
	, last_suit = spades
};

enum Name {
	two
	, three
	, four
	, five
	, six
	, seven
	, eight
	, nine
	, ten
	, jack
	, queen
	, king
	, ace
	, first_name = two
	, last_name = ace
};

class Card
{
public:
	Card(Name n, Suit s);
	const std::string& fullName() const;
	int name() const;
	int suit() const;

private:
	Name _name;
	Suit _suit;
	std::string _strName;

	static const char* _names[];
	static const char* _suits[];
};