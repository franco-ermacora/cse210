using System;
using System.IO;
public class Program
{
    static void Main(string[] args)
    {   
 
        int number = -1;
        TxtRead texts = new TxtRead();
        Question qts = new Question();
        Console.WriteLine("Welcome to the Journal Project");
    do {
        
        Console.WriteLine();
        Console.Write("Choose a option: ");
        Console.WriteLine();
        Console.WriteLine("1) Write");
        Console.WriteLine("2) Display");
        Console.WriteLine("3) Save");
        Console.WriteLine("4) Load(Comming Soon...)");
        Console.WriteLine("5) Exit");
        number = int.Parse(Console.ReadLine());

        
        
        
        switch(number)
        {
            case 1:
                Entry newEntry = new Entry();

                newEntry._date = DateTime.Today.ToString("MM/dd/yyyy");
                newEntry._prompt = qts.GetQuestion();
                Console.WriteLine($"{newEntry._prompt}");
                newEntry._answer = Console.ReadLine();
                texts._entries.Add(newEntry);
                break;
            
        
            case 2:
            Console.WriteLine();
            texts.Displaytexts();
            Console.WriteLine();
            break;
        
            case 3:
            Console.WriteLine();
            Console.WriteLine("What is the filename?");
            string file = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(file))
            {
    
                foreach (Entry entry in texts._entries)
                {
                    outputFile.WriteLine($"Date: {entry._date} - {entry._prompt} {entry._answer}");
                }     
            };
            break;

            case 4:
            Console.WriteLine();
            Console.WriteLine("Thank you for understanding ♡");
            Console.WriteLine();
            
            break;
        }    
        } while (number != 5);
    }
}