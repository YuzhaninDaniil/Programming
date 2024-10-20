namespace ObjectOrientedPractics
{
    internal class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

        public int ID { get { return _id; } }
        public string FullName
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(value));
                ValueValidator.IsStringNullOrEmpty(value, nameof(value));
                _fullname = value;
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(value));
                ValueValidator.IsStringNullOrEmpty(value, nameof(value));
                _address = value;
            }
        }

        public Customer()
        {
            
        }

        public Customer(string fullName, string address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
        }
        public override string ToString()
        {
            return FullName;
        }
    }
}
