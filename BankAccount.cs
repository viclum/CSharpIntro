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

        public BankAccount() { }
        public BankAccount(string ano, string ana, double b)
        {
            AccNo = ano;
            AccName = ana;
            Balance = b;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public bool Withdraw(double amount)
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
            return "AccNo:" + AccNo + "\tAccName:" + AccName + "\tBalance:" + Balance;
        }
    }


}