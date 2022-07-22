
public class PageableCollection<T>
{

    public List<List<T>> _items;
    public int _pageSize;

    public int Pages { get; set; }
    public int index = 0;
    public List<T> ser;



    public PageableCollection(List<T> items, int pageSize)
    {
        var page = new List<T>();
       List<List<T>> pppp = new List<List<T>>();
        _pageSize = pageSize;



        for (int i = 0; i <items.Count; i++)
        {
            page.Add(items[i]);
            if (page.Count == pageSize)
            {
                pppp.Add(page);
                page.Clear();
            }
        }

        _items = pppp;
    }

    public int Index
    {
        get { return index;}
        set
        {
            if (value >= 0 && value < Pages)
            {
                index = value;
            }
            else
            {
                throw new Exception("Вышли за пределы страници");
            }
        }
    }

    int PageCount() //возвращает количество страниц в коллекции
    {
        return Pages;
    }
    int CurrentPageNumber() //возвращает индекс текущей страницы
    {
        return Index;
    }

    public void TurnPages(int pageCount,char direction) //переворачивает" страницы на pageCount количества в направлении Direction
    {
        switch (direction)
        {
            case '+' : Index += pageCount;
                break;
            case '-' : Index -= pageCount;
                break;
            default:Console.WriteLine("Введите либо + если хотите вперед - если хотите назад");
                break;
        }
    }
    public void TurnPageForward()=>Index++;  //переварачивает" на следующую страницу
    public void TurnPageBackward()=> Index--; //переворачивает" страницу назад
    public void OpenPage(int PageNumber) //устанавливает ("открывает") текущую страницу на pageNumber
    {
        try
        {
            for (int i = 0; i < _pageSize; i++)
            {
             Console.WriteLine( _items[PageNumber][i]);
            }


        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Введите корректные данные в деапозоне допустимых значений");
        }

    }


    public   T[] GetPageByIndex(int Index)  //возвращает элементы страницы соответствующей индексу в коллекции страниц
    {
        try
        {
            return _items[Index][];
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new Exception("Вы попробывали выйти за пределы");
        }

    }

    public T[] GetCurrentPage() //возвращает элементы с текущей страницы (начинается с 0)
    {
        return _items[Index][];
    }

    public T[] GetNextPage() // возвращает элементы со следующей страницы
    {
        try
        {
            return _items[++Index][];
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new Exception("Вы попробывали выйти за пределы");
        }

    }
    public T[] GetPreviousPage() // возвращает элементы с предыдущей страницы
    {
        try
        {
            return _;
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new Exception("Вы попробывали выйти за пределы");

        }
    }

}

class fff
{
    static void Main()
    {
        List<int> str = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var test = new PageableCollection<int>(str,5) {};
        Console.WriteLine(test._pageSize);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(test.OpenPage(0));
        }

    }
}


