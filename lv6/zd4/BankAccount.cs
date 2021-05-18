﻿namespace zd4
{
    class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;
        public BankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }
        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }
        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }

        public Memento StoreState()
        {
            return new Memento(this.ownerName, this.ownerAddress, this.balance);
        }

        public void RestoreState(Memento state)
        {
            this.ownerName = state.OwnerName;
            this.ownerAddress = state.OwnerAddress;
            this.balance = state.Balance;
        }


        public override string ToString()
        {
            return $"{ownerName}, {ownerAddress},{balance}";
        }
    }
}
