// Класс "Книга"
public class Book

{ 
    
    // Поля
    public string _title;
    public string _author;
    public int _pages;

    // Конструктор
    public Book(string title, string author, int pages)
    {
        _title = title;
        _author = author;
        _pages = pages;
    }

    // Переопределение метода ToString()
    public override string ToString()
    {
        return $"Автор: {_author}, Название: {_title}";
    }

}

// Класс "Библиотека"
public class Library : List<Book>
{
    // Метод для сортировки книг по возрастанию количества страниц
    public void SortByPages()
    {
        this.Sort((book1, book2) => book1._pages.CompareTo(book2._pages));
    }

    // Метод для вывода списка книг в консоль
    public void PrintBooks()
    {
        foreach (Book book in this)
        {
            Console.WriteLine(book.ToString());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов книг
        Book book1 = new Book("Книга 1", "Автор 1", 200);
        Book book2 = new Book("Книга 2", "Автор 2", 150);
        Book book3 = new Book("Книга 3", "Автор 3", 300);
        Book book4 = new Book("Книга 4", "Автор 4", 100);
        Book book5 = new Book("Книга 5", "Автор 5", 250);

        // Создание объекта библиотеки
        Library library = new Library();

        // Добавление книг в библиотеку
        library.Add(book1);
        library.Add(book2);
        library.Add(book3);
        library.Add(book4);
        library.Add(book5);

        // Сортировка книг по возрастанию количества страниц
        library.SortByPages();

        // Вывод списка книг в консоль
        library.PrintBooks();
    }
}