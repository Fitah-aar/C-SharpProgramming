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

---

2.9 Numeric Data Types

"int"

The "int" data type stores whole numbers.

int age = 22;

"double"

The "double" data type stores real numbers, including fractional values.

double height = 1.70;

"decimal"

The "decimal" data type stores real numbers with greater precision and is commonly used for financial calculations.

decimal price = 50.75m;

---

2.10 Type Compatibility

Different numeric data types are not always directly compatible.

For example:

int number = 10;
double value = number;

An "int" can be assigned to a "double".

However, some conversions require an explicit cast.

Example:

double number = 25.75;

int value = (int)number;

The cast:

(int)

explicitly converts the value to an integer.

---

2.11 The "var" Keyword

The "var" keyword allows the compiler to determine the variable's data type automatically.

Example:

var name = "Abdifitah";

C# determines that "name" is a "string".

Another example:

var age = 22;

C# determines that "age" is an "int".

A "var" variable must be initialized when it is declared.

---

2.12 Performing Calculations

C# provides several arithmetic operators.

Operator| Operation| Example
"+"| Addition| "5 + 3"
"-"| Subtraction| "5 - 3"
"*"| Multiplication| "5 * 3"
"/"| Division| "5 / 3"
"%"| Remainder| "5 % 3"

Example:

int price = 10;
int quantity = 3;

int total = price * quantity;

Result:

30

---

2.13 Integer Division

When two integers are divided, C# produces an integer result.

Example:

int result = 7 / 3;

Result:

2

The decimal portion is discarded.

To produce a decimal result, use a "double":

double result = (double)7 / 3;

Result:

2.333333...

---

2.14 Reading Numeric Input

A TextBox always provides its input as a "string".

For example:

int age = int.Parse(ageTextBox.Text);

"int.Parse()" converts the string into an integer.

Common Parse Methods

int.Parse()

double.Parse()

decimal.Parse()

Example:

double price = double.Parse(priceTextBox.Text);

---

2.15 Outputting Numeric Values

The "Text" property of a control expects a string.

You can use "ToString()" to convert a numeric value into a string.

Example:

int age = 22;

ageLabel.Text = age.ToString();

You can also concatenate a number with a string:

int age = 22;

MessageBox.Show("Age: " + age);

---

2.16 Formatting Numbers with "ToString()"

The "ToString()" method can format numeric values.

Common format specifiers include:

Format| Description
""N""| Number
""F""| Fixed-point
""E""| Exponential
""C""| Currency
""P""| Percentage

Example:

double number = 12.3;

MessageBox.Show(number.ToString("N3"));

Result:

12.300

---

2.17 Simple Exception Handling

An exception is an error that occurs while a program is running.

Examples include:

- Dividing by zero
- Invalid input
- Trying to access something that does not exist

Exception handling allows a program to respond to these errors instead of crashing.

---

2.18 "try-catch"

The "try" block contains code that might cause an exception.

The "catch" block handles the exception.

try
{
    // Code that might cause an error
}
catch
{
    // Handle the error
}

Example:

try
{
    int age = int.Parse(ageTextBox.Text);

    MessageBox.Show(age.ToString());
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}

---

2.19 "Exception.Message"

You can use the "Message" property to display information about an exception.

catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}

Here:

- "Exception" → exception type
- "ex" → exception object
- "ex.Message" → error message

---

2.20 Named Constants

A constant is a value that cannot be changed after it is declared.

The "const" keyword is used to declare constants.

Example:

const double INTEREST_RATE = 0.129;

---

2.21 Fields

A field is a variable declared inside a class but outside the methods.

Example:

public partial class Form1 : Form
{
    private string name = "Abdifitah";

    // Methods go here
}

A field can be accessed by methods within the class.

---

2.22 Using the Math Class

The "Math" class provides useful mathematical methods and constants.

Square Root

Math.Sqrt(25);

Result:

5

Power

Math.Pow(2, 3);

Result:

8

Maximum

Math.Max(10, 20);

Result:

20

Minimum

Math.Min(10, 20);

Result:

10

Rounding

Math.Round(12.6);

Pi

Math.PI

Euler's Number

Math.E

---

2.23 More GUI Details

Focus

The "Focus()" method moves the keyboard focus to a control.

Example:

nameTextBox.Focus();

Tab Order

The "TabIndex" property controls the order in which controls receive focus when the user presses the Tab key.

Example:

First control  → TabIndex = 0
Second control → TabIndex = 1
Third control  → TabIndex = 2

---

2.24 Access Keys

An access key allows the user to activate a control using the keyboard.

The "&" character is placed before a letter in the control's "Text" property.

Example:

&Exit

The user can press:

Alt + X

to activate the control.

---

2.25 Colors

Windows Forms controls have properties for changing colors.

Background Color

button1.BackColor = Color.Blue;

Foreground Color

button1.ForeColor = Color.White;

The "BackColor" property controls the background, while "ForeColor" controls the foreground/text color.

---

2.26 GroupBox and Panel

Both "GroupBox" and "Panel" can be used to organize controls.

GroupBox

A "GroupBox" can contain controls and display a title.

Panel

A "Panel" can contain controls and can be used to organize the GUI.

---

2.27 Debugging

What is a Logic Error?

A logic error occurs when a program runs but produces an incorrect result.

Example:

int price = 100;
int quantity = 2;

int total = price - quantity;

The program runs, but the calculation may be logically incorrect if the goal is to calculate a total price.

Correct:

int total = price * quantity;

---

2.28 Breakpoints

A breakpoint tells Visual Studio to pause the program at a specific line during execution.

Example:

int total = price * quantity;

When execution reaches the breakpoint, you can inspect the values of variables.

---

2.29 Locals and Watch Windows

Locals Window

The Locals Window displays local variables and their current values while debugging.

Watch Window

The Watch Window allows you to monitor selected variables or expressions.

---

2.30 Single-Stepping

Single-stepping allows you to execute the program one statement at a time.

Visual Studio provides:

F11 → Step Into

This is useful for finding logic errors and understanding how the program executes.

---

🧠 Chapter 2 Quick Summary

TextBox
   ↓
User Input
   ↓
String
   ↓
Parse()
   ↓
Number
   ↓
Calculation
   ↓
ToString()
   ↓
Output

For errors:

try
 ↓
Execute Code
 ↓
Exception?
 ↓
catch
 ↓
Handle Error

For debugging:

Breakpoint
    ↓
Pause Program
    ↓
Inspect Variables
    ↓
Step Through Code
    ↓
Find Logic Error

---

⭐ Most Important Code

Get TextBox Input

string name = nameTextBox.Text;

Clear TextBox

nameTextBox.Clear();

Convert Text to Integer

int age = int.Parse(ageTextBox.Text);

Convert Text to Double

double price = double.Parse(priceTextBox.Text);

Display a Number

resultLabel.Text = age.ToString();

Perform a Calculation

int total = price * quantity;

Handle an Exception

try
{
    int number = int.Parse(numberTextBox.Text);
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}

Create a Constant

const double TAX_RATE = 0.15;

Use the Math Class

double result = Math.Sqrt(25);

Set Focus

nameTextBox.Focus();

---

🎯 Main Idea of Chapter 2

The most important concept is understanding how data moves through a C# program:

USER
 ↓
TextBox
 ↓
STRING
 ↓
Parse()
 ↓
NUMBER
 ↓
CALCULATION
 ↓
ToString()
 ↓
LABEL / MESSAGEBOX

Once you understand this flow, many basic Visual C# Windows Forms programs become much easier to build.
