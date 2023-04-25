using System;

class Program
{
    static void Main(string[] args)
    {
        int finish = 99999999;
        
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a number (0 to quit): ");
        while (finish != 0)
        {
            Console.Write("Enter a number: ");

            string userEntry = Console.ReadLine();
            finish = int.Parse(userEntry);
            
            // Only add the number to the list if it is not 0
            if (finish != 0)
            {
                numbers.Add(finish);
            }
          
        }
    
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;


        
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}