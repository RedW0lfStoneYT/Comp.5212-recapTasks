using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConTasks1Through18
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.ReadKey();
        }

        Program()
        {
            int task;
            sendMessage();
            while (true)
            {

                Print("What task would you like to do: ");
                if (!int.TryParse(Console.ReadLine(), out task))
                {
                    Println("Try again!");
                    continue;
                }
                if (task > 18 || task < 1)
                {
                    Println("Try again!");
                    continue;
                }

                if (!Invoke($"task{task}"))
                {
                    Println("Try again!");
                    continue;
                }
                Console.Clear();
                sendMessage();
            }

        }


        // Utility functions

        // It is wayyyy better in java this.getClass().getMethod(name, paramTypes[]).invoke(obj, params[]);
        public Boolean Invoke(string methodName)
        {
            Type type = Type.GetType("ConTasks1Through18.Program");
            MethodInfo method = type.GetMethod(methodName);
            try
            {
                method.Invoke(type, null);
                Console.WriteLine();
                Print("Press anykey to restart!");
                Console.ReadKey();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void Println(object str)
        {
            Console.WriteLine($"\t{str}");
        }

        public static void Print(object str)
        {
            Console.Write($"\t{str}");
        }

        public void sendMessage()
        {
            Console.WriteLine("\n");
            Println("+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=+");
            Println("         Welcome to my crappy program!         ");
            Println("+=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=+");
            Console.WriteLine();
            Println("Please select what task you would like to run!");
            Println("+--------------------------------------------+");
            Println("1, add 2 numbers");
            Println("2, multiply 2 user inpit numbers");
            Println("3, greeting");
            Println("4, 1-100 across the screen");
            Println("5, 1-100 on new line");
            Println("6, 5-500 on one line, multiples of 5");
            Println("7, take 2 inputs and swap them");
            Println("8, odd or even user input");
            Println("9, largest of 3 user inputs");
            Println("10, multiples of a number between 1 & 12");
            Println("11, user input upper, lower, and length");
            Println("12, splitting user sentance and printint it");
            Println("13, hardcoded array of names");
            Println("14, random number array");
            Println("15, reverse a string");
            Println("16, multiplication table");
            Println("17, number triangle");
            Println("18, coordinates to quadrant");
            Console.WriteLine();
        }

        // Tasks 
        public static void task1()
        {
            int num1 = 74,
                num2 = 36,
                total = num1 + num2;

            Println($"{num1} + {num2} = {total}");
        }

        public static void task2()
        {
            int userNum1, userNum2, total;

            while (true)
            {
                Print("Please enter a number: ");
                if (!int.TryParse(Console.ReadLine(), out userNum1))
                {
                    Println("Try again!");
                    continue;
                }
                Print("Please enter another number: ");
                if (!int.TryParse(Console.ReadLine(), out userNum2))
                {
                    Println("Try again!");
                    continue;
                }
                break;
            }

            total = userNum2 * userNum1;
            Println($"{userNum1} x {userNum2} = {total}");

        }

        public static void task3()
        {
            string firstName, lastName, fullName;
            Print("Please enter your first name: ");
            firstName = Console.ReadLine();

            Print("Please enter your last name: ");
            lastName = Console.ReadLine();

            fullName = $"{firstName} {lastName}";

            Println($"Welcome {fullName}!!");
        }

        public static void task4()
        {
            Print("1");
            for (int i = 2; i <= 100; i++)
                Console.Write($", {i}");
        }

        public static void task5()
        {
            for (int i = 1; i <= 100; i++)
            {
                Println($"Line {i}!");
            }
        }

        public static void task6()
        {
            Print(5);
            for (int i = 10; i <= 500; i += 5)
            {
                Console.Write($" {i}");
            }
        }

        public static void task7()
        {
            int userNum1, userNum2, tempNum;

            while (true)
            {
                Print("Enter your first number: ");
                if (!int.TryParse(Console.ReadLine(), out userNum1))
                {
                    Println("Try again!");
                    continue;
                }

                Print("Enter your second number: ");
                if (!int.TryParse(Console.ReadLine(), out userNum2))
                {
                    Println("Try again!");
                    continue;
                }

                break;
            }

            tempNum = userNum1;
            userNum1 = userNum2;
            userNum2 = tempNum;

            Println($"Number 1 is now {userNum1}");
            Println($"Number 2 is now {userNum2}");

        }

        public static void task8()
        {
            int userNum;
            while (true)
            {
                Print("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out userNum))
                {
                    break;
                }
                Println("Try again!");

            }
            string oddEven = userNum % 2 == 0 ? "even" : "odd";
            Println($"{userNum} is {oddEven}");
        }

        public static void task9()
        {
            int userNum1, userNum2, userNum3, largest = 0;
            int[] numbers = new int[3];

            while (true)
            {
                Print("Enter a number");
                if (!int.TryParse(Console.ReadLine(), out userNum1))
                {
                    Println("Try again!");
                    continue;
                }

                Print("Enter another number");
                if (!int.TryParse(Console.ReadLine(), out userNum2))
                {
                    Println("Try again!");
                    continue;
                }

                Print("Enter yet another number");
                if (!int.TryParse(Console.ReadLine(), out userNum3))
                {
                    Println("Try again!");
                    continue;
                }

                break;
            }

            numbers[0] = userNum1;
            numbers[1] = userNum2;
            numbers[2] = userNum3;

            // slow for larger datasets
            foreach (int num in numbers)
            {
                if (num > largest)
                    largest = num;
            }

            Println($"The largest number is {largest}");
        }

        public static void task10()
        {
            int userNum;
            while (true)
            {
                Print("Enter a number between 1 and 12: ");
                if (int.TryParse(Console.ReadLine(), out userNum))
                {
                    if (!(userNum > 12 || userNum < 1))
                        break;
                }
                Println("Try again!");

            }
            for (int mult = 1; mult <= 12; mult++)
            {
                Println($"{userNum} x {mult} = {userNum * mult}");
            }
        }

        public static void task11()
        {

            string userMessage;
            Print("Please enter a sentence: ");
            userMessage = Console.ReadLine();

            Println(userMessage.ToLower());
            Println(userMessage.ToUpper());
            Println(userMessage.Length);
        }

        public static void task12()
        {
            string userMessage;
            Print("Please enter a sentence: ");
            userMessage = Console.ReadLine();
            string[] userArgs = userMessage.Split(" ");
            foreach (string str in userArgs)
            {
                Println(str);
            }
        }

        public static void task13()
        {
            string[] classmates = { "Jason", "Andrew", "Alex", "Regan", "Makaylee" };

            foreach (string classmate in classmates)
            {
                Println(classmate);
            }

        }

        public static void task14()
        {
            int[] randomNums = new int[50];

            Random random = new Random();
            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = random.Next();
            }
        }

        public static void task15()
        {
            string userString, reverse = "";
            Print("Enter a message to flip: ");
            userString = Console.ReadLine();
            for (int i = userString.Length - 1; i >= 0; i--)
            {
                reverse += userString[i];
            }

            Println(reverse);
        }

        public static void task16()
        {
            Console.WriteLine("x\t2x\t5x\t10x");
            for (int mult = 1; mult <= 10; mult++)
                Console.WriteLine($"{mult}\t{mult * 2}\t{mult * 5}\t{mult * 10}");
        }

        public static void task17()
        {
            for (int i = 1; i <= 5; i++)
            {
                Print(i);
                for (int j = 1; j <= i - 1; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                Print(i);
                for (int j = 1; j <= i - 1; j++)
                    Console.Write(i);
                Console.WriteLine();
            }
        }

        public static void task18()
        {
            Dictionary<string, string> quads = new Dictionary<string, string>();

            quads.Add("++", "I");
            quads.Add("-+", "II");
            quads.Add("--", "III");
            quads.Add("+-", "IV");

            string quadVal;

            int xin, yin;
            while (true)
            {

                Console.Write("Enter your x coordinate: ");
                if (!int.TryParse(Console.ReadLine(), out xin))
                {
                    Console.WriteLine("please try again");
                    continue;
                }

                Console.Write("Enter your y coordinate: ");

                if (!int.TryParse(Console.ReadLine(), out yin))
                {
                    Console.WriteLine("please try again");
                    continue;
                }

                quadVal = getxQuadVal(xin) + getyQuadVal(yin);

                Console.WriteLine($"Those cooedinates are in Quadrant {quads[quadVal]}");
                break;
            }

            Console.ReadKey();
            string getxQuadVal(int x)
            {
                return x < 0 ? "-" : "+";
            }

            string getyQuadVal(int y)
            {
                return y < 0 ? "-" : "+";
            }
        }

    }

}
