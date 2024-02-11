namespace CSharp_Learning.Methods
{
    internal class NonParameterizedMethod
    {
        public void MyMethod()
        {
            Console.WriteLine("This is my method");
        }

        public string NormalMethodWithReturnValue()
        {
            string currentDate = DateTime.Now.ToString();
            Console.WriteLine("Current Date is : "+currentDate);
            return currentDate;
        }
        static void Main()
        {
            var NP = new NonParameterizedMethod();
            NP.MyMethod();
            NP.NormalMethodWithReturnValue();
        }
    }
}
