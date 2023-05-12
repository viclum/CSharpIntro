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
foreach (CashCard card in cardList)
{
    Console.WriteLine("{0} {1}", card.Id, card.Balance);
}

// e)	Write a method Search() with the method signature given below to search and return the cash card in the list that has the given id. 



// better to save the class in a separate file named CashCard.cs
    class CashCard
    {
        // -id:string 
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        //-balance:double
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        /*+CashCard()
         * +CashCard(string,double)
         * +TopUp(double)
         * +Deduct(double):bool
         */
        public CashCard() { }
        public CashCard(string i, double b)
        {
            Id = i;
            Balance = b;
        }
        public void TopUp(double amount)
        {
            Balance += amount;
        }
        public bool Deduct(double amount)
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return "Id:" + Id + " Balance:" + Balance;
        }
    }
/*
    class Student
    {
        private string firstName;
        private string lastName;

        public Student(string fn, string ln)
        {
            FirstName = fn;
            lastName = ln;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }

        // property for LastName

        public void DisplayName()
        {
            Console.WriteLine(firstName);
            // display lastName
        }

        public override string ToString()
        {
            return "FirstName:" + FirstName + " LastName:" + lastName;
        }

    }

*/