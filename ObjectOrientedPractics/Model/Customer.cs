
using System.Xml.Linq;

namespace ObjectOrientedPractics
{
    internal class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

        public int Id { get { return _id; } }

        public string Fullname 
        { 
            get { return _fullname;} 
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                if (value.Length>200)
                {
                    throw new ArgumentException();
                }
                _fullname = value; 

            }
        }

        public string Address
        {
            get { return _address;}
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException();
                }
                if (value.Length > 500)
                {
                    throw new ArgumentException();
                }
                _address = value;
            }
        }
        private List<Customer> _Customers = new();
        private Customer _currentCustomer;

        public Customer(string name, string address)
        {
            Fullname = name;
            Address = address;
            _id = Idgenerator.GetNextId();
        }
        public Customer()
        {

        }
        public override string ToString()
        {
            return Fullname;
        }
    }
}
