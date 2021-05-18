namespace zd4
{
    public class Memento
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }

        public Memento(string ownername, string owneraddress, decimal balance)
        {
            this.OwnerName = ownername;
            this.OwnerAddress = owneraddress;
            this.Balance = balance;
        }
    }
}