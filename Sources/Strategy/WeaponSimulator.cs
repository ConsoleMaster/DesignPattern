namespace Strategy
{


    public class Weaponsimulator
    {

        public static void Main(string[] args)
        {

            Weapon assualt = new Assualt();
            assualt.performShoot();
            assualt.performReload();
            assualt.display();
            /*********************************************************/
            /*********************************************************/
            Weapon watergun = new WatergunToy();
            watergun.display();
            watergun.performReload();
            watergun.performShoot();
            FillMagazine fm = new FillMagazine();
            watergun.setReloadBehave(fm);
            watergun.performReload();


        }

    }

}