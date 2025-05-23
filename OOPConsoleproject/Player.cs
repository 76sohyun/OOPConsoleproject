﻿namespace OOPConsoleproject;

public class Player
{
    public Vector2 position;
    public Inventory inventory;
    public bool[,] map;

    private int curHp;
    public int CurHP {get { return curHp; } }
    private int maxHp;
    public int MaxHP {get { return maxHp; } }

    public Player()
    {
        inventory = new Inventory();
        maxHp = 100;
        curHp = maxHp;
    }

    public void Heal(int amount)
    {
        curHp += amount;
        if (curHp > maxHp)
        {
            curHp = maxHp;
        }
    }

    public void Print()
    {
        Console.SetCursorPosition(position.x, position.y);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("P");
        Console.ResetColor();
    }

    public void Move(ConsoleKey input)
    {
        Vector2 targetPos = position;
        
        switch (input)
        {
            case ConsoleKey.UpArrow:
                targetPos.y--;
                break;
            case ConsoleKey.DownArrow:
                targetPos.y++;
                break;
            case ConsoleKey.LeftArrow:
                targetPos.x--;
                break;
            case ConsoleKey.RightArrow:
                targetPos.x++;
                break;
        }

        if (map[targetPos.y, targetPos.x] == true)
        {
            position = targetPos;
        }
    }
}