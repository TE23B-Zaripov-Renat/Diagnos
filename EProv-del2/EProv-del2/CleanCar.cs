public class CleanCar : Car
{

    public CleanCar()
    {
        int randomcars = Random.Shared.Next(1, 4);      //Slumpar antal bilar
        Passangers = randomcars;
        ContrabandAmount = 0;

    }
}