using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1
{
    internal class StoreInfo
    {
        public static void storeinfo()
        {
            string storeAddress = "34 Ash Tree Lane, Mugcity.\n";
            string invoiceAddress = "43 Money Tree Grove, Moneytown.";
            string storeInfo = "Royal Shirts and Mugs is a fancy company with deep ties in important places. \nHere you will find the most outragous shirts and mugs.\n";
            string Menu = "\nHow do you want to proceed?\n\n1: Show available T-shirts\n2: Show available mugs\n3: Take me out of here";
            

            Console.WriteLine("Welcome!\n\n" + storeInfo + " \nWe are currently located at " + storeAddress + "\nIf you have any questions regarding payments or invoices,\n" +
                "do not hasitate to contact us at " +
                invoiceAddress + "\n" + Menu);

        }
    }
}
