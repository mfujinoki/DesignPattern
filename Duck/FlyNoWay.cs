using System;
namespace Duck{
    public class FlyNoWay : IFlyBehavior{
        public void fly(){
            Console.WriteLine("I can't fly.");
        }
    }
}