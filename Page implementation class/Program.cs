
public class PageableCollection<T>
{
    private int ingex;
    private List<List<T>> pages = new List<List<T>>();
    private int pageCount;

     public PageableCollection(List<T> items, int pageSize)
     {
         if (items.Count == 0)
         {
             throw new Exception("Вы ввели пустую колекцию");
         }

         for (int i = 0; i < items.Count; i++)
         {
             if (items[i]==null)
             {
                 throw new Exception("Ошибка в колекции Null");
             }
             else if (items==null)
             {
                 throw new Exception("Ошибка  Null");
             }
         }//Проверка на Null

         for (int i = 0; i < items.Count;)
        {
          pages.Add(items.GetRange(i,pageSize));//Добавляем страници в колекции
          if (items.Count-i>pageSize)
          {
              i += pageSize;
              if ((items.Count % pageSize!=0)&&(items.Count-i<pageSize)) // Проверка:(Остаток от деления не ноль)И(разница меду количеством элементов и индексом меньше чем размер страниц)
              {
                  pages.Add(items.GetRange(i,items.Count % pageSize));
                  pageCount = pages.Count;
                  break;
              }
          }
          else
          {
              break;
          }
        }
     }

     public int Index
     {
         get { return ingex; }
         set
         {
             if (value >= 0 && value < pageCount)
             {
                 ingex = value;
             }
             else
             {
                 Console.WriteLine("Вы вышли за граници ");
             }
         }
     }

    public int PageCount() //возвращает количество страниц в коллекции
     {
         return pageCount;
     }
    public int CurrentPageNumber() //возвращает индекс текущей страницы
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
             foreach (var VARIABLE in pages[PageNumber])
             {
                 Console.WriteLine(VARIABLE);
             }
         }
         catch (ArgumentOutOfRangeException)
         {
             Console.WriteLine("Введите корректные данные в деапозоне допустимых значений");
         }
     }


     public bool deletingPage(List<T> delete)
     {
         return  pages.Remove(delete);
     }

     public List<T> GetPageByIndex(int Index)  //возвращает элементы страницы соответствующей индексу в коллекции страниц
     {
         try
         {
             return pages[Index];
         }
         catch (ArgumentOutOfRangeException)
         {
             throw new Exception("Вы попробывали выйти за пределы");
         }

     }
     public List<T> GetCurrentPage() //возвращает элементы с текущей страницы (начинается с 0)
     {
         return pages[Index];
     }
     public List<T> GetNextPage() // возвращает элементы со следующей страницы
     {
         try
         {
             return pages[++Index];
         }
         catch (ArgumentOutOfRangeException)
         {
             throw new Exception("Вы попробывали выйти за пределы");
         }

     }
     public List<T> GetPreviousPage() // возвращает элементы с предыдущей страницы
     {
         try
         {
             return pages[--Index];
         }
         catch (ArgumentOutOfRangeException)
         {
             throw new Exception("Вы попробывали выйти за пределы");

         }
     }

}



