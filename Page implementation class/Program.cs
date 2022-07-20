
public class PageableCollection<T>
{
    private List<T> _page;
    private List<T[]> _pageArr;
    private int pageNumber=0;
    private int index=0;
    private int pageCount;


    // Логика: Индекс страници и номер страници одно и тоже
    // Плюс + это работа со страницой
    // Минус - это работа с индексом


    public PageableCollection(List<T> Page)  //Конструктор для простой колекции
    {
        _page = Page;

        if (Page.Count == 0) { throw new Exception("Вы ввели пустую коллекцию "); }

        for (int i = 0; i < _page.Count; i++)
        {
            if
                (_page[i] == null)
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
    public PageableCollection(List<T[]> Page,int size) //Конструктор для масива
    {
        _pageArr = Page;

        if (Page.Count == 0)
        {
            throw new Exception("Вы ввели пустую коллекцию ");
        }


        for (int indexPage = 0; indexPage < _pageArr.Count; indexPage++)
        {
            if (_pageArr[indexPage].Length > size)
            {
                throw new Exception("Данных в странице больше положенного");
            }

            for (int indexArr = 0; indexArr < _pageArr[indexPage].Length; indexArr++)
            {
                if (_pageArr[indexPage][indexArr] == null)
                {
                    throw new Exception("в листе есть null");
                }
            }
        }
    }

}

class trofim
{
    public int rost { get; set; }
    public int ves  { get; set; }
    public int age  { get; set; }
}
class project
{
    static void Main()
    {


        int[] a = new[] { 1, 2, 3,4,5 };
        int[] b = new[] { 6, 7, 8,9,10 };
        int[] c = new[] { 11, 12, 13,14,15 };
        int[] d = new[] { 16, 17, 18,19,20 };
        int[] e = new[] { 21, 22, 23,24,25 };
        List<int[]> aa = new List<int[]>() {a,b,c,d,e};
       var aaa = new PageableCollection<int>(aa,5);
     Console.WriteLine(aa[1][1]);
     Console.WriteLine("----------------------------");

     var poi =new PageableCollection<trofim>()
     {

     }





    }
}






















































































