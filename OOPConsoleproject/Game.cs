﻿using System.Security.AccessControl;
using OOPConsoleproject.Scenes;

namespace OOPConsoleproject;

public static class Game
{
    
    private static Dictionary<string, BaseScene> sceneDic;
    private static BaseScene curScene;
    public static string prevSceneName;
    
    
    private static Player player;
    public static Player Player{ get { return player; } }

    private static bool gameOver;
    public static void Run()
    {
        Start();
        while (gameOver==false)
        {
            Console.Clear();
            Console.WriteLine();
            curScene.Render();
            Console.WriteLine();
            curScene.Input();
            Console.WriteLine();
            curScene.Update();
            Console.WriteLine();
            curScene.Result();
        }
        End();
    }

    public static void ChangeScene(string sceneName)
    {
        prevSceneName = curScene.name;
        curScene.Exit();
        curScene = sceneDic[sceneName];
        curScene.Enter();
        
    }
    
    /// <summary>
    /// 게임의 초기 진행
    /// </summary>
    private static void Start()
    {
        Console.CursorVisible = false;
        //게임 설정
        gameOver = false;
        //플레이어 설정
        player = new Player();
        //씬 설정
        sceneDic = new Dictionary<string, BaseScene>();
        sceneDic.Add("Title", new TitleScene());
        sceneDic.Add("Town", new TownScene());
        sceneDic.Add("NormalField", new NormalFieldScene());
        sceneDic.Add("ForestField", new ForestFieldScene());
        
        curScene = sceneDic["Title"];
        
        
    }
    
    /// <summary>
    /// 게임의 마무리 작업 진행
    /// </summary>
    private static void End()
    {
        
    }
}