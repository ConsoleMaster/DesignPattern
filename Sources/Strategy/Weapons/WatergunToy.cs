namespace Strategy
{
public class WatergunToy:Weapon{
public WatergunToy(){

    ShootBehave=new ShootWater();
    ReloadBehave=new FillTunker();
    Ammo="water";
    Weight="light";
    Length="it depends";
}

        public override void display()
        {

            System.Console.WriteLine("hello its me .The Watergun");
        }
}
}