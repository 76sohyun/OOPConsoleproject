namespace OOPConsoleproject.Scenes;

public class TestScene01 : BaseScene
{
    private ConsoleKey input;
    public override void Render()
    {
        Console.WriteLine("테스트01씬입니다.");
        Console.WriteLine("1. 테스트 02씬으로이동");
        Console.WriteLine("2.테스트 03으로 이동");
    }

    public override void Input()
    {
        input = Console.ReadKey(true).Key;
    }

    public override void Update()
    {
        
    }

    public override void Result()
    {
        switch (input)
        {
            case ConsoleKey.D1:
                Game.ChangeScene("Test02");
                break;
            case ConsoleKey.D2:
                Game.ChangeScene("Test03");
                break;
        }
    }
}