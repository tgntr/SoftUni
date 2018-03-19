public abstract class Food
{
    public int Points { get; private set; }

    public Food()
    {

    }

    public Food(int points)
    {
        Points = points;
    }

    public static Food GetFood(string food)
    {
        switch (food.ToLower())
        {
            case "cram":
                return new Cram();
            case "lembas":
                return new Lembas();
            case "apple":
                return new Apple();
            case "melon":
                return new Melon();
            case "honeycake":
                return new HoneyCake();
            case "mushrooms":
                return new Mushrooms();
            default:
                return new Other();
        }
    }
}