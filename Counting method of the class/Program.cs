public class Cycler <T>
{
    private List<T> array;
    private static int _index = -1;

    public int Index
    {
        get {  return _index;  }

        set
        {_index = value;
            if (value >= array.Count)
                _index = 0;
        }
    }

    public Cycler(List<T> array)
    {
        this.array = array;
    }

    public T GetNext()
    {
        Index++;
        return array[Index];
    }
}
class  sss
{
    static void Main()
    {

    }
}