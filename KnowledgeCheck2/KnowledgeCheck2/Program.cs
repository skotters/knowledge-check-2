using System;

namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Hatchback>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myClass = new Hatchback();

                Console.WriteLine("Enter hatchback make:");
                myClass.Make = Console.ReadLine();

                Console.WriteLine("Enter hatchback model:");
                myClass.Model = Console.ReadLine();

                Console.WriteLine("Enter hatchback horsepower:");
                myClass.Horsepower = Convert.ToInt32(Console.ReadLine());

                recordList.Add(myClass);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var item in recordList)
            {
                Console.WriteLine($"The {item.Make} {item.Model} hatchback has {item.Horsepower} horsepower");
            }

        }
    }
}