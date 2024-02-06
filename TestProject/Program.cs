namespace TestProject;

class Program
{
    static void Main(string[] args)
    {
        int myInt = 0;
        float myFloat = 3.14F;
        bool myBool = true;
        string myString = "The FSCJ field trip was boring.\n";

        Console.WriteLine("My Integer variable is " + myInt);
        Console.WriteLine("My Float variable is " + myFloat);
        Console.WriteLine("My Boolean variable is " + myBool);
        Console.WriteLine("My String variable is " + myString);

        for(int i = 0; i <= 20; i++){
            Console.WriteLine("I ate " + i + " slices of pizza for lunch.\n");
        }
    }
}
