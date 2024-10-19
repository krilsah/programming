namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Customers = new GroupBox();
            RemoveCustomerButtton = new Button();
            AddCustomerbutton = new Button();
            CustomersListBox = new ListBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            AddressBox = new TextBox();
            label1 = new Label();
            FullNameBox = new TextBox();
            label2 = new Label();
            IDcustomerBox = new TextBox();
            label3 = new Label();
            Customers.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Customers
            // 
            Customers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Customers.Controls.Add(RemoveCustomerButtton);
            Customers.Controls.Add(AddCustomerbutton);
            Customers.Controls.Add(CustomersListBox);
            Customers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Customers.Location = new Point(0, 0);
            Customers.Name = "Customers";
            Customers.Size = new Size(395, 588);
            Customers.TabIndex = 0;
            Customers.TabStop = false;
            Customers.Text = "Customers";
            // 
            // RemoveCustomerButtton
            // 
            RemoveCustomerButtton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveCustomerButtton.AutoSize = true;
            RemoveCustomerButtton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveCustomerButtton.Location = new Point(136, 534);
            RemoveCustomerButtton.Name = "RemoveCustomerButtton";
            RemoveCustomerButtton.Size = new Size(124, 41);
            RemoveCustomerButtton.TabIndex = 1;
            RemoveCustomerButtton.Text = "Remove";
            RemoveCustomerButtton.UseVisualStyleBackColor = true;
            RemoveCustomerButtton.Click += RemoveCustomerButton_Click;
            // 
            // AddCustomerbutton
            // 
            AddCustomerbutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddCustomerbutton.AutoSize = true;
            AddCustomerbutton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddCustomerbutton.Location = new Point(6, 534);
            AddCustomerbutton.Name = "AddCustomerbutton";
            AddCustomerbutton.Size = new Size(124, 41);
            AddCustomerbutton.TabIndex = 0;
            AddCustomerbutton.Text = "Add";
            AddCustomerbutton.UseVisualStyleBackColor = true;
            AddCustomerbutton.Click += AddCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 22);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(368, 499);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(AddressBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FullNameBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(IDcustomerBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(401, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 585);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Customer";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(20, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 623);
            panel1.TabIndex = 7;
            // 
            // AddressBox
            // 
            AddressBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressBox.Location = new Point(91, 77);
            AddressBox.Multiline = true;
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(373, 85);
            AddressBox.TabIndex = 6;
            AddressBox.TextChanged += AddressBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // FullNameBox
            // 
            FullNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameBox.Location = new Point(91, 48);
            FullNameBox.Name = "FullNameBox";
            FullNameBox.Size = new Size(373, 23);
            FullNameBox.TabIndex = 5;
            FullNameBox.TextChanged += FullNameBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(20, 78);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            // 
            // IDcustomerBox
            // 
            IDcustomerBox.Location = new Point(91, 19);
            IDcustomerBox.Name = "IDcustomerBox";
            IDcustomerBox.ReadOnly = true;
            IDcustomerBox.Size = new Size(140, 23);
            IDcustomerBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(20, 49);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 2;
            label3.Text = "FullName:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(Customers);
            Name = "CustomersTab";
            Size = new Size(874, 588);
            Load += CustomersTab_Load;
            Customers.ResumeLayout(false);
            Customers.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Customers;
        private ListBox CustomersListBox;
        private Button AddCustomerbutton;
        private Button RemoveCustomerButtton;
        private GroupBox groupBox1;
        private Panel panel1;
        private TextBox AddressBox;
        private Label label1;
        private TextBox FullNameBox;
        private Label label2;
        private TextBox IDcustomerBox;
        private Label label3;
    }
}
