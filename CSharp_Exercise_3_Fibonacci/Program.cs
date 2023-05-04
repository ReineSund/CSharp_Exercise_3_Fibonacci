
  public class CSharp_Exercise_3_Fibonacci
  {
    static void Main(string[] args)
    {
      int n;
     
          // Ask the user for input
          Console.WriteLine("Function: To display the n number Fibonacci series :");
          Console.WriteLine("----------------------------------------------------");
          Console.Write("Input number of Fibonacci Series: ");
          n = Convert.ToInt32(Console.ReadLine()); // n is the input number
          Console.WriteLine("The Fibonacci series of " + n + " number is:"); // n is the 

          int n_1_Fibo = 0; // first number in Fibonacci serie has the value 0
          int n_2_Fibo = 1; // second number in Fibonacci serie has the value 
      int n_3_Fibo; // third number in Fibonacci is the value of first and second number

      for (int i = 0; i < n; i++) // this loop calculate the Fibonacci serie on the value of the users input
          {
            Console.Write($"{n_1_Fibo} ");
            n_3_Fibo = n_1_Fibo + n_2_Fibo;
            n_1_Fibo = n_2_Fibo;
            n_2_Fibo = n_3_Fibo;
          } 
    }
  }

