using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1
{
    public class ProductDataGenerator
    {
        public static string[] ProductMotive = new string[] {"Tikka Massala", "Bigfoot", "Cat", "Cannibal", "Wendigo", "Leatherface", "Tractor",
        "Book", "Bloody Knife", "Cursed Doll", "Scarecrow", "Medusa", "Pizza", "Hot dog", "Burrito", "Athena", "Zeus", "Bear", "Bird", "Asparagus",
        "Avocado", "Indian Coder", "Strawberry", "Egg", "Dragon", "Fox", "Panda", "Moose", "Cthulhu", "Axe"}; //Alla produktmotiv i en array


        public static string MotiveGenerator()
        {
            string s;
            Random motiveRoll = new Random();
            s = ProductMotive[motiveRoll.Next(0, (ProductMotive.Length))];
            return s;

        }


        public static double Price() //genererar priset till produkten
        {
            Random priceRoll = new Random();
            int rollValue = priceRoll.Next(0, 9);
            int[] weight = new int[] { 99, 129, 139, 139, 149, 149, 159, 199, 249 };
            double b = (double)weight[rollValue];
            return b;
        }

        public static decimal AverageScore() //Genererar snittbetyget till produkten
        {
            Random scoreRoll = new Random();
            double doubleOne = scoreRoll.NextDouble();
            decimal decimalTwo = Convert.ToDecimal(doubleOne * scoreRoll.Next(1, 11));
            decimalTwo = Math.Round(decimalTwo, 1);
            return decimalTwo;

        }

        //Ändra till decmial och convert to decimal (se nevenas kod) för att forcera till exempel 0.0

        public static string ShirtSize()
        {
            Random sizeRoll = new Random();
            int sizeRollValue = sizeRoll.Next(0, 7);
            string[] size = new string[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" };
            string b = (string)size[sizeRollValue];
            return b;

        }

        public static string ShirtMaterial()
        {
            Random shirtMaterialRoll = new Random();
            int shirtMaterialRollValue = shirtMaterialRoll.Next(0, 7);
            string[] material = new string[] { "Cotton", "Wool", "Polyester", "Elastane", "Linen", "Silk", "Leather" };
            string b = (string)material[shirtMaterialRollValue];
            return b;
        }

        public static string CupType()
        {
            Random cupTypeRoll = new Random();
            int cupTypeRollValue = cupTypeRoll.Next(0, 7);
            string[] type = new string[] { "Coffee Cup", "Tea Cup", "Wooden Mug", "Porcelain Cup", "Drinking Horn", "Red party Cup", "Paper Cup" };
            string b = (string)type[cupTypeRollValue];
            return b;
        }

        //Använda AddRange()?

    }
}
