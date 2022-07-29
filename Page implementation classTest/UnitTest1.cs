using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;
using Xunit.Sdk;

namespace Page_implementation_classTest;

public class PageFunctions
{
    [Fact]
    public void Indextest()
    {
        List<int> str = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11};
        var test = new PageableCollection<int>(str,3) {};

        Assert.Equal(test.PageCount(),4 );
        test.TurnPages(2, '+');
        Assert.Equal(test.CurrentPageNumber(),2);
        test.TurnPageForward();
        Assert.Equal(test.CurrentPageNumber(),3);
        test.TurnPageBackward();
        Assert.Equal(test.CurrentPageNumber(),2);

    }
}
public class PageData
{
    [Fact]
    public void testPageData ()
    {
      var str = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11};
      var str1 = new List<int>() { 1, 2, 3 };
      var str2 = new List<int>() { 4, 5, 6 };
      var str3 = new List<int>() { 7, 8, 9 };
      var test = new PageableCollection<int>(str, 3) { };



        Assert.Equal(test.GetPageByIndex(0), str1);
        test.TurnPageBackward();
        Assert.Equal(test.GetCurrentPage(),str1);
        test.TurnPageBackward();
        Assert.Equal(test.GetNextPage(),str2);
        Assert.Equal(test.GetPreviousPage(),str1);

    }
}
public class Exceptions
{

   [Fact]
    public void testExceptions ()
    {
        var str = new List<int>() { 1, 2, 3, 4, 5, };
        var test = new PageableCollection<int>(str,3) {};

        Assert.Throws<Exception>(() =>test.GetPreviousPage());
        test.TurnPageForward();
        Assert.Throws<Exception>(() =>test.GetNextPage());
    }


}
