using SmartSaver.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartSaver
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime date = transactionDate.Value;
            string expence = transactionExpense.Text;
            string reason = transactionReason.Text;
            string category = transactionCategory.Text;
         
          

            if (String.IsNullOrWhiteSpace(expence))
            {
                transactionExpense.BackColor = Color.Red;
            }
            if (String.IsNullOrWhiteSpace(reason))
            {
                transactionReason.BackColor = Color.Red;
            }

            Transaction transaction = new Transaction(date, expence,reason,category);
            MessageBox.Show(transaction.ToString());

            List<Transaction> transactionList = new List<Transaction>();
            transactionList.Add(transaction);

        }

        private void transactionExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && transactionExpense.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


    }
}
