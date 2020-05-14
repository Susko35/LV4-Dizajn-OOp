using LV4_Dizajn_OOP.Fasada;
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

            HotItem hitVid = new HotItem(new Video("Hit video"));
            DiscountItem discountBook = new DiscountItem(new Book("Discount knjiga"));
            rentList.Add(hitVid);
            rentList.Add(discountBook);
            printer.DisplayItems(rentList);
            printer.PrintTotalPrice(rentList);

            EmailValidator emailValidator = new EmailValidator(12);
            PasswordValidator passwordValidator = new PasswordValidator(6);
            String passwordToCheck = new string("sIFra23sd");
            String passwordToCheck2 = new string("si3sd");
            String emailToCheck = new string("emailkojzadovoljavauvjet@nesto.com");
            String emailToCheck2 = new string("emailnezadovoljava@sd@.rand");

            Console.WriteLine("\n\nProvjera: ");
            Console.WriteLine("sIFra23sd: "+passwordValidator.IsValidPassword(passwordToCheck));
            Console.WriteLine("si3sd: " + passwordValidator.IsValidPassword(passwordToCheck2));
            Console.WriteLine("emailkojzadovoljavauvjet@nesto.com: " + emailValidator.IsValidAddress(emailToCheck));
            Console.WriteLine("emailnezadovoljava@sd@.rand: " + emailValidator.IsValidAddress(emailToCheck2));
        }
    }
}
