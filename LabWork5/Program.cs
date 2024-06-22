using LabWork5;

class Program
{
    static void Main()
    {
        //Task1
        Book book1 = new Book();
        Book book2 = new Book("Евгений Онегин", "A.C. Пушкин", 568);
        Book book3 = new Book("Собачье сердце", "М.А. Булгаков", 889);
        Book book4 = new Book("", "", -1);

        //Task2
        book1.Print();
        book2.Print();
        book3.Print();

        //Task3
        Console.WriteLine($"Название: {book1.GetTitle}");
        Console.WriteLine($"Автор: {book2.GetAuthor}");
        Console.WriteLine($"Цена: {book3.GetPrice}");

        Console.WriteLine($"Название: {book4.GetTitle}");
        Console.WriteLine($"Автор: {book4.GetAuthor}");
        Console.WriteLine($"Цена: {book4.GetPrice}");

        try
        {
            book4.GetTitle = "";
            book4.GetAuthor = "";
            book4.GetPrice = -1;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

