class PageableCollection<T>
{
    private List<string> _page = new List<string>();
    private int pageCount;
    private int index = 0;
    private string __Page ;


    public PageableCollection(List<string> Page)
    {
        _page = Page;
        index = _page.Count-1;
    } //Конструктор
    public int PageCount()
    {
        pageCount = _page.Count;
        return pageCount;
    }  // количество страниц
    public int CurrentPageNumber()   // Текущий индекс
    {
        return index;
    }


    public void TurnPages(int pageCount, Direction direction)
    {
        index = pageCount * direction.left;
    }

    public void TurnPageForward()=> index++;  //переварачивает" на следующую страницу
    public void TurnPageBackward()=> index--; //переворачивает" страницу назад
    public void OpenPage(int pageNumber)=> Console.WriteLine(_page[index]);  //устанавливает ("открывает") текущую страницу на pageNumber



    string GetPageByIndex(int index)
    {
        __Page = _page[index];
        return __Page;
    }

    string GetCurrentPage(int index)
    {
        __Page = _page[index];
        return
    }

    ICollection<T> GetNextPage()
    {

    }

    ICollection<T> GetPreviousPage()
    {

    }

}


class project
{
    static void Main()
    {
        List<string> page = new List<string>(){"111","2222","3333","4444"};
        PageableCollection aaa = new PageableCollection(page);


        Console.WriteLine(aaa.PageCount());
        Console.WriteLine(aaa.CurrentPageNumber());







    }
}