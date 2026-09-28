# Chapter 2: Processing Data
### (*Starting Out with Visual C#, Sixth Edition*)

This documentation covers the core concepts of Chapter 2, including reading input from `TextBox` controls, declaring variables, performing mathematical calculations, parsing data types, handling exceptions, working with GUI features, and using Visual Studio debugging tools.

---

## Table of Contents
1. [Chapter Topics Overview](#chapter-topics-overview)
2. [2.1 Reading Input with TextBox](#21-reading-input-with-textbox)
3. [2.2 Variables & Primitive Data Types](#22-variables--primitive-data-types)
4. [2.3 Numeric Data Types & Operations](#23-numeric-data-types--operations)
5. [2.4 Input & Output of Numbers (Parsing & Formatting)](#24-input--output-of-numbers-parsing--formatting)
6. [2.5 Exception Handling](#25-exception-handling)
7. [2.6 Scope, Named Constants & Fields](#26-scope-named-constants--fields)
8. [2.7 The Math Class](#27-the-math-class)
9. [2.8 Advanced GUI Details](#28-advanced-gui-details)
10. [2.9 Debugging Techniques](#29-debugging-techniques)

---

## Chapter Topics Overview

* **Reading Input with TextBox:** `TextBox` control, `Text` property, and `Clear()` method.
* **Variables & Scope:** Declaration, Primitive Data Types, Naming conventions, String concatenation, Variable Scope, and Initialization.
* **Numeric Data Types:** `int`, `double`, `decimal`, Numeric literals, Type compatibility, Casting, and Implicit typing (`var`).
* **Performing Calculations:** Basic operators (`+`, `-`, `*`, `/`, `%`), Order of operations, and Integer division.
* **Input & Output Conversion:** `int.Parse()`, `double.Parse()`, `decimal.Parse()`, `ToString()`, and Formatting specifiers (`"N"`, `"F"`, `"E"`, `"C"`, `"P"`).
* **Exception Handling:** `try-catch` blocks, `Exception.Message`, Throwing vs. Catching exceptions.
* **Named Constants & Fields:** `const` keyword, Class-level fields, Local vs. Field scope.
* **Math Class:** `Math.Sqrt()`, `Math.Pow()`, `Math.Max()`, `Math.Min()`, `Math.Round()`, `Math.PI`, and `Math.E`.
* **GUI Customization:** `Focus()`, Tab Order (`TabIndex`), Keyboard Access Keys (`&`), Custom Colors, Background Images, and Containers (`GroupBox` vs. `Panel`).
* **Debugging Tools:** Logic errors, Breakpoints, Break mode, Locals Window, Watch Window, and Single-stepping (`F11`).

---

## 2.1 Reading Input with TextBox

### Concept Definition
A `TextBox` is a rectangular control on a form that allows the user to enter information via the keyboard.
* **Location:** `Toolbox` → `Common Controls`.
* **Default Names:** `textBox1`, `textBox2`, etc.

### Core Properties & Methods
* **`Text` Property:** Holds or retrieves the string content entered inside the control.
* **`Clear()` Method:** Erases all text inside the control.

### Ways to Clear a TextBox
```csharp
textBox1.Clear();                   // Preferred method
textBox1.Text = string.Empty;       // Alternative 1
textBox1.Text = "";                 // Alternative 2
