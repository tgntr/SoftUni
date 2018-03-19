internal class BagFactory
{
    internal static Bag CreateBag(string type)
    {
        if (type == "Satchel")
        {
            return new Satchel();
        }
        return new Backpack();
    }
}