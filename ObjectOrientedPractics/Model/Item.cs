
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
                    throw new ArgumentException();
                }
                if (value.Length>200) 
                {
                    throw new ArgumentException();
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
                    throw new ArgumentException();
                }
                if (value.Length > 1000)
                {
                    throw new ArgumentException();
                }
                _info = value;
            }
        }

        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0) 
                {
                    throw new ArgumentException();
                }
                if (value > 100000)
                {
                    throw new ArgumentException();
                }
                _cost = value;
            }
        }

        public  Item (string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = Idgenerator.GetNextId();
        }
        public Item()
        {

        }

        public override string ToString()
        {
            return Name;
        }

    }
}
