using System;
namespace Starbuzz 
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";
        public string getDescription()
        {
            return description;
        }
        public abstract double cost();
    }
}