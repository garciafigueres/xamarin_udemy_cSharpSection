namespace CSharpSection_2.Classes
{
    class BankAccount
    {
        private float balance;

        public float Balance {
            get {
                return balance;
            }

            private set {
                if (value >= 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        private string owner;

        public BankAccount(float balance, string owner)
        {
            this.balance = balance;
            this.owner = owner;
        }

        public float AddBalance(float balanceToBeAdded)
        {
            Balance += balanceToBeAdded;
            return Balance;
        }

        public float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)
        {
            if (balanceCanBeNegative)
                balance += balanceToBeAdded;
            else
                Balance = balance + balanceToBeAdded;

            return Balance;
        }
    }

    class ChildBankAccount : BankAccount
    {
        public string Parent { get; set; }

        public ChildBankAccount(float balance, string owner, string parent) : base(balance, owner)
        {
            Parent = parent;
        }
    }
}
