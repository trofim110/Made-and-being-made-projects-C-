
public class PageableCollection<T>
{
    private List<T> _page;
    private int pageNumber=0;
    private int index=0;
    private int pageCount;


    // Логика: Индекс страници и номер страници одно и тоже
    // Плюс + это работа со страницой
    // Минус - это работа с индексом


    public PageableCollection(List<T> Page)
    {
        _page = Page;
        if (Page.Count == 0)
        {
            throw new Exception("Вы ввели пустую коллекцию ");
        }

        for (int i = 0; i < _page.Count; i++)
        {
            if (_page[i] == null)
            {
                throw new Exception("Один из элементов null ");
            }
        }
    }



    public int PageNumber //+
    {
        get{return  pageNumber;}
        set
        {
            if (value >= 0 && value < _page.Count)
            {
                pageNumber = value;
            }
            else
            {
                Console.WriteLine("Вы вышли за допустимые пределы колекции ");
            }
        }
    }
    public int Index  //-
    {
        get{ return index;}

        set
        {
            if  (value >= 0 && value < _page.Count)
            {
                index = value;
            }
            else
            {
                Console.WriteLine("Ошибка вышли за допустимые пределы индекса");
            }
        }
    }


    public int PageCount() {  return _page.Count;} // количество страниц в колекции
    public int CurrentPageNumber() { return PageNumber;}  // Текущий номер страници  +
    public int CurrentPageIndex(){return Index;}  // текущий индекс     +



    public void IndexPlus()=>Index++;  // следущий индекс  -
    public void IndexMinus()=>Index--; //предыдущий индекс  -


    public void TurnPages(int pageCount,char direction) //переворачивает" страницы на pageCount количества в направлении Direction +
    {
        switch (direction)
        {
            case '+' : PageNumber += pageCount;
                break;
            case '-' : PageNumber -= pageCount;
                break;
            default:Console.WriteLine("Введите либо + если хотите вперед - если хотите назад");
                break;
        }
    }
    public void TurnPageForward()=>PageNumber++;  //переварачивает" на следующую страницу +++++
    public void TurnPageBackward()=> PageNumber--; //переворачивает" страницу назад +++++
    public void OpenPage(int PageNumber) //устанавливает ("открывает") текущую страницу на pageNumber +++++++
    {
        try
        {
            this.PageNumber = PageNumber;
            Console.WriteLine((_page[PageNumber]));
        }
        catch (ArgumentOutOfRangeException)
        {
           Console.WriteLine("Введите корректные данные в деапозоне допустимых значений");
        }

    }


    public bool deletingPage(T delete)  // удаляет элемент колекции
    {
      return  _page.Remove(delete);
    }

    public bool occurrenceOfAnElement(T Element)  // Вхождение элемента в колекцию
    {
        return _page.Contains(Element);
    }


    public   T GetPageByIndex(int Index)  //возвращает элементы страницы соответствующей индексу в коллекции страниц -
    {
        try
        {
            return _page[Index];
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Введите корректные данные в деапозоне допустимых значений");
            return _page[Index];
        }

    }

    public T GetCurrentPage() //возвращает элементы с текущей страницы (начинается с 0) +++++++
    {
        return _page[PageNumber];
    }

    public T GetNextPage() // возвращает элементы со следующей страницы  ++++++
    {
        try
        {
          return _page[++PageNumber];
        }
        catch (ArgumentOutOfRangeException)
        {
          Console.WriteLine("Введите корректные данные в деапозоне допустимых значений");
          return _page[PageNumber];
        }

    }
    public T GetPreviousPage() // возвращает элементы с предыдущей страницы +
    {
        try
        {
            return _page[--PageNumber];
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Введите корректные данные в деапозоне допустимых значений");
            return _page[PageNumber];
        }
    }

}

public class Pas
{


}






class project
{
    static void Main()
    {

       var page = new List<int>()
       {

       }
       };
       var aaa = new PageableCollection<string>(page);

    }
}
