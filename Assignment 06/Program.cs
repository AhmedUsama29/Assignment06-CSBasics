namespace Assignment_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /*
           --Passing by value:  the method gets a copy of the reference
            Changes to the object's properties inside the method will affect the original object because both the 
            original reference andthe method reference point to the same object in memory

           --Passing by reference:the method works with the original reference itself, not a copy
            This means the method can modify the reference to point to a completely new object, 
            and this change will be reflected outside the method
             */


            //Example

            //int[] numbers = { 1, 2, 3 };

            ////by value
            //ModifyByValue(numbers);
            //Console.WriteLine("After ModifyByValue: " + string.Join(", ", numbers)); // 10, 2, 3

            ////by reference
            //ModifyByReference(ref numbers);
            //Console.WriteLine("After ModifyByReference: " + string.Join(", ", numbers)); // 100, 200, 300


            #endregion

            #region Q2: Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int sum, mul;
            //SumMul(10, 20, out sum, out mul);
            //Console.WriteLine("Sum: " + sum); // 30
            //Console.WriteLine("Mul: " + mul); // 200

            #endregion

            #region Q3: Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] arr = { 10, 20, 30, 40, 50 };
            //int min, max;
            //MinMaxArray(arr, out min, out max);
            //Console.WriteLine("Min: " + min); // 10
            //Console.WriteLine("Max: " + max); // 50

            #endregion
        }

        #region Q1 Methods
        static void ModifyByValue(int[] arr)
        {

            arr[0] = 10;

            arr = new int[] { 50, 60, 70 };
        }

        static void ModifyByReference(ref int[] arr)
        {

            arr = new int[] { 100, 200, 300 };
        }
        #endregion

        #region Q2 Methods
        static void SumMul(int num1, int num2, out int sum, out int mul)
        {

            sum = num1 + num2;
            mul = num1 * num2;

        }
        #endregion

        #region Q3 Methods
        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
        } 
        #endregion

    }
     
    }
