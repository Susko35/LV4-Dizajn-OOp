using System;

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

        }
    }
}
