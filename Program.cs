using System.Drawing;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using ConsoleTableExt;

namespace Inlämningsuppgift_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generera listorna innan vi går in i menyn, så att de är desamma genom en hel session


            List<Cups> cupList = new List<Cups>();
            List<Tshirts> tshirtsList = new List<Tshirts>();

            int menuChoice;
            bool okInmatning = false;
            Console.ForegroundColor = ConsoleColor.Green;
            StoreInfo.storeinfo();
            while (!okInmatning)
            {
                okInmatning = int.TryParse(Console.ReadLine(), out menuChoice);
                if (!okInmatning)
                {
                    Console.WriteLine("Please enter an integer number that corresponds with one of the menu choices!");
                }
                switch (menuChoice)
                {
                    case 1:
                        for (int i = 0; i < 30; i++)
                        {

                            string s1 = ProductDataGenerator.ShirtMaterial();
                            string s2 = ProductDataGenerator.ShirtSize();
                            string s3 = ProductDataGenerator.MotiveGenerator();
                            double d1 = ProductDataGenerator.Price();
                            decimal d2 = ProductDataGenerator.AverageScore();

                            Tshirts tshirts = new Tshirts(s1, s2, s3, d1, d2);

                            tshirtsList.Add(tshirts);

                        }
                        Console.Clear();
                       
                        Console.WriteLine("Available T-shirts sorted by user rating (descending):\n\n ");
                        tshirtsList.Sort(delegate (Tshirts x, Tshirts y)
                        {
                            return y.averageScore.CompareTo(x.averageScore);
                        });
                        ConsoleTableBuilder
                        .From(tshirtsList)
                        .WithColumn("Material", "Size", "Print", "Price", "User Rating")
                        .ExportAndWriteLine();
                            
                        break;
                   
                    case 2:
                     
                        for (int i = 0; i < 30; i++)
                        {

                            string s1 = ProductDataGenerator.CupType();
                            string s2 = ProductDataGenerator.MotiveGenerator();
                            double d1 = ProductDataGenerator.Price();
                            decimal d2 = ProductDataGenerator.AverageScore();

                            Cups cups = new Cups(s1, s2, d1, d2);
                            cupList.Add(cups);
                        }
                        Console.Clear();
                        Console.WriteLine("Available mugs sorted by user rating (ascending):\n\n ");
                        cupList.Sort(delegate (Cups x, Cups y)
                        {
                            return x.averageScore.CompareTo(y.averageScore);
                        });

                        ConsoleTableBuilder
                        .From(cupList)
                        .WithColumn("Cup Type", "Print", "Price", "User Rating")
                        .ExportAndWriteLine();

                        break;
                    case 3:
                        Console.WriteLine("You want to get out of here, we get it! Bye now!");
                        break;
                    default: //Behöver jag en default här?
                        Console.WriteLine("Please enter an integer number that corresponds with one of the menu choices!");
                        break;
                }
                
                
                

            }
            Console.ReadLine();
        }
    }
}

/*
 Du har precis startat en butik på nätet där du säljer t-shirts och muggar med olika motiv. Butikens utbud består av 30 motiv för både muggar och t-shirts. Butiken har två adresser, en besöksadress och en för fakturering.  
Här finns information om t-shirts och muggar.
För t-shirts:

Motiv
Storlek
Material
Snittbetyg från användare (0–10)
Pris
För muggar:

Motiv
Typ
Snittbetyg från användare (0–10)
Pris  
Följande skall presenteras på skärmen  - Butikens information (inklusive adresser).

T-shirtutbud, sorterat efter snittbetyg från användare, fallande (högst överst). 
Muggutbud, sorterat efter snittbetyg från användare, stigande (minst överst).
Fiktiva data accepteras.
*/