using System;
namespace Strategy
{

public class ShootNothing:IShootBehave{public void shoot() { Console.WriteLine("<<Silence>>"); } }
}