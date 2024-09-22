namespace ObjectOrientedPractics.View
{
    partial class UserControl1
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
            Items = new GroupBox();
            AddButton = new Button();
            RemoveButton = new Button();
            ItemsListBox = new ListBox();
            groupBoxRight = new GroupBox();
            DescriptionBox = new TextBox();
            label4 = new Label();
            NameBox = new TextBox();
            label3 = new Label();
            CostBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            IDbox = new TextBox();
            Items.SuspendLayout();
            groupBoxRight.SuspendLayout();
            SuspendLayout();
            // 
            // Items
            // 
            Items.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Items.Controls.Add(AddButton);
            Items.Controls.Add(RemoveButton);
            Items.Controls.Add(ItemsListBox);
            Items.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Items.Location = new Point(0, 0);
            Items.Name = "Items";
            Items.Size = new Size(395, 588);
            Items.TabIndex = 2;
            Items.TabStop = false;
            Items.Text = "Items";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(6, 534);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(124, 41);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(136, 534);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(124, 41);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 22);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(368, 499);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // groupBoxRight
            // 
            groupBoxRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxRight.BackColor = SystemColors.ButtonHighlight;
            groupBoxRight.Controls.Add(DescriptionBox);
            groupBoxRight.Controls.Add(label4);
            groupBoxRight.Controls.Add(NameBox);
            groupBoxRight.Controls.Add(label3);
            groupBoxRight.Controls.Add(CostBox);
            groupBoxRight.Controls.Add(label2);
            groupBoxRight.Controls.Add(label1);
            groupBoxRight.Controls.Add(IDbox);
            groupBoxRight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxRight.Location = new Point(401, 0);
            groupBoxRight.Name = "groupBoxRight";
            groupBoxRight.Size = new Size(473, 588);
            groupBoxRight.TabIndex = 3;
            groupBoxRight.TabStop = false;
            groupBoxRight.Text = "Selected Item";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionBox.Location = new Point(10, 282);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(457, 177);
            DescriptionBox.TabIndex = 7;
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(10, 262);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameBox.Location = new Point(10, 132);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(457, 111);
            NameBox.TabIndex = 5;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(10, 112);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // CostBox
            // 
            CostBox.Location = new Point(64, 73);
            CostBox.Name = "CostBox";
            CostBox.Size = new Size(140, 23);
            CostBox.TabIndex = 3;
            CostBox.TextChanged += CostBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(10, 74);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 2;
            label2.Text = "Cost:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(10, 35);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // IDbox
            // 
            IDbox.Location = new Point(64, 34);
            IDbox.Name = "IDbox";
            IDbox.ReadOnly = true;
            IDbox.Size = new Size(140, 23);
            IDbox.TabIndex = 0;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxRight);
            Controls.Add(Items);
            Name = "UserControl1";
            Size = new Size(874, 588);
            Load += ItemsTab_Load;
            Items.ResumeLayout(false);
            groupBoxRight.ResumeLayout(false);
            groupBoxRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Items;
        private Button AddButton;
        private Button RemoveButton;
        private ListBox ItemsListBox;
        private GroupBox groupBoxRight;
        private TextBox DescriptionBox;
        private Label label4;
        private TextBox NameBox;
        private Label label3;
        private TextBox CostBox;
        private Label label2;
        private Label label1;
        private TextBox IDbox;
    }
}
