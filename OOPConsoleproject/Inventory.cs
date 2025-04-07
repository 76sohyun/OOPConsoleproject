using OOPConsoleproject.GameObjects;

namespace OOPConsoleproject;

public class Inventory
{
    private List<Item> items;

    public Inventory()
    {
        items = new List<Item>();
    }
    public void Add(Item item)
    {
        items.Add(item);
    }

    public void Remove(Item item)
    {
        items.Remove(item);
    }

    public void RemoveAt(int index)
    {
        items.RemoveAt(index);
    }

    public void UseItem(int index)
    {
        items[index].Use();
    }

    public void PrintAll()
    {
        Console.WriteLine(("==소유한 아이템====="));
        if (items.Count == 0)
        {
            Console.WriteLine("없음");
        }
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine("{0}. {1}", i+1, items[i].name);
        }
        Console.WriteLine("==================");
    }
}

