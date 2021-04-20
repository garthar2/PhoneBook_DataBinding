
namespace PhoneBook_DataBinding
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label yearOfBirthLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.phonebookListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.phonebookListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.phoneBookDataGridView = new System.Windows.Forms.DataGridView();
            this.credentialsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credentialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.genderCheckBox = new System.Windows.Forms.CheckBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.yearOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            firstNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            yearOfBirthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookListBindingNavigator)).BeginInit();
            this.phonebookListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // phonebookListBindingNavigator
            // 
            this.phonebookListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phonebookListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phonebookListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phonebookListBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.phonebookListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.phonebookListBindingNavigatorSaveItem});
            this.phonebookListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phonebookListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phonebookListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phonebookListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phonebookListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phonebookListBindingNavigator.Name = "phonebookListBindingNavigator";
            this.phonebookListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phonebookListBindingNavigator.Size = new System.Drawing.Size(1232, 27);
            this.phonebookListBindingNavigator.TabIndex = 3;
            this.phonebookListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // phonebookListBindingNavigatorSaveItem
            // 
            this.phonebookListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phonebookListBindingNavigatorSaveItem.Enabled = false;
            this.phonebookListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phonebookListBindingNavigatorSaveItem.Image")));
            this.phonebookListBindingNavigatorSaveItem.Name = "phonebookListBindingNavigatorSaveItem";
            this.phonebookListBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.phonebookListBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // phoneBookDataGridView
            // 
            this.phoneBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneBookDataGridView.Location = new System.Drawing.Point(76, 91);
            this.phoneBookDataGridView.Name = "phoneBookDataGridView";
            this.phoneBookDataGridView.RowHeadersWidth = 51;
            this.phoneBookDataGridView.RowTemplate.Height = 24;
            this.phoneBookDataGridView.Size = new System.Drawing.Size(300, 220);
            this.phoneBookDataGridView.TabIndex = 4;
            // 
            // credentialsDataGridView
            // 
            this.credentialsDataGridView.AutoGenerateColumns = false;
            this.credentialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.credentialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn13});
            this.credentialsDataGridView.DataSource = this.credentialsBindingSource;
            this.credentialsDataGridView.Location = new System.Drawing.Point(393, 91);
            this.credentialsDataGridView.Name = "credentialsDataGridView";
            this.credentialsDataGridView.RowHeadersWidth = 51;
            this.credentialsDataGridView.RowTemplate.Height = 24;
            this.credentialsDataGridView.Size = new System.Drawing.Size(687, 220);
            this.credentialsDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn10.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn11.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn12.HeaderText = "MiddleName";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Gender";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Gender";
            this.dataGridViewCheckBoxColumn3.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "YearOfBirth";
            this.dataGridViewTextBoxColumn13.HeaderText = "YearOfBirth";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // credentialsBindingSource
            // 
            this.credentialsBindingSource.DataSource = typeof(PhoneBook_DataBinding.Credentials);
            // 
            // phoneBookBindingSource
            // 
            this.phoneBookBindingSource.DataSource = typeof(PhoneBook_DataBinding.PhoneBook);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(449, 323);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 6;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(549, 320);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(449, 353);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 17);
            genderLabel.TabIndex = 8;
            genderLabel.Text = "Gender:";
            // 
            // genderCheckBox
            // 
            this.genderCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.credentialsBindingSource, "Gender", true));
            this.genderCheckBox.Location = new System.Drawing.Point(549, 348);
            this.genderCheckBox.Name = "genderCheckBox";
            this.genderCheckBox.Size = new System.Drawing.Size(200, 24);
            this.genderCheckBox.TabIndex = 9;
            this.genderCheckBox.Text = "checkBox1";
            this.genderCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(449, 381);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(549, 378);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.lastNameTextBox.TabIndex = 11;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(449, 409);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(94, 17);
            middleNameLabel.TabIndex = 12;
            middleNameLabel.Text = "Middle Name:";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialsBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(549, 406);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.middleNameTextBox.TabIndex = 13;
            // 
            // yearOfBirthLabel
            // 
            yearOfBirthLabel.AutoSize = true;
            yearOfBirthLabel.Location = new System.Drawing.Point(449, 438);
            yearOfBirthLabel.Name = "yearOfBirthLabel";
            yearOfBirthLabel.Size = new System.Drawing.Size(94, 17);
            yearOfBirthLabel.TabIndex = 14;
            yearOfBirthLabel.Text = "Year Of Birth:";
            // 
            // yearOfBirthDateTimePicker
            // 
            this.yearOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.credentialsBindingSource, "YearOfBirth", true));
            this.yearOfBirthDateTimePicker.Location = new System.Drawing.Point(549, 434);
            this.yearOfBirthDateTimePicker.Name = "yearOfBirthDateTimePicker";
            this.yearOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.yearOfBirthDateTimePicker.TabIndex = 15;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 598);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderCheckBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(yearOfBirthLabel);
            this.Controls.Add(this.yearOfBirthDateTimePicker);
            this.Controls.Add(this.credentialsDataGridView);
            this.Controls.Add(this.phoneBookDataGridView);
            this.Controls.Add(this.phonebookListBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Телефонный справочник (обобщающий класс)";
            ((System.ComponentModel.ISupportInitialize)(this.phonebookListBindingNavigator)).EndInit();
            this.phonebookListBindingNavigator.ResumeLayout(false);
            this.phonebookListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingNavigator phonebookListBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton phonebookListBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView phoneBookDataGridView;
        private System.Windows.Forms.BindingSource phoneBookBindingSource;
        private System.Windows.Forms.BindingSource credentialsBindingSource;
        private System.Windows.Forms.DataGridView credentialsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.CheckBox genderCheckBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.DateTimePicker yearOfBirthDateTimePicker;
    }
}