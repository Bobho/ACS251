using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    internal class TicketControl
    {
        private StudentDiscount studentDiscount = new StudentDiscount();
        private ChildDiscount childDiscount = new ChildDiscount();

        public double UpdateComboBox(ComboBox ticket, ComboBox student, ComboBox child)
        {
            if (ticket.SelectedItem == null)
            {
                student.Items.Clear();
                child.Items.Clear();
                return 1;
            }
            else if (ticket.SelectedItem.ToString().Equals("全票"))
            {
                student.Items.Clear();
                student.Text = "";
                child.Items.Clear();
                child.Text = "";
                return 1;
            }
            else if (ticket.SelectedItem.ToString().Equals("學生票"))
            {
                student.Items.AddRange(studentDiscount.studentDiscountList.ToArray());
                return .8;
            }
            else
            {
                return 1;
            }
        }

        public double UpdateStudentDiscount(ComboBox student, ComboBox child)
        {
            if (student == null || child == null)
            {
                return 1;
            }
            else
            {
                if (student.SelectedItem.ToString().Equals("大學生"))
                {
                    child.Items.Clear();
                    child.Text = "";
                    return studentDiscount.DiscountSaleOff(student.SelectedItem.ToString());
                }
                else if (student.SelectedItem.ToString().Equals("小學生"))
                {
                    child.Items.AddRange(childDiscount.discountList.ToArray());
                    return studentDiscount.DiscountSaleOff(student.SelectedItem.ToString());
                }
                else
                {
                    child.Items.Clear();
                    return 1;
                }
            }
        }

        public double UpdateChildDiscount(ComboBox student, ComboBox child)
        {
            if (student == null || child == null)
            {
                return 1;
            }
            else
            {
                if (child.SelectedItem.ToString().Equals("10歲以下"))
                {
                    return childDiscount.DiscountSaleOff(child.SelectedItem.ToString());
                }
                else if (child.SelectedItem.ToString().Equals("屁海"))
                {
                    return childDiscount.DiscountSaleOff(child.SelectedItem.ToString());
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}