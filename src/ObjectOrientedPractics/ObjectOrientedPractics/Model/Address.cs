namespace ObjectOrientedPractics
{
    public class Address
    {
        /// <summary>
        /// 
        /// </summary>
        private int _index;

        /// <summary>
        /// 
        /// </summary>
        private string _country;

        /// <summary>
        /// 
        /// </summary>
        private string _city;

        /// <summary>
        /// 
        /// </summary>
        private string _street;

        /// <summary>
        /// 
        /// </summary>
        private string _building;

        /// <summary>
        /// 
        /// </summary>
        private string _apartment;

        /// <summary>
        /// 
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.CheckNumberInRange(value, 100000, 999999, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _city = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "Russia";
            City = "Tomsk";
            Street = "Lenina";
            Building = "40";
            Apartment = "428";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="building"></param>
        /// <param name="apartment"></param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
