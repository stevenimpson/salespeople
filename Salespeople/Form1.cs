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

    

    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
        }

        
        
        
        //creates a list of employees, similar to an array which can be added to without defining an initial size
        List<Employee> emplist = new List<Employee>();
        //tracks current index, and is incredmented when a new employee is created
        double currentIndex = 0;


        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }
        //initialises an Add Employee window, receieves the new employee created by AddEmployee window and increments the current index
        private void addButton_Click(object sender, EventArgs e)
        {
            
            w2 = new AddEmployeeForm(emplist, currentIndex);
            w2.Show();
            

            emplist = w2.getList();
            currentIndex++;
            refreshBox();             
        }
        //instantiates AddEmployeeForm
        AddEmployeeForm w2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //refreshes PeopleList box

        private void refreshBox()
        {
            PeopleListBox.Items.Clear();
            foreach (Employee e in emplist)
            {
                PeopleListBox.Items.Add(e.Name);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            

            refreshBox();
        }

        //updates right fields with information of Emplyee selected
        private void PeopleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears fields in Employee Details to ensure old details do not stay there from previous selections
            nameBox.Clear();
            mobBox.Clear();
            homphBox.Clear();
            emailBox.Clear();
            addressBox.Clear();
            areaBox.Clear();
            salesBox.Clear();

            //gets name of employee currently selected and assigns that employee's object to selectedEmp for manipulation
            string curName = " ";
            try
            {
                curName = PeopleListBox.SelectedItem.ToString();
            }
            catch (System.NullReferenceException nre)
            {
                
            }
            Employee selectedEmp = emplist.Find(i => i.Name == curName);

            nameBox.Text = selectedEmp.Name;
            idBox.Text = selectedEmp.Index.ToString();
            mobBox.Text = selectedEmp.MobNo;
            homphBox.Text = selectedEmp.HomeNo;
            emailBox.Text = selectedEmp.Email;
            addressBox.Text = selectedEmp.HomeAdd;
            areaBox.Text = selectedEmp.GeoArea;
            salesBox.Text = selectedEmp.TotalSales.ToString();



        }
        //creates a New Sale window allowing for a new sale amount to be added to the selected employee's TotalSales
        private void newSaleButton_Click(object sender, EventArgs e)
        {
            if (PeopleListBox.SelectedItem != null)
            {
                //gets name of employee currently selected and assigns that employee's object to selectedEmp for manipulation
                string curName = PeopleListBox.SelectedItem.ToString();
                Employee selectedEmp = emplist.Find(i => i.Name == curName);

                AddSale s1 = new AddSale(selectedEmp);
                s1.Show();
                salesBox.Text = selectedEmp.TotalSales.ToString();
                selectedEmp = s1.getEmployee();


            }

        }
        //gathers changes made to Employee Details fields and commits them to the Employee object selected
        private void saveButton_Click(object sender, EventArgs e)
        {
            //gets name of employee currently selected and assigns that employee's object to selectedEmp for manipulation
            if (PeopleListBox.SelectedIndex != -1)
            {
                string curName = PeopleListBox.SelectedItem.ToString();
                Employee selectedEmp = emplist.Find(i => i.Name == curName);

                selectedEmp.Name = nameBox.Text;
                selectedEmp.MobNo = mobBox.Text;
                selectedEmp.HomeNo = homphBox.Text;
                selectedEmp.Email = emailBox.Text;
                selectedEmp.HomeAdd = addressBox.Text;
                selectedEmp.GeoArea = areaBox.Text;
                selectedEmp.TotalSales = double.Parse(salesBox.Text);

            }
                



        }
        //searches the List of employees Names for a term entered by the user.
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.ToUpper();
            List<Employee> searchedEmployees = new List<Employee>();
            foreach (Employee e2 in emplist)
            {
                
                if (e2.Name.ToUpper().Contains(searchTerm))
                {
                    searchedEmployees.Add(e2);
                }
            }

            PeopleListBox.Items.Clear();

            foreach (Employee em in searchedEmployees)
            {
                PeopleListBox.Items.Add(em.Name);
            }
        }
        //searches through List of employees and displays all employees whose areas match the text entered by the user
        private void areaSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = areaSearchBox.Text.ToUpper();
            List<Employee> areaSearchedEmployees = new List<Employee>();
            foreach (Employee e3 in emplist)
            {

                if (e3.GeoArea.ToUpper().Contains(searchTerm))
                {
                    areaSearchedEmployees.Add(e3);
                }
            }

            PeopleListBox.Items.Clear();

            foreach (Employee em in areaSearchedEmployees)
            {
                PeopleListBox.Items.Add(em.Name);
            }
        }
        //saves list of all employees to a text file, in a format easily readable by people
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a list to later be saved to a text file
            List<string> lines = new List<string>();
            string path = @"c:\employees\employees.txt";
            foreach(Employee e0 in emplist)
            {
                //iterates through each employee in the master list, adding their details to the lines list
                lines.Add(String.Format("Name - {0}", e0.Name));
                lines.Add(String.Format("ID - {0}", e0.Index));
                lines.Add(String.Format("Mobile Number - {0}", e0.MobNo));
                lines.Add(String.Format("Home Number - {0}", e0.HomeNo));
                lines.Add(String.Format("Email - {0}", e0.Email));
                lines.Add(String.Format("Address - {0}", e0.HomeAdd));
                lines.Add(String.Format("Area - {0}", e0.GeoArea));
                lines.Add(String.Format("Total Sales - {0}", e0.TotalSales.ToString()));
                lines.Add(String.Format(" "));
            }
            try
            {
                System.IO.File.WriteAllLines(path, lines);
            }
            catch (System.IO.DirectoryNotFoundException dnf)
            {
                MessageBox.Show("Please create a directory at C:\\employees", "Directory not found");
            }

            MessageBox.Show("File saved at c:\\employees\\employees.txt", "Success");
        }
        //searches for employee records whose TotalSales exceed one million
        private void millionButton_Click(object sender, EventArgs e)
        {
            List<Employee> milSearchedEmployees = new List<Employee>();
            foreach (Employee emil in emplist)
            {
                if (emil.TotalSales >= 1000000)
                {
                    milSearchedEmployees.Add(emil);
                }
            }

            PeopleListBox.Items.Clear();

            foreach (Employee found in milSearchedEmployees)
            {
                PeopleListBox.Items.Add(found.Name);
            }
        }

        private void refreshFieldButton_Click(object sender, EventArgs e)
        {
            string curName = PeopleListBox.SelectedItem.ToString();
            Employee selectedEmp = emplist.Find(i => i.Name == curName);

            selectedEmp.Name = nameBox.Text;
            selectedEmp.MobNo = mobBox.Text;
            selectedEmp.HomeNo = homphBox.Text;
            selectedEmp.Email = emailBox.Text;
            selectedEmp.HomeAdd = addressBox.Text;
            selectedEmp.GeoArea = areaBox.Text;
            selectedEmp.TotalSales = double.Parse(salesBox.Text);
        }
        //shows About window
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sales Program by Steven Impson, 2014", "About");
        }
        //not used in current program
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a list to later be saved to a text file
            List<string> lines = new List<string>();
            
            foreach(Employee e9 in emplist)
            {
                //iterates through each employee in the master list, adding their details to the lines list
                lines.Add(String.Format("Name - {0}", e9.Name));
                lines.Add(String.Format("ID - {0}", e9.Index));
                lines.Add(String.Format("Mobile Number - {0}", e9.MobNo));
                lines.Add(String.Format("Home Number - {0}", e9.HomeNo));
                lines.Add(String.Format("Email - {0}", e9.Email));
                lines.Add(String.Format("Address - {0}", e9.HomeAdd));
                lines.Add(String.Format("Area - {0}", e9.GeoArea));
                lines.Add(String.Format("Total Sales - {0}", e9.TotalSales.ToString()));
                lines.Add(String.Format(" "));
            }
            foreach (string str in lines)
            {
                
            }
            
        }
        //opens a web page in user's default browser which shows directions for use of program
        private void helpPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dl.dropboxusercontent.com/u/4140071/Sales%20of%20the%20Century/help.html");
        }
        //saves a text file containing details of currently selected employee
        private void employeeReportButton_Click(object sender, EventArgs e)
        {
            //creates a list to later be saved to a text file
            List<string> lines = new List<string>();
            string curName = PeopleListBox.SelectedItem.ToString();
            Employee selectedEmp = emplist.Find(i => i.Name == curName);
            string path = @"c:\employees\" + selectedEmp.Name + ".txt";
            

            lines.Add(String.Format("Name - {0}", selectedEmp.Name));
            lines.Add(String.Format("ID - {0}", selectedEmp.Index));
            lines.Add(String.Format("Mobile Number - {0}", selectedEmp.MobNo));
            lines.Add(String.Format("Home Number - {0}", selectedEmp.HomeNo));
            lines.Add(String.Format("Email - {0}", selectedEmp.Email));
            lines.Add(String.Format("Address - {0}", selectedEmp.HomeAdd));
            lines.Add(String.Format("Area - {0}", selectedEmp.GeoArea));
            lines.Add(String.Format("Total Sales - {0}", selectedEmp.TotalSales.ToString()));
            lines.Add(String.Format(" "));

            
            try
            {
                System.IO.File.WriteAllLines(path, lines);
            }
            catch (System.IO.DirectoryNotFoundException dnf)
            {
                MessageBox.Show("Please create a directory at C:\\employees", "Directory not found");
            }

            MessageBox.Show("File saved at c:\\employees\\" + selectedEmp.Name + ".txt", "Success");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }
    }

    

       

    public class Employee
    {
        //employee related variables, each with properties and get/set methods

        private double index;
        public double Index
        {
            get { return index; }
            set { index = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string homeNo;
        public string HomeNo
        {
            get { return homeNo; }
            set { homeNo = value; }
        }

        private string mobNo;
        public string MobNo
        {
            get { return mobNo; }
            set { mobNo = value; }
        }

        private string officeNo;
        public string OfficeNo
        {
            get { return officeNo; }
            set { officeNo = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string geoArea;
        public string GeoArea
        {
            get { return geoArea; }
            set { geoArea = value; }
        }

        private string homeAdd;
        public string HomeAdd
        {
            get { return homeAdd; }
            set { homeAdd = value; }
        }

        private double totalSales;
        public double TotalSales
        {
            get { return totalSales; }
            set { totalSales = value; }
        }

        //default constructor
        public Employee()
        {
            name = "";
            homeNo = "";
            mobNo = "";
            officeNo = "";
            email = "";
            geoArea = "";
            homeAdd = "";
            totalSales = 0;
        }

        public Employee(string fullname)
        {
            name = fullname;
            homeNo = "";
            mobNo = "";
            officeNo = "";
            email = "";
            geoArea = "";
            homeAdd = "";
            totalSales = 0;
        }

        public Employee(string fullname, string home, string mob, string office, string ema, string area, string homeA, double sales, double inde)
        {
            name = fullname;
            homeNo = home;
            mobNo = mob;
            officeNo = office;
            email = ema;
            geoArea = area;
            homeAdd = homeA;
            totalSales = sales;
            index = inde;
        }

        //setters
        public void setName(string newName)
        {
            name = newName;
        }

        public void setHomeNo(string newHomeNo)
        {
            homeNo = newHomeNo;
        }

        public void setOfficeNo(string newOfficeNo)
        {
            officeNo = newOfficeNo;
        }

        public void setEmail(string newEmail)
        {
            email = newEmail;
        }

        public void setArea(string newGeoArea)
        {
            geoArea = newGeoArea;
        }

        public void setHomeAdd(string newHomeAdd)
        {
            homeAdd = newHomeAdd;
        }


    }

