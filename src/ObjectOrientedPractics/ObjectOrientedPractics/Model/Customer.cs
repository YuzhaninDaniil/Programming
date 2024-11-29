namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Аддресс покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает значение поля id.
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
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя. Не может быть больше 500 символов или пустым.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            FullName = "FullName";
            Address = "Address";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">ФИО покупателя.</param>
        /// <param name="address">Адрес покупателя.</param>
        public Customer(string fullName, string address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
        }

        /// <summary>
        /// Возвращает <see cref="FullName"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FullName;
        }
    }
}
