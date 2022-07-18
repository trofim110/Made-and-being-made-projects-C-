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
public class UnitTest3
{
    [Fact]

    public class webpage
    {
        public int Column1 { get; set; }
        public int Column2 { get; set; }
        public int Column3 { get; set; }

        public webpage(){}
        public webpage(int column1, int column2, int column3)
        {
            Column1 = column1;
            Column2 = column2;
            Column3 = column3;
        }

    }
    public void Test3()
    {
        // Arrange
        var page = new List<webpage>()
        {
            new webpage() {Column1 = 1,Column2 = 2,Column3 = 3},
            new webpage() {Column1 = 1,Column2 = 2,Column3 = 3},
            new webpage() {Column1 = 1,Column2 = 2,Column3 = 3},
            new webpage() {Column1 = 1,Column2 = 2,Column3 = 3}
        };



        // Act



        // Assert


    }
}