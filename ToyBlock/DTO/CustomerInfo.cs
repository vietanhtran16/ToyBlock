namespace ToyBlock
{
    public class CustomerInfo
    {
        private string Name;
        private string Address;
        private string DueDate;

        public CustomerInfo(string name, string address, string dueDate)
        {
            this.Name = name;
            this.Address = address;
            this.DueDate = dueDate;
        }
        public string GetName()
        {
            return this.Name;
        }
        public string GetAddress()
        {
            return this.Address;
        }

        public string GetDueDate()
        {
            return this.DueDate;
        }
    }
}