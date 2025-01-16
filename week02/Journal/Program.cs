using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        
        Console.WriteLine("Hello World! This is the Journal Project.");
        
        Console.WriteLine("Please select one of the following choices");
        
        Console.WriteLine("\n 1. Write"+
                          "\n 2. Display"+
                          "\n 3. Load"+
                          "\n 4. Save"+
                          "\n 5. Quit");
        Console.Write("What would you like to do?");
        opcion = Convert.ToInt32(Console.ReadLine());

    }
} 