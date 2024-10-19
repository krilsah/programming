
namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о товаре и его стоимости.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задает название товара. При этом проверяет строку: Нельзя быть пустой, нельзя быть длиннее 200 символов.
        /// </summary>
        public string Name 
        { 
            get{ return _name; }
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }

        }

        /// <summary>
        /// Возвращает и задает информацию о товаре. При этом проверяет строку: Нельзя быть пустой, нельзя быть длиннее 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                ValueValidator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о цене товара.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0) 
                {
                    throw new ArgumentException();
                }
                if (value > 100000.0)
                {
                    throw new ArgumentException();
                }
                _cost= value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">
        /// Название товара.
        /// </param>
        /// <param name="info">
        /// Информация о товаре.
        /// </param>
        /// <param name="cost">
        /// Стоимость товара.
        /// </param>
        public Item (string name, string info, double cost)
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
