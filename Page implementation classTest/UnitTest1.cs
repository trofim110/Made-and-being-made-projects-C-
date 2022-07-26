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
    public void testPageDatssssssssssssssssssssssssssssssssa ()
    {
        var str = new List<int>() { 1, 2, 3, 4, 5, };
        var test = new PageableCollection<int>(str,3) {};

        Assert.Throws<Exception>(() =>test.GetPreviousPage());
        test.TurnPageForward();
        Assert.Throws<Exception>(() =>test.GetNextPage());
        Assert.Throws<Exception>(() =>test.GetPageByIndex(5));
    }
}












/*
public class PageFunctions
{
    [Fact]
    public void UnitTest1()
    {

        List<int[]> aa = new List<int[]>() {a,b,c,d,e};

        var Pages= new PageableCollection<int>(aa, 5);

        Assert.Equal(Pages.PageCount(),5 );
        Pages.TurnPages(2, '+');
        Assert.Equal(Pages.CurrentPageNumber(),2);
        Pages.TurnPageForward();
        Assert.Equal(Pages.CurrentPageNumber(),3);
        Pages.TurnPageBackward();
        Assert.Equal(Pages.CurrentPageNumber(),2);
    }
}
public class Exceptions
{
    [Fact]
    public void MethodExceptions()
    {
        int[] array1 = new[] { 1, 2, 3,4,5};
        int[] array2 = new[] { 6, 7, 8,9,10 };

        List<int[]> MethodUnderTest = new List<int[]>() { array1, array2,};

        var Pages= new PageableCollection<int>(MethodUnderTest, 5);

        Assert.Throws<Exception>(() =>Pages.GetPreviousPage());
        Pages.TurnPageForward();
        Assert.Throws<Exception>(() =>Pages.GetNextPage());
        Assert.Throws<Exception>(() =>Pages.GetPageByIndex(5));
    }

}
*/

