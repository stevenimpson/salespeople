## Problem description
This program aims to allow businesses and companies keep track of their employees and each of their details. Business owners need to be able to change these details as their employees change, move addresses etc, and this program also allows for this.
In addition, the entire list of employees at any point in time can be saved to a text file, which can then be printed for use outside of the computer environment.
Users can search for employees based on all or part of their name, as well as by the geographical area they have been assigned.
A text file can be saved with details of a single selected employee.
A new sale can be added to a selected Employee’s record, increasing their Total Sales amount and recorded.
Help information can be access from the Help>Help Pages menu item, which will present a web page detailing the program’s use.

## Self-Diagnosis & Declaration
# Features fully working
*	Employee creation
*	Manipulating employee details via Employee Details fields
*	Printing full list of employee details
*	Printing individual employee details
*	Searching for employees by name
*	Searching for employees by Geographical Area
*	Searching for employees with TotalSales exceeding $1m
*	Presenting Help pages
*	ClickOnce installation
*	Refreshing People List
*	Adding a new sale to selected employee record

# Features not fully working
*	Selecting a blank space on employee list throws an exception, caused by program trying to access an object that doesn’t exist. Could be dealt with by handling this exception and forcing program to break out of the SelectedIndexChanged method, or implementing a check to ensure that the selected index contains an employee before going ahead with trying to populate Details fields
*	Print employee details document directly to a printer. Planned to implement this feature but was unable to work out direct printing in time. Option removed from GUI.


## Solution
This program consists of an Employee class which holds data for each employee’s name, address, index, location, home number, office number, mobile number, email and total sales.
The program creates a list of Employee objects. Originally planned to use an Array, however found that a List is more appropriate for this application as the size of a List does not need to be defined at runtime. This way the list can dynamically change size based on how many objects it is required to hold by the user.
Employee objects are added through a form which is presented to the user which requests a name input.
It is then added to the Employee List emplist, and this list is presented in the PeopleListBox by iterating through this list and adding the name of each employee to a new entry in the list box.
If users select an employee from the list, the fields on the right will be populated with that employee’s other details if they have been entered. Each field can be changed by the user and the changes can then be saved to that employee’s record.
The user can manually change each field, or for the Total Sales, they can add a new sale using the special Add Sales button.
The employee list can be searched by name or by geographical area, which will search for a term that matches a string of characters in the employee name or area strings.
There is a button which will filter the employee list to only those employees with sales over $1 million.
The “Return to Full List” button makes the list box present the full list of employees again.
Users can save a summary of every employee to a .txt file, which will be formatted in an easy-to-read manner.
Users can access help files which will open a web browser to a Help web page, which is hosted online so it can be access from any internet connected computer.
Users can also access an About window which displays information about the developer of the program, and it’s title.
