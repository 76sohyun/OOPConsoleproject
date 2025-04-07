namespace OOPConsoleproject.GameObjects;

public abstract class Item : GameObject
{
    public string name;
    public string description;
    
    public Item(char symbol, Vector2 position) : base(ConsoleColor.Yellow, symbol, position, true)
    {
        
    }

    public override void Interact(Player player)
    {
        //플레이어가 습득한다.
        player.inventory.Add(this);
    }

    public abstract void Use();
}