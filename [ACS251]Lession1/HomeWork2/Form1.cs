using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    public partial class Form1 : Form
    {
        private MovieTheater ticket = new 華納威秀();
        private TicketControl ticketControl = new TicketControl();
        private double discount;
        private Ticket selectTicket;

        private string orderMessage = string.Empty;

        public Form1()
        {
            InitializeComponent();
            initialize();
        }

        public void initialize()
        {
            TicketComboBox.Items.AddRange(ticket.TicketList.ToArray());
        }

        public void UpdateUI()
        {
            MessageRichTextBox.Text = orderMessage;
            MessageRichTextBox.Text += ticket.ToString();
        }

        private void TicketComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageRichTextBox.Text = ticket.OrderTicket(TicketComboBox.SelectedItem.ToString()).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectTicket = ticket.OrderTicket(TicketComboBox.SelectedItem.ToString());
            selectTicket.SaleOff = discount;
            selectTicket.amount = (int)ticketAmountNumericUpDown.Value;
            orderMessage += selectTicket.ToString();
            ticket.tatleCost += selectTicket.TatleCost();

            UpdateUI();
        }

        private void TicketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            discount = ticketControl.UpdateComboBox(TicketComboBox, StudentComboBox, ChildComboBox);
        }

        private void StudentComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            discount = ticketControl.UpdateStudentDiscount(StudentComboBox, ChildComboBox);
        }

        private void ChildComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            discount = ticketControl.UpdateChildDiscount(StudentComboBox, ChildComboBox);
        }
    }
}