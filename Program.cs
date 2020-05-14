using System;
using System.Collections.Generic;

namespace LV4_Dizajn_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dataset csvFile = new Dataset("adapterinput.txt");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            Console.WriteLine("Prosjek redaka: ");
            for (int i = 0; i<3;i++)
                Console.WriteLine(adapter.CalculateAveragePerRow(csvFile)[i]);
            Console.WriteLine("Prosjek stupaca: ");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(adapter.CalculateAveragePerColumn(csvFile)[i]);

            List<IRentable> rentList = new List<IRentable>();
            Video video = new Video("Video dokumentarac");
            Book book = new Book("Knjiga fantazija");
            rentList.Add(video);
            rentList.Add(book);

            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(rentList);
            printer.PrintTotalPrice(rentList);
        }
    }
}
