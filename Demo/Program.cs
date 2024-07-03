namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing - Unboxing

            #region What is this? 
            /*
          * Boxing : Convert from Value type to Reference type
          * Unboxing : convert from Reference type to value type 
          * 
          * Benifits : boxing and unboxing it's a expensive process 
          * When we box a value we create another object on the stack that hold an adress for the data on the heap.
          * When we unboxing we will create another Variable to store the data that we unboxing it 
          * We use Generics Instead of Boxing and unboxing.
          * Website: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
          */
            #endregion

            #region Boxing Example
            ////Boxing 
            //int x = 10;
            //object obj = x;
            ///*
            //* [Stack]         [Heap]
            //* [x = 10]
            //* [obj (addr)] -> [int x = 10]
            //* We used alot of memory to Boxing
            //*/
            #endregion

            #region Unboxing Example
            ////Unboxing 
            //int x02 = 10;
            //object obj02 = x02;
            //int z = (int)obj02;
            ///* 
            // * [Stack]         [Heap]
            // * [x02 = 10]
            // * [obj02 (addr)] -> [int x = 10]
            // * [int z = 10]
            // * 
            // * We used alot of memory to Boxing and unboxing
            // */
            #endregion

            #endregion

            #region Nullable Value Type

            #region Notes
            /*
             * - Nullable values cames from Nullable<> but Microsoft SImplify it with ? 
             * - Value type as it's defauly it's not nullable values 
             * Website: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types#code-try-1
             */

            //We can assign a non nullable value to a nullable value type.
            //int nonNullNumber = 10;

            //int? nullNumber = nonNullNumber;

            ////We can't assign a nullable value to a non nullable value type.

            //int? nullNumber2 = null;

            ////int z = nullNumber2; //error 

            ////We can make a tweak to out code to tell the compiler that the comming value will be int 

            //int z = (int) nullNumber2; 
            #endregion

            #region Check If Null
            /**************Hasvalue - Value Method**************/

            //1 USING Has value AND Value

            //int? nullableNum = null;

            //int nonNullNum;

            //if (nullableNum.HasValue) 
            //{
            //    nonNullNum = (int) nullableNum.Value;
            //}
            //else
            //{
            //    nonNullNum = 0;
            //}

            /************** If Method**************

            //int? nullableNum = null;

            //int nonNullNum;

            //if(nullableNum != null) 
            //{
            //    nonNullNum = (int) nullableNum;
            //}
            //else
            //{
            //    nonNullNum = 0;
            //}

             /**************Ternary Operator Method**************

            //int? nullableNum = null;

            //int nonNullNum;

            //nonNullNum = nullableNum != null ? nullableNum.Value : 0; 

             /**************Null Colleasing Method**************/

            //int? nullableNum = null;

            //int nonNullNum;

            //nonNullNum = nullableNum ?? 0;

            //Console.WriteLine(nonNullNum);

            #endregion

            #endregion

            #region Nullable Reference Type

            #region Notes
            //Null is the default Value for Reference Type
            // disable nullable option in the project setting
            //or pass ! [Null forgiveness Operator] at the end of the value
            #endregion

            #region Examples
            /*string Message = null;*/ //This is Default we don't need to pass ? after datatype - Valid With Warning
            string Message = null!; //Null Forgiveness Operator (!)

            string? Message2 = null;//Here we told the compiler that this Message02 will hold a null value

            #endregion

            #endregion

            #region Null Propagation Operator
            //We use Propagation operator ? to identify the null..
            //When to use Null propagation Operator?
            //if we have to check for multiple null items 


            int[] arr = default; // Default is Null

            //In this example it will not throw an exception because we use Null propagation operator
            //for(int i = 0; i < arr?.Length; i++) 
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Another way we use If condition befor Looping through the array
            //if (arr is not null)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            //Another way we use Ternary operator 

            //int? arrLen = null;
            //for (int i = 0; i < arrLen; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            ////arrLen = arrLen != null ? arrLen : 0;

            ////Another way 
            //arrLen = arrLen ?? 0;
            //Console.WriteLine(arrLen);

            #region Ex01
            //Employee emp = new Employee();
            //Console.WriteLine(emp?.Department?.Name ?? "Not Found");
            #endregion


            #endregion


            #region Functions
            /*
             * What is Function?
             * function is the block that contain some code that we can resue it anywhere
             * it reduce the complexity of the application
             */

            //Function Declare 
            //[Acsses Modefier - [ClassMember or Object Member] - return type - name (parameter)] 

            DoNothing(); // Call the function By It's Name 
                         //Static Function Means we can directly call it using The parent class 

            //Function Parameters 
            /*
             * We have two Types of parameter
             * value type - Reference type
             * Both option has two option another Them (Passing by value - Passing by ref)
             *
             */

            //Value Type - Passing by value 
            /*
             * in this we passing by value meaning we smiply take a copy from the arguement
             * that we passed to the array then perform the operation on it 
             * all the changes happen iside the function body dut didn't affect the world 
             * outer the function
             */


            //int x = 10;
            //Console.WriteLine(x); // 10 
            //IncrementByOne(x);
            //Console.WriteLine(x); // 10

            //Value type - Passing by ref 
            /*
             * in this we pass the value if self to the function or we pass the 
             * place where the real value sit meaning if we have an int x = 10 
             * then we have a function that increament the number by one if we pass 
             * x to int it will change the value of x to 11
             * meaning it's change the real value of the passed argument
             */

            //int z = 10;

            //Console.WriteLine(z); // 10

            //IncrementByOne(ref z);

            //Console.WriteLine(z); // 11



            //Passing Referecnce type 
            /*
             * Passing by value :
             * if we use passing by value in reference type it will change the real object
             * meaning it will create another obect in the stack that hold the same adress of the real
             * arguement that we passed to it 
             */
            //int[] arr01 = { 1, 2, 4 };
            //Console.WriteLine(arr01[0]); // 1

            //ModifyArr(arr01);

            //Console.WriteLine(arr01[0]); // 100

            //Passing by ref 
            /*
             * it will do the same but this time it will not create another object in the stack
             * it will go directly and update the real argument that we passed to the function
             */

            //int[] arr01 = { 1, 2, 4 };
            //Console.WriteLine(arr01[0]); // 1

            //ModifyArr(ref arr01);

            //Console.WriteLine(arr01[0]); // 100



            #endregion

        }
        static void ModifyArr02(ref int[] arr)
        {
            arr = new int[] { 7, 8, 9 };
           
        }

        static void ModifyArr(ref int[] arr) 
        {
            arr[0] = 100;
        }

        static void IncrementByOne(ref int number)
        {
            number++;
        }

        //Declare Simple Function
        static void DoNothing()
        {
            //Logic
        }
    }
}
