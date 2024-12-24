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

            int[] numbers = { 1, 2, 3 };

            //by value
            ModifyByValue(numbers);
            Console.WriteLine("After ModifyByValue: " + string.Join(", ", numbers)); // 10, 2, 3

            //by reference
            ModifyByReference(ref numbers);
            Console.WriteLine("After ModifyByReference: " + string.Join(", ", numbers)); // 100, 200, 300


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

    }
     
    }
