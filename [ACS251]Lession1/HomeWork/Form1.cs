using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {


        private MovieTicket movieTicket;
        private double totalCost;
        private double cost;
        private double discountCost;
        private string ticketName;
        private int ticketAmount;
        private double price = 100;
        private string appString;

        public Form1()
        {
            InitializeComponent();
            Start();
        }

        public void Start()
        {
            TicketComboBox.Items.AddRange(new TicketList("TicketDll", "HomeWorkClassLibrary.Enumerations", "listTicket").TicketValue.ToArray());
            cost = price;
            StudentComboBox.Items.Add("test1");
            ChildComboBox.Items.Add("chileTest");
        }

        public void UpdateForm()
        {
            MessageRichTextBox.Text += string.Format("一張{0}票，原價{1}，特價{2} 共{3}張 小計{4} \n", ticketName, cost, discountCost, ticketAmount, discountCost * ticketAmount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateTotal();
            UpdateForm();
        }

        private void TicketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticketName = TicketComboBox.SelectedItem.ToString();
        }

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            appString = ConfigurationManager.AppSettings["test"];
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType(appString);
            object customerInstance = Activator.CreateInstance(customerType);

            movieTicket = new StudentTicket(this.price);
            movieTicket.discount = customerInstance as Discount;
            discountCost = movieTicket.Price;
        }

        private void ChildComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            movieTicket = new ChildTicket(this.price);
            movieTicket.discount = new ChildDiscount();
            discountCost = movieTicket.Price;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ticketAmount = (int)ticketAmountNumericUpDown.Value;
        }

        private void CalculateTotal()
        {
            totalCost += discountCost * ticketAmount;
        }
    }
}