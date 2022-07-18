public class PageableCollection<T>
{
    private List<T> _page;
    private int pageNumber=1;
    private int index=0;
    private ICollection<T> pag = new List<T>();


    public int PageNumber
    {
        get{return  pageNumber;}
        set
        {
            if (value > 0 && value < _page.Count){  pageNumber = value;}
            else{  Console.WriteLine("Вы вышли за допустимые пределы ");}

        }
    }
    public int Index
    {
        get{ return index;}

        set
        {
            if (value >= 0 && value < _page.Count){ index = value;}
            else{ Console.WriteLine("Ошибка вышли за допустимые пределы индекса");}
        }
    }


    public PageableCollection(List<T> Page)
    {
        _page = Page; //Конструктор
    }



    public int PageCount() {  return _page.Count;} // количество страниц в колекции
    public int CurrentPageNumber() { return PageNumber;}  // Текущий индекс

    public int CurrentPage() { return PageNumber+1;} //  текущая страница




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
            Console.WriteLine((_page[PageNumber - 1]));
        }
        catch
        {
           Console.WriteLine("Введите корректные данные");
        }

    }
    public   T GetPageByIndex(int index)  //возвращает элементы страницы соответствующей индексу в коллекции страниц
    {
        return _page[index];
    }

    public T GetCurrentPage() //возвращает элементы с текущей страницы (начинается с 0)\\ у меня с единици
    {
        return _page[index];
    }

  public T GetNextPage()
  {
      return _page[pageNumber++];
  }
  public T GetPreviousPage()
  {
      return _page[pageNumber--];
  }


}

class project
{
    static void Main()
    {
       var page = new List<string>(){"11111111","222222222","333333333"};
            var aaa = new PageableCollection<string>(page);

       Console.WriteLine(aaa.GetPageByIndex(7));

    }
}

