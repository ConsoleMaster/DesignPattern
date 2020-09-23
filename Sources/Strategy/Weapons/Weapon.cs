using System;

namespace Strategy
{
    public abstract class Weapon
    {
        public Weapon()
        {

        }
        public IReloadBehave ReloadBehave;
        public IShootBehave ShootBehave;
        public string Ammo;
        public string Weight;
        public string Length;

        public abstract void display();

        public void setShootBehave(IShootBehave sb){
            ShootBehave=sb;
        }
        public void setReloadBehave(IReloadBehave rb){
            ReloadBehave=rb;
        }

        public void performShoot()
        {
            ShootBehave.shoot();
        }
        public void performReload()
        {
            ReloadBehave.reload();
        }




    }
}
