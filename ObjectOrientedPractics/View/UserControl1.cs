
namespace ObjectOrientedPractics.View
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private List<Item> _items = new();
        private Item _currentItem;


        private void ItemsTab_Load(object sender, EventArgs e)
        {
            Item item = new Item("Ладно", "infarmazia", 225.6);
            Item item_1 = new Item("Ладноewdwwwed", "infarmadwedwwddwzia", 25.6);
            Item item_2 = new Item("Ладwedewddwewdно", "infarmdwedwdewazia", 1.6);
            _items.Add(item);
            _items.Add(item_1);
            _items.Add(item_2);
            ItemsListBox.DataSource = _items;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItem = ItemsListBox.SelectedItem as Item;
            NameBox.Text = _currentItem.Name;
            DescriptionBox.Text = _currentItem.Info;
            CostBox.Text = _currentItem.Cost.ToString();
            IDbox.Text = _currentItem.Id.ToString();

        }
    }
}
