using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static string JobQuote(string Job)
    {
        if (Job == "Developer")
        {
            return "Logical thinking, passion and perserverance is the paint on your palette.";
        }
        else if (Job == "Engineer")
        {
            return "The engineer has been, and is, a maker of history.";
        }
        else if (Job == "Analyst")
        {
            return "Seeing what other people can't see gives you great vision.";
        }
        else
        {
            return "I'm sorry. We could not find a quote for your job.";
        }
    }
    
    static void Main(string[] args)
    {
        string Job;

        Console.Write("Enter your job: ");
        while (string.IsNullOrWhiteSpace(Job = Console.ReadLine()))
        {
            Console.Write("Please enter your job: ");
        }

        Console.WriteLine(JobQuote(Job));
    }
}
