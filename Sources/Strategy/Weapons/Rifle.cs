namespace Strategy
{

public class Rifle:Weapon{

public Rifle(){
    ShootBehave=new ShootBullet();
    ReloadBehave=new FillMagazine();
    Ammo="50mm.bullets";
    Weight="pretty heavy";
    Length="long enough";
    
}
        public override void display()
        {

            System.Console.WriteLine("hello its me .The Rifle");
        }
}
}