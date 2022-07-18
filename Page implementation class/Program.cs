public class PageableCollection<T>
{
    private List<T> _page;
    private int pageNumber;
    private int index;
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

    ICollection<T> GetPageByIndex(int index)
    {
        return _page[index];
    }


}

 public class webpage
{
    public int Column1 { get; set; }
    public int Column2 { get; set; }
    public int Column3 { get; set; }




}
class project
{
    static void Main()
    {


            var page = new List<webpage>()
            {
                new webpage() {Column1 = 1,Column2 = 2,Column3 = 3},
                new webpage() {Column1 = 1,Column2 = 2,Column3 = 3},
                new webpage() {Column1 = 1,Column2 = 2,Column3 = 3},
                new webpage() {Column1 = 1,Column2 = 2,Column3 = 3}
            };
            var aaa = new PageableCollection<webpage>(page);

        Console.WriteLine(aaa.PageCount());
        Console.WriteLine(aaa.  CurrentPage());

Console.WriteLine(page[0]);



    }
}

