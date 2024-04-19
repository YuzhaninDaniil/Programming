namespace Programming
{
    public class Contact
    {
        private const string _symbols = "abcdefghijklmnopqrstuvwxyz ";

        private string _email;
        private string _name;
        private string _surname;

        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public Contact()
        {

        }

        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            value = value.ToLower();
            foreach (char c in value)
            {
                if (!_symbols.Contains(c))
                {
                    throw new ArgumentException($"Поле {propertyName} должно содержать толко латиницу");
                }
            }
        }

        public string PhoneNumber { get; set; }

        public string Name
        {
            get { return _name; }

            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }

        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Неправильный формат email");
                }
                _email = value;
            }
        }
    }
}
