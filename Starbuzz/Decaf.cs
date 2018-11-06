using System;
namespace Starbuzz 
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }
        public double cost()
        {
            return 1.05;
        }
    }
}