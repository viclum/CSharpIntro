namespace CSharpIntro
{
    class BankAccount
    {
        /*-accNo:string
        -accName:string
        -balance:double
        */
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public double Balance { get; set; }
        public BankAccount() 
        { 
            AccNo = "";
            AccName = "";
        }

        public BankAccount(string ano, string ana, double b)
        {
            AccNo = ano;
            AccName = ana;
            Balance = b;
        }
        public void Deposit(double amount)
        {
            // ensure that amount is positive
            if (amount > 0)
            {
                Balance += amount;    
            }
        }
        public bool Withdraw(double amount)
        {
            if (amount < 0)
            {
                return false;
            }
            else if (amount <= Balance)
            {
                Balance = Balance - amount;
                return true;
            }
            else
                return false;
        }
        public override string ToString()
        {
            string str = $"AccNo:{AccNo}\tAccName:{AccName}\tBalance:{Balance}";
            return str;
        }
    }
}