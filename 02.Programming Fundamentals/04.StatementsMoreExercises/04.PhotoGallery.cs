using System;

class PhotoGallery
{
    static void Main()
    {
        int photoNumber = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        double size = double.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        int digits = (size.ToString()).Length;
        Console.WriteLine("Name: DSC_{0:D4}.jpg", photoNumber);
        Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2} {3:D2}:{4:D2}", day, month, year, hours, minutes);
        string sizeFormat = "";
        if (digits >= 7)
        {
            sizeFormat = "MB";
            size /= 1000000;
        }
        else if (digits >= 4)
        {
            sizeFormat = "KB";
            size /= 1000;
        }
        else
        {
            sizeFormat = "B";
        }
        Console.WriteLine("Size: {0}{1}", size, sizeFormat);
        string type = "";
        if (width > height)
        {
            type = "landscape";
        }
        else if (width < height)
        {
            type = "portrait";
        }
        else
        {
            type = "square";
        }
        Console.WriteLine("Resolution: {0}x{1} ({2})", width, height, type);
    }
}

