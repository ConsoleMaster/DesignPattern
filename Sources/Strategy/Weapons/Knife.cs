namespace Strategy{

    public class Knife:Weapon{

public Knife(){
    ShootBehave=new ShootNothing();
    ReloadBehave=new CleanKnife();
    Ammo="nothing";
    Weight="so light";
    Length="it depends";
}
        public override void display()
        {

            System.Console.WriteLine("hello its me .The knife");
        }
    }
}