using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Sdk;

namespace Page_implementation_classTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        List<string> page = new List<string>() { "223", "334", "3244" };
        int CountPage = 3;
        int Page = 2;



        // Act
        var Book = new PageableCollection<string>(page);
        Book.PageCount();
        Book.CurrentPageNumber();


        // Assert
        Equals(Book.PageCount(),  CountPage );
        Equals(Book.CurrentPageNumber(), Page);


    }
}

public class UnitTest2
{
    [Fact]
    public void Test2()
    {
        // Arrange
        List<string> page = new List<string>() {null,null,null };




        // Act
        var Book = new PageableCollection<string>(page);
        Book.CurrentPageNumber();




    }
}
