using System;

class Program
{
    static void Main(string[] args)
    {
        string MENU = " 1. Moroni 10:5 \n 2. 3 Nephi 3:11 \n 3. Moroni 10: 29-30 \n Please, choose a scripture to memorize: ";
        Console.WriteLine(MENU);
        int userInput = int.Parse(Console.ReadLine());
        switch (userInput)
        {
            case 1:
                string text = "And by the power of the Holy Ghost ye may know the truth of all things";
                Scripture scripture1 = new Scripture(text);
                Reference reference1 = new Reference("Moroni", 10, 5);
                UserInterface(scripture1,reference1);
                break;

            case 2:
                text = "Behold, I am Jesus Christ, whom the prophets testified shall come into the world.";
                Scripture scripture2 = new Scripture(text);
                Reference reference2 = new Reference("3 Nephi", 3, 11);

                UserInterface(scripture2,reference2);
                break;

            case 3:
            text = "And God shall show unto you, that that which I have written is true. And again I would exhort you that ye would come unto Christ, and lay hold upon every good gift, and touch not the evil gift, nor the unclean thing";
            Scripture scripture3 = new Scripture(text);
            Reference reference3 = new Reference("Moroni", 10, 29,30);

            UserInterface(scripture3,reference3);
            break;
        }
    } 
    static void UserInterface(Scripture scripture, Reference reference)
    {
        string userInput = "";
        while (userInput.ToUpper() != "QUIT") 
        {
            Console.Clear();
            Console.WriteLine(reference.GetReference());
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }  
}