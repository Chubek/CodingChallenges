// BlackJack.cpp : Created by Chubak Bidpaa at 11/18/2018
//

//#include "stdafx.h"
#include <iostream>
#include <vector>
#include <string>
#include <ctime>
#include <algorithm>
#include <random>
#include <array>
#include <numeric>

struct Card
{

	std::string name;
	int score;

	Card(std::string card_name, int card_score) : name(card_name), score(card_score) {}
};

typedef std::vector<Card> card_vec;

card_vec deck()
{
	card_vec return_deck({ Card("Ace of Clubs", 11), Card("Ace of Diamods", 11),
							Card("Ace of Hearts", 11), Card("Ace of Spades", 11),
							Card("Two of Clubs", 2), Card("Two of Diamonds", 2),
							Card("Two of Hearts", 2), Card("Two of Spades", 2),
							Card("Three of Clubs", 3), Card("Three of Diamonds", 3),
							Card("Three of Hearts", 3), Card("Three of Spades", 3),
		Card("Four of Clubs", 4), Card("Four of Diamonds", 4),
		Card("Four of Hearts", 4), Card("Four of Spades", 4),
		Card("Five of Clubs", 5), Card("Five of Diamonds", 5),
		Card("Five of Hearts", 5), Card("Five of Spades", 5),
		Card("Six of Clubs", 6), Card("Six of Diamonds", 6),
		Card("Six of Hearts", 6), Card("Six of Spades", 6),
		Card("Seven of Clubs", 7), Card("Seven of Diamonds", 7),
		Card("Seven of Hearts", 7), Card("Seven of Spades", 7), 
		Card("Eight of Clubs", 8), Card("Eight of Diamonds", 8),
		Card("Eight of Hearts", 8), Card("Eight of Spades", 8), 
		Card("Nine of Clubs", 9), Card("Nine of Diamonds", 9),
		Card("Nine of Hearts", 9), Card("Nine of Spades", 9),
		Card("Ten of Clubs", 10), Card("Ten of Diamonds", 10),
		Card("Ten of Hearts", 10), Card("Ten of Spades", 10), 
		Card("Jack of Clubs", 10), Card("Jack of Diamonds", 10),
		Card("Jack of Hearts", 10), Card("Jack of Spades", 10), 
		Card("Queen of Clubs", 10), Card("Queen of Diamonds", 10),
		Card("Queen of Hearts", 10), Card("Queen of Spades", 10), 
		Card("King of Clubs", 10), Card("King of Diamonds", 10),
		Card("King of Hearts", 10), Card("King of Spades", 10) });

	return return_deck;
}

int random(int min, int max)
{
	auto seed = std::time(NULL);
	std::mt19937 engine(seed);
	std::uniform_int_distribution<int> dist(min, max);

	return dist(engine);
}


void shuffle(card_vec &adeck)
{
	std::random_shuffle(adeck.begin(), adeck.end());
}

Card draw(card_vec &adeck)
{
	if (adeck.size() > 1)
	{
		shuffle(adeck);
	}

	int index = random(0, adeck.size() - 1);
	Card return_card = adeck[index];
	adeck.erase(adeck.begin() + index);

	return return_card;
}

void deal(card_vec &adeck, card_vec &dealers_cards, card_vec &player_cards)
{
	if (dealers_cards.size() == 0 && player_cards.size() == 0)
	{
		Card dealer_1 = draw(adeck);
		dealers_cards.push_back(dealer_1);
		std::random_shuffle(adeck.begin(), adeck.end());
		Card dealer_2 = draw(adeck);
		dealers_cards.push_back(dealer_2);
		Card player_1 = draw(adeck);
		player_cards.push_back(player_1);
		std::random_shuffle(adeck.begin(), adeck.end());
		Card player_2 = draw(adeck);
		player_cards.push_back(player_2);

	}
	else
	{
		Card dealer_3 = draw(adeck);
		dealers_cards.push_back(dealer_3);
	}
}

std::string blackjack()
{
	card_vec player_cards;
	card_vec dealer_cards;
	card_vec adeck = deck();
	std::vector<int> player_scores;
	std::vector<int> dealer_scores;
	int input;

	deal(adeck, dealer_cards, player_cards);

	for (int i = 0; i < 2; ++i)
	{
		player_scores.push_back(player_cards[i].score);
		dealer_scores.push_back(dealer_cards[i].score);
	}

	auto player_card_1 = player_cards[0].name;
	auto player_card_2 = player_cards[1].name;
	auto dealer_card_1 = dealer_cards[0].name;
	auto dealer_card_2 = dealer_cards[1].name;

	std::cout << "Your cards are: " << player_card_1 << " and " << player_card_2 << std::endl;
	std::cout << "The dealer reveals: " << dealer_card_1 << std::endl;
	std::cout << "Press 1 to Hit or Press 2 to Stay" << std::endl;
	std::cin >> input;

	while (std::accumulate(player_scores.begin(), player_scores.end(), 0) <= 21)
	{
		if (input == 1)
		{
			Card new_card = draw(adeck);
			std::cout << "You were dealt a " << new_card.name << std::endl;
			player_scores.push_back(new_card.score);
			std::cin >> input;
		}
		else if (input == 2)
		{
			break;
		}

	}

	if (std::accumulate(player_scores.begin(), player_scores.end(), 0) > 21)
		return "You're busted!";

	std::cout << "The dealer reveals: " << dealer_card_2 << std::endl;

	if (std::accumulate(dealer_scores.begin(), dealer_scores.end(), 0) > 17)
	{
		if (std::accumulate(dealer_scores.begin(), dealer_scores.end(), 0) >
			std::accumulate(player_scores.begin(), player_scores.end(), 0))
		{
			return "You lose!";
		}
		else
		{
			return "You win!";
		}

	}
	else
	{
		while (std::accumulate(dealer_scores.begin(), dealer_scores.end(), 0) <= 17)
		{
			Card new_card = draw(adeck);
			std::cout << "Dealer reveals: " << new_card.name << std::endl;
			dealer_scores.push_back(new_card.score);
		}
	}

	if (std::accumulate(dealer_scores.begin(), dealer_scores.end(), 0) >
		std::accumulate(player_scores.begin(), player_scores.end(), 0))
	{
		return "You lose!";
	}
	else
	{
		return "You win!";
	}

	
}

int main()
{
	std::cout << blackjack() << std::endl;

    return 0;
}

