using System.Buffers.Text;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 05
            #region 1
            //Explain the difference between passing(Value type parameters)
            //by value and by reference then write a suitable c# example.
            /*
             * it has two cases 
             * 1 - Passing by value : simply it make a copy from the data that we pass to the function 
             * then the data changed only in the body of the method and can't change outside it 
             * 2 - Passing by ref : simply instead of passing a copy of the value we pass 
             * the location or passing the acutual data to the function so when we modify anything in the 
             * function it changed outside it
             */

            //Value Type - Passing by value 
            //int x = 10;

            //ModifyNumber(x);

            //Console.WriteLine(x);// 10 because we Pass it by value

            //Value type - Passing by ref
            //int x = 10;

            //ModifyNumber(ref x);

            //Console.WriteLine(x);// 11 because we Pass it by ref

            #endregion

            #region 2
            //Explain the difference between passing(Reference type parameters)
            //by value and by reference then write a suitable c# example.
            /*
             *it has two cases 
             *in the two cases it will modify the original argument that we passed to the function but 
             *there is a tweak between them..
             *1 - Passing by value : it will make a new object in the stack and this object will hold the 
             *same adress for the data in the heap for the real argument
             *Ex : if we have a function that takes an array then return the sum of this array 
             *if we pass an array to this function it will make a new array in the stack that hold the reference
             *of the real array then if i modify..
             *
             *2 - Passing by ref: it will modify the real Array..
             *
             */

            //Reference type - Passing by value
            //int[] arr = { 1, 2 };

            //Console.WriteLine(arr[0]); // 1

            //GetMax(arr); // This makes a new arr in the stack that refer to the same data in the heap 

            //Console.WriteLine(arr[0]); //100 


            //Passing by ref 
            //int[] arr = { 1, 2 };

            //Console.WriteLine(arr[0]); // 1

            //GetMax(ref arr); //100 -> this time it's modify the original array  

            //Console.WriteLine(arr[0]); //100 


            //if we need to modify or assign this array to another array in the function 
            // if we passing by value it will affect the new array 
            //if we pass by ref it will affect the real Array


            /*
             * in this examples we pass an array by value but in the method we assign the array with
             * new array 
             * if we try try to print the first element of the array it will give me 2 because we try to 
             * get the first element from the real array 
             */
            //int[] arr01 = { 2, 4 };

            //GetMax(arr01);

            //Console.WriteLine(arr01[0]); // 2

            //By Ref
            //here it will give 7 because in the GetMax function we modify the real array
            //int[] arr01 = { 2, 4 };

            //GetMax(ref arr01);

            //Console.WriteLine(arr01[0]); // 7
            #endregion

            #region 3
            //Write a c# Function that accept 4 parameters
            //from user and return result of summation and subtracting of two numbers
            //SumSub(10, 4, out int result01, out int result02);
            //Console.WriteLine(result01);

            //Console.WriteLine(result02);

            //Another Solution
            //int[] result = SumSub02(10, 5);

            //Console.WriteLine(result[0]);

            //Console.WriteLine(result[1]);



            #endregion

            #region 4
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7

            //Console.WriteLine(SumOfDigits(125));



            #endregion

            #region 5
            //Create a function named "IsPrime", which receives
            //an integer number and retuns true if it is prime, or false if it is not:
            //Console.WriteLine(isPrime(3));
            #endregion

            #region 6
            //Create a function named MinMaxArray,
            //to return the minimum and maximum values stored in an array, using reference parameters

            //SOlutin 01 
            //int[] arr = { 1, -1, 3, 4, 5, 100, };
            //int[] result = MinMax01(arr);

            //Console.WriteLine(result[0]);
            //Console.WriteLine(result[1]);

            //Solution 02 
            //int[] arr = { 1, -1, 3, 4, 5, 100, };
            //MinMax02(arr,out int min , out int max);
            //Console.WriteLine(min);
            //Console.WriteLine(max);

            //Solution 03 Params
            //int[] result = MinMax03(1, 2, 3, 10, 60);
            //Console.WriteLine(result[0]);
            //Console.WriteLine(result[1]);
            #endregion

            #region 7
            //Create an iterative(non - recursive)
            //function to calculate the factorial of the number specified as parameter
            //int result = Factorial(5);
            //Console.WriteLine(result);

            #endregion

            #region 8
            //Create a function named "ChangeChar" 
            //to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            string result = ChangeChar("ebrahem",'x', 4);
            Console.WriteLine(result);
            #endregion

        }

       static string ChangeChar(string word , char ch , int index) 
        {
            string newString = "";

            for(int i = 0; i < word.Length; i++) 
            {
                if(i == index) 
                {
                    newString += ch;
                    continue;
                }

                newString += word[i];
            }

            return newString;
        }

        static int Factorial(int number)
        {
            // 5 -> 5 * 4 * 3 *  2 * 1 
            int reuslt = 1;
            for (int i = 1; i <= number; i++)
            {
                reuslt *= i;

            }
            return reuslt;

        }

        static int[] MinMax03(params int[] arr)
        {
            Array.Sort(arr);

            Array.Reverse(arr);

            return new int[] { arr[0], arr[arr.Length - 1] };
        }

        static void MinMax02(int[] numbers, out int Min, out int Max)
        {
            Array.Sort(numbers);

            Array.Reverse(numbers);

            Min = numbers[numbers.Length - 1];

            Max = numbers[0];
        }

        static int[] MinMax01(int[] numbers)
        {
            Array.Sort(numbers);

            Array.Reverse(numbers);

            return new int[] { numbers[0], numbers[numbers.Length - 1] };
        }

        static bool isPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            for (int i = 2; i <= number / 2; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int SumOfDigits(int number)
        {
            /*
             * Convert number to String
             * Loop through this string then calculate the sum
             */
            int sumResult = 0;

            string convertedNumber = number.ToString();

            for (int i = 0; i < convertedNumber.Length; i++)
            {
                sumResult += Convert.ToInt32(convertedNumber[i].ToString());
            }




            return sumResult;
        }

        static int[] SumSub02(int x, int y, int sumResult = 0, int subResult = 0)
        {
            sumResult = x + y;

            subResult = x - y;

            return new int[] { sumResult, subResult };
        }

        static void SumSub(int x, int y, out int sum, out int sub)
        {
            sum = x + y;

            sub = x - y;
        }

        static void GetMax(ref int[] arr)
        {
            arr = new int[] { 7, 8, 9, 10, };

            Console.WriteLine(arr[0]);

        }

        static void ModifyNumber(ref int number)
        {
            number++;
        }


    }
}




