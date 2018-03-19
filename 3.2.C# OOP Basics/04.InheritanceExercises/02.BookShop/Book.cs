using System;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    public string Author
    {
        get
        {
            return author;
        }
        set
        {
            var name = value.Split();
            if (name.Length > 1 && Char.IsDigit(name[1][0]))
            {
                throw new ArgumentException("Author not valid!");
            }
            author = value;
        }
    }

    public decimal Price
    {
        get
        {
            return price;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }


    public Book(string author, string title, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public Book()
    {

    }

    public override string ToString()
    {
        return $"Type: {this.GetType().Name}\nTitle: {Title}\nAuthor: {Author}\nPrice: {Price:F2}";
    }
}
