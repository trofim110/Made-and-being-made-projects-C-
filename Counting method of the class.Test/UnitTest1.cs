using System.Collections.Generic;
using Xunit;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var list = new List<int>() { 1, 2, 3 };
        var list1 = 1;
        var list2 = 2;
        var list3 = 3;

        // Act

        var value = new Cycler<int>(list);
        value.GetNext();

        // Assert
        Equals(value.GetNext(), list1);
        Equals(value.GetNext(), list2);
        Equals(value.GetNext(), list3);
        Equals(value.GetNext(), list1);

    }

}

public class UnitTest2
{
    [Fact]
    public void Test2()
    {
        // Arrange
        var word = new List<string>() { "qq", "ww", "ee" };
        var word1 = "qq";
        var word2 = "ww";
        var word3 = "ee";

        // Act

        var Word = new Cycler<string>(word);
        Word.GetNext();

        // Assert
        Equals(Word.GetNext(), word1);
        Equals(Word.GetNext(), word2);
        Equals(Word.GetNext(), word3);
        Equals(Word.GetNext(), word1);

    }
}

public class UnitTest3
{
    [Fact]
    public void Test3()
    {
        // Arrange
        var list = new List<char>() { 's', 'f', 'g' };
        var list1 = 's';
        var list2 = 'f';
        var list3 = 'g';

        // Act
        var letter = new Cycler<char>(list);
        letter.GetNext();

        // Assert
        Equals(letter.GetNext(), list1);
        Equals(letter.GetNext(), list2);
        Equals(letter.GetNext(), list3);
        Equals(letter.GetNext(), list1);

    }
}