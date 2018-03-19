using System;

public class Box
{
    private double length;

    private double width;

    private double height;


    public double Length
    {
        get
        {
            return length;
        }
        set
        {
            if (value <= 0)
                throw new Exception("Length cannot be zero or negative.");
            else
                length = value;
        }
    }

    public double Width
    {
        get
        {
            return width;
        }
        private set
        {
            if (value <= 0)
                throw new Exception("Width cannot be zero or negative.");
            else
                width = value;
        }
    }

    public double Height
    {
        get
        {
            return height;
        }
        private set
        {
            if (value <= 0)
                throw new Exception("Height cannot be zero or negative.");
            else
                height = value;
        }
    }

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double SurfaceArea => (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);

    public double LateralSurfaceArea => (2 * Length * Height) + (2 * Width * Height);

    public double Volume => Length * Width * Height;

    public override string ToString()
    {
        return $"Surface Area - {SurfaceArea:F2}\nLateral Surface Area - {LateralSurfaceArea:F2}\nVolume - {Volume:F2}";
    }
}
