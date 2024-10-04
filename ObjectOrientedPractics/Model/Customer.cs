
using System.Xml.Linq;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит id покупателя, его ФИО и адрес.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;
        private string _fullName;
        private string _address;

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задает ФИО покупателя. При этом проверяет строку: Нельзя быть пустой, нельзя быть длиннее 200 символов.
        /// </summary>
        public string Fullname 
        { 
            get { return _fullName;} 
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                ValueValidator.AssertStringOnLength(value, 200, "Fullname");
                _fullName = value; 

            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя. При этом проверяет строку: Нельзя быть пустой, нельзя быть длиннее 500 символов.
        /// </summary>
        public string Address
        {
            get { return _address;}
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException();
                }
                ValueValidator.AssertStringOnLength(value, 500, "Address");
                _address = value;
            }
        }
        private List<Customer> _Customers = new();
        private Customer _currentCustomer;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="name">
        /// ФИО покупателя.
        /// </param>
        /// <param name="address">
        /// Адрес покупателя
        /// </param>
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
