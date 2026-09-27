using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reklamnoe_Agenstvo
{
    public partial class Frm_Admin : Form
    {
        public int n = 0;
        public Frm_Admin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели все значения", "Ошибка");
            }
            else
            {
                if (textBox1.Text.Length > 35 || textBox2.Text.Length > 35)
                {
                    MessageBox.Show("Максимальное количество символов - 36", "Ошибка");
                }

                else
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\VS\\Source\\repos\\Reklamnoe Agenstvo\\Database1.mdf\";Integrated Security=True");
                    con.Open();
                    if (con.State != ConnectionState.Open)

                        MessageBox.Show("Неудалось вставить услугу", "Ошибка");
                    else
                    {
                        MessageBox.Show("Услуга добавлена", "Успех!");
                        database1DataSet.Table.Rows.Add(dataGridView1.RowCount + 1, textBox1.Text, textBox2.Text);
                        this.tableTableAdapter.Update(this.database1DataSet.Table);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\VS\\Source\\repos\\Reklamnoe Agenstvo\\Database1.mdf\";Integrated Security=True");
            con.Open();
            if (con.State != ConnectionState.Open)
            {
                MessageBox.Show("Неудалось вставить услугу", "Ошибка");
            }
            else
            {
               MessageBox.Show("Услуга удалена", "Успех!");
               database1DataSet.Table.Rows.Remove(this.database1DataSet.Table.Rows.Find(comboBox1.Text));
               this.tableTableAdapter.Update(this.database1DataSet.Table);
            }
        }
    }
}
