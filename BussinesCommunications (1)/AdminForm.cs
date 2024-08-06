using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppClassLibrary;
using MySql.Data.MySqlClient;
using SQLConnectionLibrary;

namespace BussinesCommunications
{
    public partial class Form1 : Form
    {
        Form formtoopen;
        public Form1(Form form)
        {
            InitializeComponent();
            formtoopen = form;
            DGVUserRefresh();
        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            this.Close();
        }

        private void Exit1_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            this.Close();
        }
        private void DGVUserRefresh()
        {
            ConnectionMySQL my = new ConnectionMySQL();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", my.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridViewUser.Rows.Clear(); //создание шапки и столбцов DataGridView
            dataGridViewUser.ColumnCount = 5;
            dataGridViewUser.Columns[0].Name = "Фамилия";
            dataGridViewUser.Columns[1].Name = "Имя";
            dataGridViewUser.Columns[2].Name = "Отчество";
            dataGridViewUser.Columns[3].Name = "Логин";
            dataGridViewUser.Columns[4].Name = "Тип";
            int i = 0;//заполнение DataGridView данными из представления таблицы студенты
            foreach (var tab in table.Select())
            {
                dataGridViewUser.RowCount++;
                dataGridViewUser.Rows[i].Cells[0].Value = tab.ItemArray[1];
                dataGridViewUser.Rows[i].Cells[1].Value = tab.ItemArray[2];
                dataGridViewUser.Rows[i].Cells[2].Value = tab.ItemArray[3];
                dataGridViewUser.Rows[i].Cells[3].Value = tab.ItemArray[4];
                dataGridViewUser.Rows[i].Cells[4].Value = tab.ItemArray[6];
                i++;
            }

        }
        private void DGVUserRefresh(string FirstName, string SecondName, string ThirdName, string Type)
        {
            ConnectionMySQL my = new ConnectionMySQL();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `First_Name` like '%" + FirstName + "%' AND `Second_Name` like '%" + SecondName + "%' AND `Third_Name` like '%" + ThirdName 
                + "%' AND `Type` like '%" + Type + "%'", my.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridViewUser.Rows.Clear(); //создание шапки и столбцов DataGridView
            dataGridViewUser.ColumnCount = 5;
            dataGridViewUser.Columns[0].Name = "Фамилия";
            dataGridViewUser.Columns[1].Name = "Имя";
            dataGridViewUser.Columns[2].Name = "Отчество";
            dataGridViewUser.Columns[3].Name = "Логин";
            dataGridViewUser.Columns[4].Name = "Тип";
            int i = 0;//заполнение DataGridView данными из представления таблицы студенты
            foreach (var tab in table.Select())
            {
                dataGridViewUser.RowCount++;
                dataGridViewUser.Rows[i].Cells[0].Value = tab.ItemArray[1];
                dataGridViewUser.Rows[i].Cells[1].Value = tab.ItemArray[2];
                dataGridViewUser.Rows[i].Cells[2].Value = tab.ItemArray[3];
                dataGridViewUser.Rows[i].Cells[3].Value = tab.ItemArray[4];
                dataGridViewUser.Rows[i].Cells[4].Value = tab.ItemArray[6];
                i++;
            }

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string firstName = this.UserFirstName.Text;
            string secondName = this.SecondNameUser.Text;
            string therdName = this.TherdNameUser.Text;
            string login = this.LoginUser.Text;
            string password = this.PasswordUser.Text;
            string type = this.ComboBoxTypeUser.SelectedItem.ToString();
            ConnectionMySQL my = new ConnectionMySQL();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`First_Name`, `Second_Name`, `Third_Name`, `Login`, `Password`, `Type`)" +
                " VALUES(@FN, @SN, @TN, @Log, @Pass, @Type)", my.getConnection());
            command.Parameters.Add("@FN", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@SN", MySqlDbType.VarChar).Value = secondName;
            command.Parameters.Add("@TN", MySqlDbType.VarChar).Value = therdName;
            command.Parameters.Add("@Log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@Type", MySqlDbType.VarChar).Value = type;
            my.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Акаунт был добавлен в базу данных!");
            else
                MessageBox.Show("Акаунт не был добавлен в базу данных!");
            DGVUserRefresh();
        }

        private void FirstNameTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(ComboBoxSerchUser.SelectedItem == null)
            {
                DGVUserRefresh(FirstNameTextBoxSearch.Text, SecondNameTextBoxSearch.Text, ThirdNameTextBoxSearch.Text, "");
            }
            else
            {
                DGVUserRefresh(FirstNameTextBoxSearch.Text, SecondNameTextBoxSearch.Text, ThirdNameTextBoxSearch.Text, ComboBoxSerchUser.SelectedItem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionMySQL my = new ConnectionMySQL();
            MySqlCommand command2 = new MySqlCommand("DELETE FROM `users` WHERE `First_Name`='"+ dataGridViewUser.CurrentRow.Cells[0].Value.ToString() 
                + "' AND `Second_Name`='"+ dataGridViewUser.CurrentRow.Cells[1].Value.ToString() + "' AND `Third_Name`='"+ dataGridViewUser.CurrentRow.Cells[2].Value.ToString() 
                + "' AND `Login`='"+ dataGridViewUser.CurrentRow.Cells[3].Value.ToString() + "' AND `Type`='"+ dataGridViewUser.CurrentRow.Cells[4].Value.ToString() + "'", my.getConnection());
            my.openConnection();
            command2.ExecuteNonQuery();
            my.closeConnection();
            if (ComboBoxSerchUser.SelectedItem == null)
            {
                DGVUserRefresh(FirstNameTextBoxSearch.Text, SecondNameTextBoxSearch.Text, ThirdNameTextBoxSearch.Text, "");
            }
            else
            {
                DGVUserRefresh(FirstNameTextBoxSearch.Text, SecondNameTextBoxSearch.Text, ThirdNameTextBoxSearch.Text, ComboBoxSerchUser.SelectedItem.ToString());
            }
        }
    }
}
