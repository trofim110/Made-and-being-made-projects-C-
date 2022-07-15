using System.Collections.Generic;
using Xunit;

namespace Page_implementation_classTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        List<string> page = new List<string>() { "223", "334", "3244" };
        int pageNumber = 3;
        int index = 2;



        // Act
        var Book = new PageableCollection<string>(page);
        Book.PageCount();
        Book.CurrentPage();


        // Assert
        Equals(Book.PageCount(), pageNumber);
        Equals(Book.CurrentPage(), index);


    }
}

public class UnitTest2
{
    [Fact]
    public void Test2()
    {
        // Arrange
        List<string> page = new List<string>() { };
        int pageNumber = 1;
        int index = 0;



        // Act
        var Book = new PageableCollection<string>(page);
        Book.PageCount();
        Book.CurrentPage();


        // Assert
        Equals(Book.PageCount(), pageNumber);
        Equals(Book.CurrentPage(), index);

    }
}