public class TyreFactory
{
    public static Tyre CreateTyre(string[] details)
    {
        var type = details[0];

        var hardness = double.Parse(details[1]);

        if (type == "Ultrasoft")
        {
            var grip = double.Parse(details[2]);

            return new UltrasoftTyre(hardness, grip);
        }
        return new HardTyre(hardness);
    }
}
