using System;

public class StartGame
{
    private Hero hero;
    private Enemy enemy;
    private string playerQuery;
    private int iventId;
    private Random random = new Random();
    private string playerName;

    private delegate void playerChoose(string text);


    public StartGame()
	{

	}

    public void InitializationGame()
    {
        hero = new Hero(100, 5, 5, 10);
        WriteConsole("Введите ваше имя");
        playerName = Console.ReadLine();
        WriteConsole("Ваше здоровье " + hero.GetHealth(0) + " Ваш урон " + hero.GetDamage(0) + " Ваша ловкость " + hero.GetAgility(0) + " Ваша сила " + hero.GetDamage(0));
        WriteConsole("Напишите Help для просмотра доступных команд.");
        PlayerWrite();
    }

    public void PlayerWrite() 
    {
        while (true)
        {
            Console.Write(playerName + ": ");
            playerQuery = Console.ReadLine();

            switch (playerQuery)
            {
                case "Help":
                    WriteHelp();
                    break;
                case "Stats":
                    WriteStats();
                    break;               
                case "Go":
                    if(iventId == 0)
                        Ivent();
                    break;
                case "Run":
                    PlayerAction("Run");
                    break;               
                case "Atack":
                    PlayerAction("Atack");
                    break;
            }
        }
    }

    public void WriteStats() 
    {
        WriteConsole("Ваше здоровье " + hero.GetHealth(0) + " Ваш урон " + hero.GetDamage(0) + " Ваша ловкость " + hero.GetAgility(0) + " Ваша сила " + hero.GetDamage(0));
    }
    public void WriteHelp() 
    {
        if (iventId != 0)
            WriteConsole("Run" + " Atack");
        else 
            WriteConsole("Go" + " Stats");
    }
    public void Ivent() 
    {
        iventId = random.Next(1, 2);
        switch (iventId) 
        {
            case 1:
                AtackEnemy();
                break;           
        }

    }

    public string ReadConsole(string _text) 
    {
        Console.Write(playerName);
        return Console.ReadLine();
        
    }
    public void WriteConsole(string _text) 
    {
        Console.WriteLine(_text);
    }
    public void AtackEnemy() 
    {
        var enemyID = 0;
        enemyID = random.Next(0, 3);

        switch (enemyID) 
        {
            case 0:
                enemy = new Zombie("Зомби",20, 10, 5);
                break;         
            case 1:
                enemy = new Skelet("Скелет", 10, 5, 1);
                break;         
            case 2:
                enemy = new Rat("Крыса",5, 5, 40);
                break;         
        }

        WriteConsole("На вас напал " + enemy.GetName(""));
    }
    public void PlayerAction(string _text)
    {
        if (iventId == 1) 
        {
            switch (_text) 
            {
                case "Run":
                    string choice = "";
                    WriteConsole("Ваш шанс убежать " + hero.GetAgility(0) * 2 + "%");
                    WriteConsole("Вы хотите убежать? (Yes/No)");
                    Console.Write(playerName + ": ");
                    choice = Console.ReadLine();
                    if (choice == "Yes") 
                    {
                        if (Doodge(hero.GetAgility(0) * 2))
                        {
                            WriteConsole("Вы убежали.");
                            hero.SetAgility(hero.GetAgility(0) + 1);
                            WriteConsole("Ловкость повышена.");
                            iventId = 0;
                        }
                        else 
                        {
                            enemy.Atack(hero);
                            WriteConsole("Получен урон " + enemy.GetDamage(0));
                        }
                    }
                    break;
                case "Atack":
                    if (Doodge(enemy.GetAgility(0)))
                    {
                        WriteConsole(enemy.GetName("") + " увернулся");
                        WriteConsole(enemy.GetName("") + " атакует.");
                        if (Doodge(hero.GetAgility(0)))
                        {
                            enemy.Atack(hero);
                            WriteConsole("Получен урон " + enemy.GetDamage(0));
                        }
                        else
                        {
                            WriteConsole("Вы уклонились.");
                            hero.SetAgility(hero.GetAgility(0) + 1);
                            WriteConsole("Ловкость повышена.");
                        }
                    }
                    else 
                    {
                        enemy.SetHealth(enemy.GetHealth(0) - hero.GetDamage(0));
                        WriteConsole("Вы нанесли " + enemy.GetDamage(0) + " урона.");
                        if (enemy.GetHealth(0) <= 0) 
                        {
                            WriteConsole("Вы победили.");
                            iventId = 0;
                        }
                    }
                    break;
            }
        } 
    }
    public bool Doodge(float b) 
    {
        var сhance = random.Next(0, 101);
        return сhance < b;
    }



}
