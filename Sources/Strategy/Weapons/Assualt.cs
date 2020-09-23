namespace Strategy
{
    public class Assualt : Weapon
    {

        public Assualt()
        {
            ReloadBehave = new FillMagazine();
            ShootBehave = new ShootBullet();
            Ammo = "9mm.bullets";
            Weight = "ziad";
            Length = "ziadtar";

        }
        public override void display()
        {

            System.Console.WriteLine("hello displayport");
        }
    }

}