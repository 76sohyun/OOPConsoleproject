﻿namespace OOPConsoleproject.Scenes;

public class TitleScene : BaseScene
{
    public TitleScene()
    {
        name = "Title";
    }
    public override void Render()
    {
        Console.WriteLine("*****************************");
        Console.WriteLine("*         레전드RPG         *");
        Console.WriteLine("*****************************");
        Console.WriteLine();
        Console.WriteLine("계속하려면 아무키나 누르세요...");
    }

    public override void Input()
    {
        Console.ReadKey(true);
    }

    public override void Update()
    {
       
    }

    public override void Result()
    {
        Game.ChangeScene("Town");
    }
}