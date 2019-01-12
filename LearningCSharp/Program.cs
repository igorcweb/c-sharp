using System;

namespace LearningCSharp
{

    class Book
    {
        public string title;
        public string author;
        public int pages;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name:  ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age:  ");
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello " + name + ". You are " + age + " years old.");
            //Console.ReadLine();

            //Console.Write("Enter the first number:  ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the second number:  ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            //Console.ReadLine();

            //string color, pluralNoun, celebrity;

            //Console.Write("Enter color: ");
            //color = Console.ReadLine();

            //Console.Write("Enter plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter celebrity name: ");
            //celebrity = Console.ReadLine();


            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I love " + celebrity);

            //int[] luckyNumbers = { 4, 8, 15, 16, 43, 22 };
            //string[] friends = new string[5];

            //luckyNumbers[4] = 23;
            //luckyNumbers[5] = 42;

            //friends[0] = "Jim";

            //Console.WriteLine(luckyNumbers[4]);


            //Console.ReadLine();

            //Methods


            //SayHi("Igor", 43);
            //Console.ReadLine();

            //int cubedNumber = Cube(5);
            //Console.WriteLine(cubedNumber);
            //Console.ReadLine();

            //bool isMale = true;
            //bool isTall = false;

            //if(isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male");
            //}
            //else if(isMale && !isTall)
            //{
            //    Console.WriteLine("You are a male who is not tall");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male and not tall.");
            //}

            //Console.ReadLine();

            //Console.WriteLine(result);
            //Console.WriteLine(GetMax(2, 10, 5));
            //Console.ReadLine();

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter an operator: ");
            //string op = Console.ReadLine();
            //Console.Write("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if(op == "+")
            //{
            //    Console.Write(num1 + num2);
            //} else if(op == "-")
            //{
            //    Console.Write(num1 - num2);
            //} else if(op == "*")
            //{
            //    Console.Write(num1 * num2);
            //} else if(op == "/")
            //{
            //    Console.Write(num1 / num2);
            //}
            //else
            //{
            //    Console.Write("Invalid Operator");
            //}

            //Console.ReadLine();


            //Console.WriteLine(GetDay(4));
            //Console.ReadLine();
            //int index = 1;
            //while(index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}
            //Console.ReadLine();

            //Guessing Game
            //string secretWord = "monkey";
            //string guess = "";
            //int index = 0;
            //int guessLimit = 3;
            //do
            //{
            //    Console.Write("Enter Guess:  ");
            //    guess = Console.ReadLine();
            //    index++;
            //    if (index == guessLimit && guess.ToLower() != secretWord.ToLower())
            //    {
            //        Console.WriteLine("You are out of guesses");
            //        return;
            //    }
            //}


            //while (guess.ToLower() != secretWord.ToLower() && index <= 5);


            //Console.WriteLine("You got it!");

            //Console.ReadLine();


            //for(int i = 1; i <=5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();

            //int[] luckyNums = {4, 8, 15, 16, 23, 42 };

            //for(int i = 0; i < luckyNums.Length; i ++)
            //{
            //    Console.WriteLine(luckyNums[i]);
            //}
            //Console.WriteLine(GetPow(2, 0));
            //Console.ReadLine();


            //Two dimentional arrays
            //int[,] numberGrid = {
            //    {1, 2},
            //    {3, 4},
            //    {5, 6}
            //};

            //Console.WriteLine(numberGrid[1, 1]);

            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1 / num2);
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Code Completed");
            //}


            //Console.ReadLine();

            Book book1 = new Book();

            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();

            book2.title = "Lord of the Rings";
            book2.author = "Tolkien";
            book2.pages = 700;

            Console.WriteLine(book1.title);

            Console.ReadLine();
        }

        //static int GetPow(int baseNum, int powNum)
        //{
        //    int result = 1;
        //    for(int i = 0; i < powNum; i++)
        //    {
        //        result *= baseNum;
        //    }

        //    return result;
        //}

        //static string GetDay(int dayNum)
        //{
        //    string dayName;

        //    switch(dayNum)
        //    {
        //        case 0:
        //            dayName = "Sunday";
        //            break;
        //        case 1:
        //            dayName = "Munday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;
        //        default:
        //            dayName = "Invalid Day Number";
        //            break;
        //    }

        //    return dayName;
        //}


        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + ". You are " + age);
        //}

        //static int Cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}

        //static double GetMax(double num1, double num2, double num3)
        //{
        //    double result;
        //    if(num1 >= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    } else if(num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    }
        //    else
        //    {
        //        result = num3;
        //    }

        //    return result;
        //}
    }
}
