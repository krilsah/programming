
namespace ObjectOrientedPractics.View
{
    public partial class UserControl1 : UserControl
    {
        private Item _newestItem = new Item();

        private bool buttonclickflag;
        public UserControl1()
        {
            InitializeComponent();
        }
        private List<Item> _items = new();
        private Item _currentItem;


        private void ItemsTab_Load(object sender, EventArgs e)
        {
            Item item_0 = new Item("Ладно", "Важная информация о новом наборе для рисования", 225.6);
            Item item_1 = new Item("Ладноверсия 2.0", "Разная информация наверное не одинаковая", 25.6);
            Item item_2 = new Item("сосиски", "мясо(2%)", 1.6);
            _items.Add(item_0);
            _items.Add(item_1);
            _items.Add(item_2);
            ItemsListBox.DataSource = _items;
            ItemsListBox.SelectedIndex = 0;
        }


        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is null) { return; }
            _currentItem = ItemsListBox.SelectedItem as Item;
            NameBox.Text = _currentItem.Name;
            DescriptionBox.Text = _currentItem.Info;
            CostBox.Text = _currentItem.Cost.ToString();
            IDbox.Text = _currentItem.Id.ToString();
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;

        }


        private void CostBox_TextChanged(object sender, EventArgs e)
        {
            CostBox.BackColor = Color.White;
            try
            {
                double newCost = double.Parse(CostBox.Text);
                _currentItem.Cost = newCost;
            }
            catch (Exception)
            {
                CostBox.BackColor = Color.Red;
            }
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NameBox.BackColor = Color.White;
            try
            {
                string newName = NameBox.Text;
                _currentItem.Name = newName;
            }
            catch (Exception)
            {
                NameBox.BackColor = Color.Red;
            }
        }
        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            DescriptionBox.BackColor = Color.White;
            try
            {
                string newDescription = DescriptionBox.Text;
                _currentItem.Info = newDescription;
            }
            catch (Exception)
            {
                DescriptionBox.BackColor = Color.Red;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Item _item = new Item($"Откуда мне знать его имя{_items.Count}", $"Тогда мои полномочия всё{_items.Count}", 25);
            _items.Add(_item);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }

    }
}
