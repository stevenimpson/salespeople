using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salespeople
{
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
        }

        Employee employee;
        //constructor allowing for employee list to be passed to this class for manipulation
        public AddSale(Employee e1)
        {
            InitializeComponent();

            employee = e1;
        }
        //converts TotalSales field to a double for manipulation then adds this to the TotalSales field of the current employee
        private void confirmButton_Click(object sender, EventArgs e)
        {
            double added = Convert.ToDouble(amountBox.Text);
            employee.TotalSales = employee.TotalSales + added;

            this.Close();

        }
        //returns employee object to Form1
        public Employee getEmployee()
        {
            return (employee);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
