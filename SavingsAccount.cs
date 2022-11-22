namespace CSharpIntro
{
    class SavingsAccount : BankAccount
    {
        public double Rate { get; set; }
        public SavingsAccount() :base()
        {
        }
        public SavingsAccount(string ano, string ana, double b, double r) : base(ano, ana, b)
        {
            Rate = r;
        }
        // +CalculateInterest():double
        public double CalculateInterest()
        {
            return Balance * Rate / 100;
        }
        public override string ToString()
        {
            return base.ToString() + "\tRate:" + Rate;
        }
    }

}
