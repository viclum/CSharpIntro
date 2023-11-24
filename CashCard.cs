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
