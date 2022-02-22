
**Welcome to week one of COMP.5212 - Programming**

**Introduction and Recap on Basic C# (selection, iteration & arrays)**

*To start let’s introduce ourselves and take attendance!*

**Windermere Course Details**

Two lessons per week; One in class, one online.

*Some motivated students can be considered to do this course completely online, 
but you will need to get the approval of your tutor to do this.*

We will use two online platforms for the delivery of this course:

- Microsoft Teams
- Install MS Teams and go through:
  - Teams & channels (general etc)
  - Chat, call & video call
  - Calendar
  - Activity
- Attendance and apologies, the student code of conduct and your student rights.
- Microsoft Visual Studio


**THEORY – can you explain what each of the following parts of a program are?**

Using directives

Namespace

Class

Method (Main) 

Variables (data types![](Aspose.Words.d12615f0-85f6-49b5-8e1f-95bf70882bc3.001.png)) 


**The most common data types you will use on this course are:**

**string** is used for storing text, many chars. string fName = “Shelly” (IN DOUBLE QUOTES)

**char** is used for storing a single character. char f = 's'; (NOTE THE SINGLE QUOTES)

**int** is short for integer, used for storing whole numbers. int num = 5; (NOTE NO QUOTES)


**double** Non-integer - 14 significant digits

**float** Non-integer – 7 significant digits

**decimal** Non-integer - 28 significant digits (integer and fraction)

**bool** – true or false value only

**Declaring and Initializing Variables recap**

*IMPORTANT:  The C# language reserves 77 identifiers for its own use, and you cannot reuse these identifiers for your own purposes. These identifiers are called **keywords***

We can declare (set up) and initialize (give an initial value to) a variable in the following two ways, as one or two lines of code;

int a; //declare an integer

a = 20; //assign a value into an integer

int b = 30; //declare and initialise an integer

string FName; //declare a string


**Using methods from the Console class recap**

Can you explain what each of the following methods do?

- Console.Write(); 
- Console.WriteLine(); 
- Console.ReadKey(); 
- Console.ReadLine(); 

**Using string methods and properties**

Can you explain what each of the following methods and properties do?

- .Length; 
- .ToUpper(); 
- .ToLower(); 
- .Split(); s 
- .Equals();Good string methods and properties and see what others you can find and try testing some out.

**Recap Exercise:**

Have a go at the following exercises to recap and refresh your brain on what we learnt last semester prior to OOP.  The exercises start of very simple and get more and more challenging as you go.

1. Write a console application to store in two variables the numbers; 
   74 & 36, add them together and store the result in a third variable, then display the result to the screen.  
   Then tidy the output to display as an equation like so: 
   **i.e. 74 + 36 = 110**

***QUESTION**:  Did you use placeholders {0} or the concatenator + to display the equation??*  Try to use the other in the next program!

2. Write another console application that takes two numbers as input from the user (i.e. not hardcoded) and display the *product (multiplication)* of the two numbers.  Use three variables in this program and display result as an equation like so:
   (i.e. 2 x 4 = 8)

**Reminder you will need to convert the input to store as an integer:**

Convert.ToInt32 or int.Parse

3. Write a console application that accepts the users first name and last name and then greets them by saying hello followed by their full name.  Use three variables (ie:  fName, lName, fullName).  Remember to include a space between their first and last name when storing in fullname.

4. Write a console application that displays 1 – 100 across the screen using a for loop.  Each number with a space and comma in between.  
   i.e:  1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, etc…

5. Once the above is working try copying and pasting the for loop and amending it to display…
   Line 1! 
   Line 2! 
   Line 3! 
   Line 4! etc… each on a new line.

6. Then try to write another for loop to display the numbers 5 to 500 in multiples of five across the screen with a space in between only.  
   i.e. 5 10 15 20 25 30 etc…

7. Write a console application that asks the user to enter two numbers, num1 and num2, then swap the two variables and display back to the screen.
   (i.e.  test data:

**Enter num1: 8** 

**Enter num2: 5,** 

*Expected output:*

**num1 is 5**

**num2 is 8)**


8. Write a console application which obtains an integer from the user and then tells them if it is an odd or even number.  Use the modulus symbol (%) to do this.

9. Write a console application that takes three numbers from the user and displays the largest number on the screen.

(i.e.  test data:

**Enter number 1:  25**

**Enter number 2:  78**

**Enter number 3:  87**

*Expected output:*

**The largest is 87**

NOTE:  Write your own code to work out which number is the largest.

10. Write a console application that asks the user for a number between 1 and 12 and then display the times tables for that number.**  
   Use a loop for this.  

(i.e.  test data:

**Enter a number between 1 & 12:  5**
**5 x 1 = 5
5 x 2 = 10 
5 x 3 = 15** 

etc…
…


**5 x 12 = 60**


11. Write a new console application which receives a sentence.  Display it all in lowercase and then display it all in uppercase.  Also display the length of the sentence.

**Reminder you will need to use the string .ToUpper and .ToLower  methods and the .Length property to do this**

12. Using the above sentence, split the sentence at a space and add each element to an array of strings.  Display using a foreach loop.

**Reminder you will need to use the string .split method to do this**


13. Write a console application that contains an array of size 5 and populate with 5 class mates’ names and display them back to the screen using a foreach loop.  

14. Create an array of 50 integers and then using a for loop populate it with random integers.  Remember declaring a random object looks like this:  **Random generator = new Random();**



15. Write a new console application which receives a string (one word) and then treating it like an array of chars, display it in reverse using a for loop.  Also display the length of the string.


16. Display the following Table of numbers writing only one Console.WriteLine within a for loop.  Use x as the counter variable inside the for loop, which will loop from 1 to 10.

**x&nbsp;&nbsp;2x&nbsp;&nbsp;5x&nbsp;&nbsp;10x**
1&nbsp;&nbsp;2&nbsp;&nbsp;5&nbsp;&nbsp;10
2&nbsp;&nbsp;4&nbsp;&nbsp;10&nbsp;&nbsp;20
3&nbsp;&nbsp;6&nbsp;&nbsp;15&nbsp;&nbsp;30
…
10&nbsp;&nbsp;20&nbsp;&nbsp;50&nbsp;&nbsp;100


17. Write a program that displays the following triangle of numbers using nested for loops

1
12
123
1234
12345

Then try this one

1
22
333
4444
55555

18. Write a Console program to accept X and Y coordinates from the user and then determine in which quadrant the coordinate point lies based on the diagram and example program below:

![](Aspose.Words.d12615f0-85f6-49b5-8e1f-95bf70882bc3.002.png)

**NOTE:  This graph should help you to understand the four** 	**:**

![](Aspose.Words.d12615f0-85f6-49b5-8e1f-95bf70882bc3.003.png)

