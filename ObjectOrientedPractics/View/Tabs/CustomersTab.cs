
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {

        private Customer _newestCustomer = new Customer();

        public CustomersTab()
        {
            InitializeComponent();
        }


        private List<Customer> _Customers = new();
        private Customer _currentCustomer;

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            Customer customer_1 = new Customer("Михаил", "он забыл");
            Customer customer_2 = new Customer("Евгений", "Недалеко от Миши");
            Customer customer_3 = new Customer("Ксения", "Дома");
            _Customers.Add(customer_1);
            _Customers.Add(customer_2);
            _Customers.Add(customer_3);
            CustomersListBox.DataSource = _Customers;
            CustomersListBox.SelectedIndex = 0;
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is null) { return; }
            _currentCustomer = CustomersListBox.SelectedItem as Customer;
            FullNameBox.Text = _currentCustomer.Fullname;
            AddressBox.Text = _currentCustomer.Address;
            IDcustomerBox.Text = _currentCustomer.Id.ToString();
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _Customers;
        }

        private void FullNameBox_TextChanged(object sender, EventArgs e)
        {
            FullNameBox.BackColor = Color.White;
            try
            {
                string newname = FullNameBox.Text;
                _newestCustomer.Fullname = newname;
            }
            catch (Exception)
            {
                FullNameBox.BackColor = Color.Red;
            }
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            AddressBox.BackColor = Color.White;
            try
            {
                string newAddress = AddressBox.Text;
                _newestCustomer.Address = newAddress;
            }
            catch (Exception)
            {
                AddressBox.BackColor = Color.Red;
            }
        }
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer _customer = new Customer($"Откуда мне знать его имя{_Customers.Count}", "Живет");
            _Customers.Add(_customer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _Customers;
        }
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            _Customers.Remove(_currentCustomer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _Customers;
        }
    }
}
