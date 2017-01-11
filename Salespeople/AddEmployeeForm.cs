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

    public partial class AddEmployeeForm : Form
    {


        public AddEmployeeForm()
        {
            InitializeComponent();

        }

        List<Employee> employees;
        double index;
        //constructor which allows a list and index to be passed, which allows for new employee records to be created by this class
        public AddEmployeeForm(List<Employee> emps, double currentIndex)
        {
            InitializeComponent();
            employees = emps;
            index = currentIndex;
        }


        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            


            string n = newNameBox.Text;
            
            

            


            addNewEmployee(n);

            this.Close();

        }
        //adds a new Employee to the list using a constructor in the Employee class
        public void addNewEmployee(string n)
        {

            employees.Add(new Employee(n));

        }
        //returns employee list to Form1
        public List<Employee> getList()
        {
            return employees;
        }

        
        private void newSalesBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}
