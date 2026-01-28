// Declare the generic class.
public class GenericList<T>
{
    public void Add(T item) { }
}

public class ExampleClass { }

public class TestGenericList
{
    // Create a list of type int.
   public static GenericList<int> AddInt(int value)
    {
        GenericList<int> list1 = new();
        list1.Add(value);
        Console.WriteLine("test", list1);
        return list1;
    }

    // Create a list of type string.
    public static GenericList<string> AddStr(string value)
    {
        GenericList<string> list2 = new();
        list2.Add(value);
        return list2;
    }

    // Create a list of type ExampleClass.
    public static GenericList<ExampleClass> AddType()
    {
        GenericList<ExampleClass> list3 = new();
        list3.Add(new ExampleClass());
        return list3;
    }
}
