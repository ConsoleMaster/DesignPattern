namespace Strategy
{

public class Firegun:Weapon{

public Firegun(){
    ShootBehave=new ShootFire();
    ReloadBehave=new AssembleCapsule();
    Ammo="oil";
    Weight="too much";
    Length="too much";
}

        public override void display()
        {

            System.Console.WriteLine("hello its me .The Firegun");
        }
}
}