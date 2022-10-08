using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1
{
    public class Tshirts : Products
    {
        public string shirtMaterial { get; set; }
        public string shirtSize { get; set; }

        public Tshirts(string shirtMaterial, string shirtSize, string productMotive, double productPrice, decimal averageScore)
        {
            this.shirtMaterial = shirtMaterial;
            this.shirtSize = shirtSize;
            this.productMotive = productMotive;
            this.productPrice = productPrice;
            this.averageScore = averageScore;
        }
    }
}
