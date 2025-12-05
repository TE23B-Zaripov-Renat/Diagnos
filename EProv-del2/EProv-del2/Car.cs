public class Car
{
    public int Passangers;
    public int ContrabandAmount;
    public bool AlreadyChecked;

    public bool Escape;

    public bool Examine()
    {
        int randomcars = Random.Shared.Next(1,4);
        if (randomcars == ContrabandAmount)
        {
            Escape = true;
        }

        else
        {
            Escape = false;
        }
        AlreadyChecked = true;
        return true;
    }
}