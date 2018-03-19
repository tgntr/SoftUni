public class Rectangle
{
    public string Id { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

    public double TopLeftX { get; set; }

    public double TopLeftY { get; set; }

    public Rectangle(string input)
    {
        var rectangleDetails = input.Split();

        Id = rectangleDetails[0];

        Width = double.Parse(rectangleDetails[1]);

        Height = double.Parse(rectangleDetails[2]);

        TopLeftX = double.Parse(rectangleDetails[3]);

        TopLeftY = double.Parse(rectangleDetails[4]);
    }

    public string Intersect (Rectangle rectangle)
    {
        if(TopLeftX <= rectangle.TopLeftX + rectangle.Width
            && TopLeftY <= rectangle.TopLeftY + rectangle.Height
            && TopLeftY + Height >= rectangle.TopLeftY
            && TopLeftX + Width >= rectangle.TopLeftX)
        {
            return "true";
        }
        return "false";
    }
}
