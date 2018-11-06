using System;
namespace Starbuzz 
{
    public abstract class Beverage
    {
        string description = "Unknown Beverage";
        public string getDescription()
        {
            return description;
        }
        public abstract double cost();
    }
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Most Excellent Dark Roast";
        }
        public double cost()
        {
            
        }
    }
}