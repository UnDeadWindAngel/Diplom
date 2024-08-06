namespace BussinesCommunications
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdministratorTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ComboBoxTypeUser = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Exit1 = new System.Windows.Forms.Button();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.PasswordUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TherdNameUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondNameUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserFirstName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ComboBoxSerchUser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ThirdNameTextBoxSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SecondNameTextBoxSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FirstNameTextBoxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit2 = new System.Windows.Forms.Button();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.AdministratorTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // AdministratorTabControl
            // 
            this.AdministratorTabControl.Controls.Add(this.tabPage1);
            this.AdministratorTabControl.Controls.Add(this.tabPage2);
            this.AdministratorTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdministratorTabControl.Location = new System.Drawing.Point(0, 0);
            this.AdministratorTabControl.Name = "AdministratorTabControl";
            this.AdministratorTabControl.SelectedIndex = 0;
            this.AdministratorTabControl.Size = new System.Drawing.Size(579, 213);
            this.AdministratorTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ComboBoxTypeUser);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Exit1);
            this.tabPage1.Controls.Add(this.AddUserBtn);
            this.tabPage1.Controls.Add(this.PasswordUser);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.LoginUser);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TherdNameUser);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SecondNameUser);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.UserFirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление пользователя";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ComboBoxTypeUser
            // 
            this.ComboBoxTypeUser.FormattingEnabled = true;
            this.ComboBoxTypeUser.Items.AddRange(new object[] {
            "Администратор",
            "Оператор",
            "Пользователь"});
            this.ComboBoxTypeUser.Location = new System.Drawing.Point(92, 148);
            this.ComboBoxTypeUser.Name = "ComboBoxTypeUser";
            this.ComboBoxTypeUser.Size = new System.Drawing.Size(380, 21);
            this.ComboBoxTypeUser.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Тип";
            // 
            // Exit1
            // 
            this.Exit1.Location = new System.Drawing.Point(490, 156);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(75, 23);
            this.Exit1.TabIndex = 11;
            this.Exit1.Text = "Выйти";
            this.Exit1.UseVisualStyleBackColor = true;
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(490, 32);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(75, 23);
            this.AddUserBtn.TabIndex = 10;
            this.AddUserBtn.Text = "Добавить";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // PasswordUser
            // 
            this.PasswordUser.Location = new System.Drawing.Point(92, 122);
            this.PasswordUser.Name = "PasswordUser";
            this.PasswordUser.Size = new System.Drawing.Size(380, 20);
            this.PasswordUser.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Пароль";
            // 
            // LoginUser
            // 
            this.LoginUser.Location = new System.Drawing.Point(92, 90);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(380, 20);
            this.LoginUser.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Логин";
            // 
            // TherdNameUser
            // 
            this.TherdNameUser.Location = new System.Drawing.Point(92, 62);
            this.TherdNameUser.Name = "TherdNameUser";
            this.TherdNameUser.Size = new System.Drawing.Size(380, 20);
            this.TherdNameUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // SecondNameUser
            // 
            this.SecondNameUser.Location = new System.Drawing.Point(92, 32);
            this.SecondNameUser.Name = "SecondNameUser";
            this.SecondNameUser.Size = new System.Drawing.Size(380, 20);
            this.SecondNameUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // UserFirstName
            // 
            this.UserFirstName.Location = new System.Drawing.Point(92, 6);
            this.UserFirstName.Name = "UserFirstName";
            this.UserFirstName.Size = new System.Drawing.Size(380, 20);
            this.UserFirstName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ComboBoxSerchUser);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.ThirdNameTextBoxSearch);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.SecondNameTextBoxSearch);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.FirstNameTextBoxSearch);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Exit2);
            this.tabPage2.Controls.Add(this.dataGridViewUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск и удаление пользователя";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ComboBoxSerchUser
            // 
            this.ComboBoxSerchUser.FormattingEnabled = true;
            this.ComboBoxSerchUser.Items.AddRange(new object[] {
            "Администратор",
            "Оператор",
            "Пользователь"});
            this.ComboBoxSerchUser.Location = new System.Drawing.Point(255, 160);
            this.ComboBoxSerchUser.Name = "ComboBoxSerchUser";
            this.ComboBoxSerchUser.Size = new System.Drawing.Size(201, 21);
            this.ComboBoxSerchUser.TabIndex = 22;
            this.ComboBoxSerchUser.SelectedIndexChanged += new System.EventHandler(this.FirstNameTextBoxSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Тип пользователя";
            // 
            // ThirdNameTextBoxSearch
            // 
            this.ThirdNameTextBoxSearch.Location = new System.Drawing.Point(439, 133);
            this.ThirdNameTextBoxSearch.Name = "ThirdNameTextBoxSearch";
            this.ThirdNameTextBoxSearch.Size = new System.Drawing.Size(109, 20);
            this.ThirdNameTextBoxSearch.TabIndex = 20;
            this.ThirdNameTextBoxSearch.TextChanged += new System.EventHandler(this.FirstNameTextBoxSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Отчество";
            // 
            // SecondNameTextBoxSearch
            // 
            this.SecondNameTextBoxSearch.Location = new System.Drawing.Point(249, 132);
            this.SecondNameTextBoxSearch.Name = "SecondNameTextBoxSearch";
            this.SecondNameTextBoxSearch.Size = new System.Drawing.Size(109, 20);
            this.SecondNameTextBoxSearch.TabIndex = 18;
            this.SecondNameTextBoxSearch.TextChanged += new System.EventHandler(this.FirstNameTextBoxSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Фамилия";
            // 
            // FirstNameTextBoxSearch
            // 
            this.FirstNameTextBoxSearch.Location = new System.Drawing.Point(76, 133);
            this.FirstNameTextBoxSearch.Name = "FirstNameTextBoxSearch";
            this.FirstNameTextBoxSearch.Size = new System.Drawing.Size(109, 20);
            this.FirstNameTextBoxSearch.TabIndex = 15;
            this.FirstNameTextBoxSearch.TextChanged += new System.EventHandler(this.FirstNameTextBoxSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Удалить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit2
            // 
            this.Exit2.Location = new System.Drawing.Point(490, 161);
            this.Exit2.Name = "Exit2";
            this.Exit2.Size = new System.Drawing.Size(75, 23);
            this.Exit2.TabIndex = 12;
            this.Exit2.Text = "Выйти";
            this.Exit2.UseVisualStyleBackColor = true;
            this.Exit2.Click += new System.EventHandler(this.Exit2_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewUser.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUser.MultiSelect = false;
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(565, 126);
            this.dataGridViewUser.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 213);
            this.ControlBox = false;
            this.Controls.Add(this.AdministratorTabControl);
            this.MaximumSize = new System.Drawing.Size(595, 252);
            this.MinimumSize = new System.Drawing.Size(595, 252);
            this.Name = "Form1";
            this.Text = "Bussines communications";
            this.AdministratorTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdministratorTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox PasswordUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoginUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TherdNameUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecondNameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserFirstName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button Exit1;
        private System.Windows.Forms.Button Exit2;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.ComboBox ComboBoxTypeUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ThirdNameTextBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SecondNameTextBoxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FirstNameTextBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboBoxSerchUser;
    }
}

