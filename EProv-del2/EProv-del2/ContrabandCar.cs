public class ContraBandCars : Car
{

    public ContraBandCars()
    {
        int randomcars = Random.Shared.Next(1, 5);
        Passangers = randomcars;
        randomcars = ContrabandAmount;
    }
}