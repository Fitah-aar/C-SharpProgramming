Chapter 2: Processing Data

Starting Out with Visual C#

This chapter introduces the basic concepts of processing data in a Visual C# Windows Forms application.

---

📚 Table of Contents

1. Reading Input with TextBox Controls
2. A First Look at Variables
3. Numeric Data Types and Variables
4. Performing Calculations
5. Inputting and Outputting Numeric Values
6. Formatting Numbers with ToString
7. Simple Exception Handling
8. Using Named Constants
9. Declaring Variables as Fields
10. Using the Math Class
11. More GUI Details
12. Using the Debugger to Locate Logic Errors

---

2.1 Reading Input with TextBox Controls

What is a TextBox?

A "TextBox" is a Windows Forms control that allows the user to enter information using the keyboard.

Example:

string name = nameTextBox.Text;

The "Text" property contains the text entered by the user.

Clearing a TextBox

You can clear a TextBox in several ways:

nameTextBox.Clear();

or:

nameTextBox.Text = "";

or:

nameTextBox.Text = string.Empty;

---

2.2 A First Look at Variables

What is a Variable?

A variable is a storage location in memory used to hold data.

Before using a variable, it must be declared.

Variable Syntax

DataType VariableName;

Example:

string name;

Here:

- "string" → Data Type
- "name" → Variable Name

Variables are used to store information while a program is running.

---

Declaring and Initializing a Variable

A variable can be declared and assigned a value at the same time.

string name = "Abdifitah";

Another example:

int age = 22;

---

2.3 Data Types

A data type specifies what kind of data a variable can store.

Common data types used in this chapter include:

Data Type| Description| Example
"string"| Text| ""Hello""
"int"| Whole numbers| "25"
"double"| Real numbers| "25.5"
"decimal"| Precise decimal numbers| "500.50m"

---

2.4 Variable Naming Rules

Variable names should be meaningful and easy to understand.

Correct

string firstName;
string lastName;
int studentAge;

Incorrect

string first name;
int 1age;

Basic Rules

- A variable name must begin with a letter or underscore.
- It cannot contain spaces.
- It cannot be a reserved C# keyword.
- Meaningful names should be used whenever possible.

---

2.5 String Variables

A "string" variable stores a sequence of characters.

Examples:

string name = "Abdifitah";
string city = "Garbaharey";
string phone = "0612345678";

String values are written inside double quotation marks.

"Abdifitah"

A string can contain names, addresses, phone numbers, and other text.

---

2.6 String Concatenation

String concatenation means joining two or more strings together.

The "+" operator is used for concatenation.

Example:

string firstName = "Abdifitah";
string lastName = "Mohamed";

string fullName = firstName + " " + lastName;

Result:

Abdifitah Mohamed

You can also combine strings with numbers:

int age = 22;

string message = "My age is " + age;

Result:

My age is 22

---

2.7 Local Variables

A local variable is a variable declared inside a method.

Example:

private void showButton_Click(object sender, EventArgs e)
{
    string name = "Abdifitah";

    nameLabel.Text = name;
}

The variable "name" belongs to this method.

A local variable can only be accessed within the appropriate scope. Its lifetime begins when the method starts and ends when the method finishes.

---

2.8 Initialization

A local variable must be assigned a value before it is used.

❌ Incorrect

string name;

MessageBox.Show(name);

This causes a compiler error because the variable has not been assigned a value.

✅ Correct

string name;

name = "Abdifitah";

MessageBox.Show(name);

Or:

string name = "Abdifitah";

