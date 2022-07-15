class PageableCollection<T>
{
    private List<T> _page = new List<T>();
    private int pageNumber=1;
    private int index=0;



    public int PageNumber
    {
        get{return  pageNumber;}
        set
        {
            if (value > 0 && value < _page.Count){  pageNumber = value;}
            else{  Console.WriteLine("Вы вышли за допустимые пределы ");;}

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


    public PageableCollection(List<T> Page)=> _page = Page; //Конструктор



    public int PageCount() {  return _page.Count;} // количество страниц в колекции
    public int CurrentPageNumber() { return PageNumber-1;}  // Текущий индекс

    public int CurrentPage() { return PageNumber;} //  текущая страница




    public void TurnPages(int pageCount,string direction) //переворачивает" страницы на pageCount количества в направлении Direction
    {
        if (direction == "+"){ PageNumber += pageCount;}
        else if(direction=="-"){ PageNumber-=pageCount;}
        else{Console.WriteLine("Введите либо + если хотите вперед - если хотите назад");}
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
           Console.WriteLine("Вы вышли за допустимые пределы страниц  ");
        }

    }// Есть исключение



}
class project
{
    static void Main()
    {


            var page = new List<string>(){"343","2222","3333","4444"};
            var aaa = new PageableCollection<string>(page);
            Console.WriteLine(aaa.CurrentPage());
            aaa.TurnPageForward();
            Console.WriteLine(aaa.CurrentPage());
            aaa.TurnPageForward();
            Console.WriteLine(aaa.CurrentPage());
            aaa.TurnPageForward();
            Console.WriteLine(aaa.CurrentPage());
            aaa.TurnPageForward();
            Console.WriteLine(aaa.CurrentPage());
            aaa.OpenPage(5);
            Console.WriteLine(aaa.CurrentPage());
            aaa.TurnPages(2, "+");
    }
}

