# Week 3: Chapter 3 - Making Decisions (Part 1)
### Decision Structures, Conditional Logic & Logical Operators

This week covers how C# programs make decisions using conditional statements, relational operators, nested structures, and logical operators based on *Starting Out with Visual C#*.

--------------------------------------------------------------------------------------------------

## Topics Covered

1. **Decision Structures & the `if` Statement (Topic 4.1)**
   * **Concept:** Executes statements only when a specific boolean condition evaluates to true.
   * **Relational Operators:** >, <, >=, <=, ==, !=.
   * **Code Example:**
     ```csharp
     if (sales > 50000)
     {
         bonus = 500;
     }
     ```

2. **The if-else Statement (Topic 4.2)**
   * **Concept:** Provides two alternative paths of execution; one if the condition is true, and another if it is false.
   * **Code Example:**
     ```csharp
     if (temp > 40)
     {
         MessageBox.Show("hot");
     }
     else
     {
         MessageBox.Show("cold");
     }
     ```

3. **Nested Decision Structures & if-else-if (Topic 4.3)**
   * **Concept:** Testing multiple conditions by placing decision structures inside one another or chaining `else if` blocks.
   * **Code Example:**
     ```csharp
     if (score >= 90)
         grade = "A";
     else if (score >= 80)
         grade = "B";
     else
         grade = "C";
     ```

4. **Logical Operators (Topic 4.4)**
   * **&& (AND):** Both subexpressions must be true.
   * **|| (OR):** One or both subexpressions must be true].
   * **! (NOT):** Reverses the truth value of an expression.

5. **bool Variables and Flags (Topic 4.5)**
   * **Concept:** Using bool variables (true or false) to act as flags indicating whether a specific condition exists.
