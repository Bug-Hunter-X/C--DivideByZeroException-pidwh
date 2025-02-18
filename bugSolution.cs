public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        int y = 0;
        int z = 0; 

        if (y != 0)
        {
            z = x / y; 
        }
        else
        {
            //Handle the case where y is zero
            Console.WriteLine("Cannot divide by zero.");
        }
        //Alternatively using the null-coalescing operator ??
        int z2 = x / (y == 0 ? 1 : y);
    }
}