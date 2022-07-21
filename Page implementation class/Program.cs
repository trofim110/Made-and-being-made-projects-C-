
public class PageableCollection<T>
{
    private List<T[]> _page;
    private int pageNumber=0;


    public PageableCollection(List<T[]> Page,int size) //Конструктор
    {
        _page = Page;

        if (Page.Count == 0)
        {
            throw new Exception("Вы ввели пустую коллекцию ");
        }


        for (int indexPage = 0; indexPage < _page.Count; indexPage++)
        {
            if (_page[indexPage].Length > size)
            {
                throw new Exception("Данных в странице больше положенного");
            }
            else if (_page[indexPage].Length < size)
            {
                throw new Exception("Данных в странице меньше положенного");
            }

            for (int indexArr = 0; indexArr < _page[indexPage].Length; indexArr++)
            {
                if (_page[indexPage][indexArr] == null)
                {
                    throw new Exception("в листе есть null");
                }
            }
        }
    }
    public int PageNumber
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



    public int PageCount() {  return _page.Count;} // количество страниц в колекции
    public int CurrentPageNumber() { return PageNumber;}  // Текущий номер страници





    public void TurnPages(int pageCount,char direction) //переворачивает" страницы на pageCount количества в направлении Direction
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
    public void TurnPageForward()=>PageNumber++;  //переварачивает" на следующую страницу
    public void TurnPageBackward()=> PageNumber--; //переворачивает" страницу назад
    public void OpenPage(int PageNumber) //устанавливает ("открывает") текущую страницу на pageNumber
    {
        try
        {
            this.PageNumber = PageNumber;
            foreach (var arr in _page[PageNumber])
            {
                Console.WriteLine(arr);
            }

        }
        catch (ArgumentOutOfRangeException)
        {
           Console.WriteLine("Введите корректные данные в деапозоне допустимых значений");
        }

    }


    public bool deletingPage(T[] delete) { return  _page.Remove(delete); } // удаляет элемент колекции
    public bool occurrenceOfAnElement(T[] Element){ return _page.Contains(Element); }  // Вхождение элемента в колекцию



    public   T[] GetPageByIndex(int Index)  //возвращает элементы страницы соответствующей индексу в коллекции страниц
    {
        try
        {
            return _page[Index];
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new Exception("Вы попробывали выйти за пределы");
        }

    }

    public T[] GetCurrentPage() //возвращает элементы с текущей страницы (начинается с 0)
    {
        return _page[PageNumber];
    }

    public T[] GetNextPage() // возвращает элементы со следующей страницы
    {
        try
        {
          return _page[++PageNumber];
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
            return _page[--PageNumber];
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new Exception("Вы попробывали выйти за пределы");

        }
    }
}




















































































