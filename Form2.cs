using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reklamnoe_Agenstvo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bttn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы приобрели - \n" + textBox1.Text + ". \n Спасибо за покупку!", "Покупка совершена");
            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += comboBox1.Text + ", ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.database1DataSet.Table.Rows.Find(comboBox1.Text);
        }
    }
}
