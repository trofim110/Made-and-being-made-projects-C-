class PageableCollection
{
    private List<string> _page = new List<string>();
    private int page;
    private int index;

    public int Index
    {
        get{ return index;}

        set
        {
            if (value >= 0 && value < _page.Count){ index = value;}
            else{Console.WriteLine("Ошибка вышли за допустимые пределы индекса");}
        }
    }

    public int Page
    {
        get{return page;}
        set
        {
            if (value > 0 && value < _page.Count){ page = value;}
            else{ Console.WriteLine("Ошибка вышли за допустимые пределы страници");}

        }
    }

    public PageableCollection(List<string> Page)=> _page = Page; //Конструктор



    public int PageCount() {  return _page.Count;} // количество страниц в колекции
    public int CurrentPageNumber() { return Page-1;}  // Текущий индекс



    public void TurnPages(int pageCount,string direction) //переворачивает" страницы на pageCount количества в направлении Direction
    {
        if (direction == "+"){ Page += pageCount;}
        else if(direction=="-"){ Page-=pageCount;}
        else{Console.WriteLine("Введите либо + если хотите вперед - если хотите назад");}
    }

    public void TurnPageForward()=> Page++;  //переварачивает" на следующую страницу
    public void TurnPageBackward()=> Page--; //переворачивает" страницу назад
    public void OpenPage(int pageNumber)=> Console.WriteLine(_page[Page]);  //устанавливает ("открывает") текущую страницу на pageNumber


}
class project
{
    static void Main()
    {
        List<string> page = new List<string>(){"111","2222","3333","4444"};
        PageableCollection aaa = new PageableCollection(page);

        Console.WriteLine(aaa.Page);
        Console.WriteLine(aaa.Page);
        Console.WriteLine(aaa.Page);
        Console.WriteLine(aaa.Page);
        Console.WriteLine(aaa.Page);


    }
}