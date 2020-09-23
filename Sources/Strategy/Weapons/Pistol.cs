namespace Strategy
{
public class Pistol:Weapon {
public Pistol(){
    ShootBehave=new ShootBullet();
    ReloadBehave=new FillMagazine();
    Ammo="9mm.bullets";
    Weight="not too much";
    Length="not too much";
}

        public override void display()
        {

            System.Console.WriteLine("hello its me .The Pistol");
        }
}

}