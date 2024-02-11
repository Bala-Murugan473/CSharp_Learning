namespace CSharp_Learning.Methods
{
    /*
     * If we pass any variable inside the function brackets of a method signature, 
     * that variable is called parameter and the method is called parameterized method
     * a parameter can be any type.
	 * these parameters can be act as local variables for the method.
     * when calling the parameterized method, it is necessary to pass the appropriate arguments for the defined parameters, otherwise we will get compile time error(CS7036).
     */
    internal class ParameterizedMethod
    {
        // EXAMPLE - 1
        // Add is a parameterized method with two parameters of int type
        public void Add(int a, int b)
        {
            // a, b will act as local variables
            int c = a + b;
            Console.WriteLine("Sum of two given numbers is : " + c);
        }

        // EXAMPLE - 2
        // parameterized method with an array type parameter
        public void Add_All_Elements_In_Array(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            Console.WriteLine("Sum of all elements in given array is : " + sum);
        }

        // EXAMPLE - 3
        // parameterized method different parameter types (string and int types)
        public void EnterNameAndRoll(string name, int roll)
        {
            Console.WriteLine($"Name is : {name} and Roll is : {roll}");
        }

        // OPTIONAL PARAMETER
        /* As name indicates optional parameters are optional when calling the method
        * When declaring a method, these optional parameter will have a default value, so if no value is pass for optional parameter,
        * then the default value is used inside the method
        * it is necessary to define optional parameters at end (normal parameters cannot be defined after optional parameter)
        */
        public void EnterStateAndNation(string state, string nation = "India")
        {
            Console.WriteLine($"Given State is : {state} and Nation is : {nation}");
        }
        static void Main()
        {
            ParameterizedMethod P = new();
            P.Add(1, 2);

            int[] arr1 = { 1, 2, 3, 4, 5 };
            P.Add_All_Elements_In_Array(arr1);

            P.EnterNameAndRoll("bala", 2);

            P.EnterStateAndNation("TamilNadu");
            P.EnterStateAndNation("NewYork", "United States");
        }
    }
}
