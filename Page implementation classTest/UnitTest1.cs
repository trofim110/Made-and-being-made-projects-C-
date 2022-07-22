using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;
using Xunit.Sdk;

namespace Page_implementation_classTest;

public class ReturningPageValues
{
    [Fact]
    public void UnitTest1()
    {
        int[] a = new[] { 1, 2, 3,4,5};
        int[] b = new[] { 6, 7, 8,9,10 };

        List<int[]> aa = new List<int[]>() {a,b};

        var Pages= new PageableCollection<int>(aa, 5);

        Assert.Equal(Pages.GetPageByIndex(0),a );
        Assert.Equal(Pages.GetNextPage(),b);
        Assert.Equal(Pages. GetCurrentPage(),b);
        Assert.Equal(Pages.GetPreviousPage(),a);

    }
}
public class PageFunctions
{
    [Fact]
    public void UnitTest1()
    {
        int[] a = new[] { 1, 2, 3,4,5};
        int[] b = new[] { 6, 7, 8,9,10 };
        int[] c = new[] { 11, 12, 13,14,15 };
        int[] d = new[] { 16, 17, 18,19,20 };
        int[] e = new[] { 21, 22, 23,24,25 };
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


