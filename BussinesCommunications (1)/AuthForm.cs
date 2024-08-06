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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login=this.Login.Text;
            string password=this.Password.Text;
            ConnectionMySQL my = new ConnectionMySQL();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @log AND `Password` = @pass",my.getConnection());
            command.Parameters.Add("@log",MySqlDbType.VarChar).Value=login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                if (table.Rows[0].ItemArray[6].ToString() == "Администратор")
                {
                    Form1 adminForm = new Form1(this);
                    adminForm.Show();
                    this.Hide();
                }
                else if (table.Rows[0].ItemArray[6].ToString() == "Оператор")
                {
                    OperatorForm operatorForm = new OperatorForm(this,table.Rows[0].ItemArray[0].ToString());
                    operatorForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Пользователь не является оператором!");
            else
                MessageBox.Show("Такой пользователь не существует!");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
