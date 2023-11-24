using System;
using System.Collections.Generic;
// b)	Write a method InitCardList() to create 5 CashCard objects 
void InitCardList(List<CashCard> cardList)
{
    CashCard card1 = new CashCard("001", 25);
    cardList.Add(card1);
}

// a)	Create a List<CashCard> named cardList for storing CashCard objects.
List<CashCard> cardList = new List<CashCard>();
// c)	Call the InitCardList().
InitCardList(cardList);
// d)	Display the id and balance of all the CashCard objects.
Console.WriteLine($"{"Id",-3} {"Balance"}");
foreach (CashCard card in cardList)
{
    Console.WriteLine("{0:-3} {1:N2}", card.Id, card.Balance);
}

// e)	Write a method Search() with the method signature given below to search and return the cash card in the list that has the given id. 



