using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1
{
    public class Cups : Products
    {
        public string cupType { get; set; }
        public Cups(string cupType, string productMotive, double productPrice, decimal averageScore)
        {
            this.cupType = cupType;
            this.productMotive = productMotive;
            this.productPrice = productPrice;
            this.averageScore = averageScore;
        }

    }
}
