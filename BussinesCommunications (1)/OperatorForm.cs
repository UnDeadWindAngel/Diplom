using MySql.Data.MySqlClient;
using SQLConnectionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinesCommunications
{
    public partial class OperatorForm : Form
    {
        Form formtoopen;
        int IdOp;
        public OperatorForm(Form form,string IdOperator)
        {
            InitializeComponent();
            formtoopen = form;
            IdOp = Convert.ToInt32(IdOperator);
            DGVReportRefresh();
        }
        public void DGVReportRefresh()
        {
            ConnectionMySQL my = new ConnectionMySQL();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `report` INNER JOIN `users` ON `users`.`Id`=`report`.`User_From` WHERE `Status_Report`='Просмотрено' OR `Status_Report`='Отправлено'", my.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridViewReport.Rows.Clear(); //создание шапки и столбцов DataGridView
            dataGridViewReport.ColumnCount = 8;
            dataGridViewReport.Columns[0].Name = "Фамилия";
            dataGridViewReport.Columns[1].Name = "Имя";
            dataGridViewReport.Columns[2].Name = "Отчество";
            dataGridViewReport.Columns[3].Name = "Ссылка на отчет";
            dataGridViewReport.Columns[4].Name = "Дата отчета";
            dataGridViewReport.Columns[5].Name = "Статус";
            dataGridViewReport.Columns[6].Name = "Id";
            dataGridViewReport.Columns[6].Visible = false;
            dataGridViewReport.Columns[7].Name = "Id";
            dataGridViewReport.Columns[7].Visible = false;
            int i = 0;//заполнение DataGridView данными из представления таблицы студенты
            foreach (var tab in table.Select())
            {
                dataGridViewReport.RowCount++;
                dataGridViewReport.Rows[i].Cells[0].Value = tab.ItemArray[10];
                dataGridViewReport.Rows[i].Cells[1].Value = tab.ItemArray[11];
                dataGridViewReport.Rows[i].Cells[2].Value = tab.ItemArray[12];
                dataGridViewReport.Rows[i].Cells[3].Value = tab.ItemArray[1];
                dataGridViewReport.Rows[i].Cells[4].Value = tab.ItemArray[5];
                dataGridViewReport.Rows[i].Cells[5].Value = tab.ItemArray[7];
                dataGridViewReport.Rows[i].Cells[6].Value = tab.ItemArray[0];
                dataGridViewReport.Rows[i].Cells[7].Value = tab.ItemArray[3];
                i++;
            }

        }

        private void Exit1_Click(object sender, EventArgs e)
        {
            formtoopen.Show();
            this.Close();
        }

        private void dataGridViewReport_DoubleClick(object sender, EventArgs e)
        {
            ConnectionMySQL my = new ConnectionMySQL();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command2 = new MySqlCommand("UPDATE `report` SET `Status_Report`= 'Просмотрено' WHERE `Id` = " + dataGridViewReport.CurrentRow.Cells[6].Value.ToString(), my.getConnection());
            MySqlCommand command = new MySqlCommand("SELECT `Link_To`FROM `report` WHERE `Id` = "+ dataGridViewReport.CurrentRow.Cells[6].Value.ToString(), my.getConnection());
            my.openConnection();
            command2.ExecuteNonQuery();
            my.closeConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            Uri Url = null;
            foreach (var tab in table.Select())
            {
                string temp = tab.ItemArray[0].ToString();
                temp = temp.Replace(" ", "%20");
                System.Diagnostics.Process.Start("http://q99184qm.beget.tech/source/php/" + temp);
            }
            DGVReportRefresh();
        }

        private void UpdateReportComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(UpdateReportComboBox.SelectedItem.ToString()== "Отказано")
            {
                UpdateReportTextBox.Enabled = true;
            }    
            else { UpdateReportTextBox.Enabled = false; }
        }

        private void UpdateReportBTN_Click(object sender, EventArgs e)
        {
            if(UpdateReportComboBox.SelectedItem.ToString() == "Отказано") 
            {
                ConnectionMySQL my = new ConnectionMySQL();
                MySqlCommand command2 = new MySqlCommand("UPDATE `report` SET `Status_Report`= 'Отказано', `Rejection_Reason`= '"+UpdateReportTextBox.Text+"' WHERE `Id` = " + dataGridViewReport.CurrentRow.Cells[6].Value.ToString(), my.getConnection());
                my.openConnection();
                command2.ExecuteNonQuery();
                my.closeConnection();
                DGVReportRefresh();
            }
            else
            {
                ConnectionMySQL my = new ConnectionMySQL();
                MySqlCommand command2 = new MySqlCommand("UPDATE `report` SET `Status_Report`= 'Подписано' WHERE `Id` = " + dataGridViewReport.CurrentRow.Cells[6].Value.ToString(), my.getConnection());
                my.openConnection();
                command2.ExecuteNonQuery();
                my.closeConnection();
                Uri uri = new Uri("http://q99184qm.beget.tech/Prewiev.php?IdOperator=" + IdOp + "&IdUser=" + dataGridViewReport.CurrentRow.Cells[7].Value.ToString() + "&UrlReport=" + dataGridViewReport.CurrentRow.Cells[3].Value.ToString());
                System.Diagnostics.Process.Start(""+uri+"");
                DGVReportRefresh();
            }
        }
    }
}
