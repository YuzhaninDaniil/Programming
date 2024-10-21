namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о покупателе
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор покупателя
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес покупателя
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает значение поля id
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        ///  Возвращает и задаёт ФИО покупателя. Не может быть больше 200 символов или пустым.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                ValueValidator.IsStringNullOrEmpty(value, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя. Не может быть больше 500 символов или пустым.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"</see>
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            FullName = "FullName";
            Address = new Address();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">ФИО покупателя</param>
        /// <param name="address">Адрес покупателя</param>
        public Customer(string fullName, Address address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
        }

        /// <summary>
        /// Возвращает строку вместо служебной информации
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return FullName;
        }
    }
}
