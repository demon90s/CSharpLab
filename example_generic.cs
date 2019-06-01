using System;

public class SomeClass
{
    public T GenericMedhod<T>(T param) {
        return param;
    }
}

// Generic Class
public class GenericClass<T>
{
    T item;

    public GenericClass(T _item) {
        item = _item;
    }

    public void UpdateItem(T newItem) {
        item = newItem;
    }

    public T GetItem() {
        return item;
    }
}

public class MainEntry {
    static void Main(string[] args) {
        SomeClass some_class = new SomeClass();
        int v = some_class.GenericMedhod<int>(42);
        Console.WriteLine(v);

        GenericClass<int> generic_class = new GenericClass<int>(42);
        int item = generic_class.GetItem();
        Console.WriteLine(item);
        generic_class.UpdateItem(100);
        item = generic_class.GetItem();
        Console.WriteLine(item);
    }
}