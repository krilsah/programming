
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
                    throw new ArgumentException("Неправильно введенные данные");
                }
                if (value.Length>200)
                {
                    throw new ArgumentException("Слишком длинная строка");
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
                    throw new ArgumentException("Неправильно введенные данные");
                }
                if (value.Length > 500)
                {
                    throw new ArgumentException("Слишком длинная строка");
                }
                _address = value;
            }
        }
    }
}
