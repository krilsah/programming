
namespace ObjectOrientedPractics
{
    internal class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        public int Id { get { return _id; } }

        public string Name 
        { 
            get{ return _name; }
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Неправильно введеные данные");
                }
                if (value.Length>200) 
                {
                    throw new ArgumentException("Слишком длинная строка");
                }
                _name = value;
            }

        }

        public string Info
        {
            get { return _info; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Неправильно введены данные");
                }
                if (value.Length > 1000)
                {
                    throw new ArgumentException("Слишком длинная строка");
                }
                _info = value;
            }
        }

        public double Cost
        {
            get { return _cost; }
            set
            {
                if (_cost <= 0) 
                {
                    throw new ArgumentException("Неправильно введеное значение");
                }
                if (_cost > 100000)
                {
                    throw new ArgumentException("Слишком дорого");
                }

            }
        }

        public  Item (string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = Idgenerator.GetNextId();
        }
    }
}
