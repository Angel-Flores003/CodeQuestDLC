using System;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string User = "===== Welcome, {0} the {1} with level {2} =====";
        const string Train = "1. Train your wizard ";
        const string Increase = "2. Increase LVL ";
        const string Loot = "3. Loot the mine ";
        const string ShowIn = "4. Show inventory ";
        const string Buy = "5. Buy items ";
        const string ShowAtk = "6. Show attacks by LVL ";
        const string Decode = "7. Decode ancient Scroll ";
        const string Exit = "0. Exit game";
        const string Option = "Choose an option (1-7) - (0) exit: ";
        const string Update = "(Update)";
        const string New = "(New!)";
        const string Error = "Invalid input. Please enter a number between 0 and 7.";
        const int MaxDay = 5;
        //op1 const
        const string DayTrain = "Day {0}: {1} has trained for a total of {2} hours and gained {3} power points.";
        const string InputName = "Enter your wizard's name: ";
        const string MsgFail = "Repeteixes a 2a convocatòria.";
        const string RangFail = "Raoden el Elantrí";
        const string MsgOk = "Encara confons la vareta amb una cullera.";
        const string RangOk = "Raoden el Elantrí";
        const string MsgGood = "Ets un Invocador de Brises Màgiques.";
        const string RangGood = "Raoden el Elantrí";
        const string MsgAwsome = "Uau! Pots invocar dracs sense cremar el laboratori!";
        const string RangAwsome = "Elarion de les Brases";
        const string MsgGod = "Has assolit el rang de Mestre dels Arcans!";
        const string RangGod = "ITB-Wizard el Gris";
        const string ComplTrain = "Training complete! {0} has achieved a total power of {1} points and earned the title {2}.";
        //op2 const
        const string Die1Face = "You rolled a 1!\n" +
                                "                     ________\n" +
                                "                    /       /|\n" +
                                "                   /_______/ |\n" +
                                "                   |       | |\n" +
                                "                   |   o   | /\n" +
                                "                   |       |/ \n" +
                                "                   '-------'\n" +
                                "The monster takes damage!";
        const string Die2Face = "You rolled a 2!\n" +
                                "                     ________\n" +
                                "                    /       /|\n" +
                                "                   /_______/ |\n" +
                                "                   | o     | |\n" +
                                "                   |       | /\n" +
                                "                   |     o |/ \n" +
                                "                   '-------'\n" +
                                "The monster takes damage!";
        const string Die3Face = "You rolled a 3!\n" +
                                "                     ________\n" +
                                "                    /       /|\n" +
                                "                   /_______/ |\n" +
                                "                   |     o | |\n" +
                                "                   |   o   | /\n" +
                                "                   | o     |/ \n" +
                                "                   '-------'\n" +
                                "The monster takes damage!";
        const string Die4Face = "You rolled a 4!\n" +
                                "                     ________\n" +
                                "                    /       /|\n" +
                                "                   /_______/ |\n" +
                                "                   | o   o | |\n" +
                                "                   |       | /\n" +
                                "                   | o   o |/ \n" +
                                "                   '-------'\n" +
                                "The monster takes damage!";
        const string Die5Face = "You rolled a 5!\n" +
                                "                     ________\n" +
                                "                    /       /|\n" +
                                "                   /_______/ |\n" +
                                "                   | o   o | |\n" +
                                "                   |   o   | /\n" +
                                "                   | o   o |/ \n" +
                                "                   '-------'\n" +
                                "The monster takes damage!";
        const string Die6Face = "You rolled a 6!\n" +
                                "                     ________\n" +
                                "                    /       /|\n" +
                                "                   /_______/ |\n" +
                                "                   | o   o | |\n" +
                                "                   | o   o | /\n" +
                                "                   | o   o |/ \n" +
                                "                   '-------'\n" +
                                "The monster takes damage!";
        const string Figth = "A wild {0} appears! Rolling dice to determine the outcome of the battle...";
        const string Heal = "The {0} has {1} HP.";
        const string Key = "Press any key to roll the dice again...";
        const string Defeat = "The {0} has been defeated!";
        const string LevlUp = "{0} levels up!";
        const string LvlMax = "You already have the max level";        
        //op1 var
        Random rand = new Random();
        int power = 0, hours = 0, op = -1, lvl = 1;
        string user = "", title = "";
        //op2 var
        int monster, dice;
        int[] life = { 3, 5, 10, 11, 18, 15, 20, 50 };
        string[] monsters = { "Wandering Skeleton 💀",
            "Forest Goblin 👹",
            "Green Slime 🦠",
            "Ember Wolf 🐺",
            "Giant Spider 🕷️",
            "Iron Golem 🤖",
            "Lost Necromancer 🧝‍♂️",
            "Ancient Dragon 🐉"};        
        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(MenuTitle);
            if (user.Equals(title))
            {
                Console.WriteLine("");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(User, user, title, lvl);                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Train);            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Increase);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Update);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Loot);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(New);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ShowIn);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(New);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Buy);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(New);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ShowAtk);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(New);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Decode);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(New);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Exit);
            Console.Write(Option);
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                op = Int32.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:                        
                        Console.Write(InputName);
                        user = Console.ReadLine();
                        user = char.ToUpper(user[0]) + user.Substring(1).ToLower();//convierte la primnera en mayus y el resto en minus
                        power = 0;
                        for (int i = 1; i < MaxDay + 1; i++)
                        {
                            hours += rand.Next(1, 25);
                            power += rand.Next(1, 11);
                            Console.WriteLine(DayTrain, i, user, hours, power);
                            Thread.Sleep(1000);
                        }
                        if (power < 20)
                        {
                            Console.WriteLine(MsgFail);
                            title.Equals(RangFail);                            
                            
                        }
                        else if (power >= 20 && power < 30)
                        {
                            Console.WriteLine(MsgOk);
                            title = RangOk;                                                        
                        }
                        else if (power >= 30 && power < 35)
                        {
                            Console.WriteLine(MsgGood);                            
                            title = RangGood;
                        }
                        else if (power >= 35 && power < 40)
                        {
                            Console.WriteLine(MsgAwsome);                            
                            title = RangAwsome;
                        }
                        else
                        {
                            Console.WriteLine(MsgGod);                            
                            title = RangGod;
                        }
                        Console.WriteLine(ComplTrain, user, power, title);                        
                    break;
                    case 2:
                        monster = rand.Next(0, 8);
                        switch (monster)
                        {
                            case 0:
                                Console.WriteLine(Figth, monsters[0]);
                                Console.WriteLine(Heal, monsters[0], life[0]);
                                do
                                {                                    
                                    dice = rand.Next(1, 7);
                                    switch (dice)
                                    {
                                        case 1:
                                            Console.WriteLine(Die1Face);
                                            life[0] -= 1;
                                        break;
                                        case 2:
                                            Console.WriteLine(Die2Face);
                                            life[0] -= 2;
                                        break;
                                        case 3:
                                            Console.WriteLine(Die3Face);
                                            life[0] -= 3;
                                        break;
                                        case 4:
                                            Console.WriteLine(Die4Face);
                                            life[0] -= 4;
                                        break;
                                        case 5:
                                            Console.WriteLine(Die5Face);
                                            life[0] -= 5;
                                        break;
                                        case 6:
                                            Console.WriteLine(Die6Face);
                                            life[0] -= 6;
                                        break;
                                    }
                                    if (life[0] > 0)
                                    {
                                        Console.WriteLine(Heal, monsters[0], life[0]);
                                        Console.WriteLine(Key);
                                    }
                                    else
                                    {
                                        Console.WriteLine(Heal, monsters[0], 0);
                                        Console.WriteLine("");
                                    }
                                    Console.ReadKey();
                                } while (life[0] > 0);
                                Console.WriteLine(Defeat, monsters[0]);
                                life[0] = 3;
                            break;
                            case 1:
                                Console.WriteLine(Figth, monsters[1]);
                                Console.WriteLine(Heal, monsters[1], life[1]);
                                do
                                {
                                    dice = rand.Next(1, 7);
                                    switch (dice)
                                    {
                                        case 1:
                                            Console.WriteLine(Die1Face);
                                            life[1] -= 1;
                                            break;
                                        case 2:
                                            Console.WriteLine(Die2Face);
                                            life[1] -= 2;
                                            break;
                                        case 3:
                                            Console.WriteLine(Die3Face);
                                            life[1] -= 3;
                                            break;
                                        case 4:
                                            Console.WriteLine(Die4Face);
                                            life[1] -= 4;
                                            break;
                                        case 5:
                                            Console.WriteLine(Die5Face);
                                            life[1] -= 5;
                                            break;
                                        case 6:
                                            Console.WriteLine(Die6Face);
                                            life[1] -= 6;
                                            break;
                                    }
                                    if (life[1] > 0)
                                    {
                                        Console.WriteLine(Heal, monsters[1], life[1]);
                                        Console.WriteLine(Key);
                                    }
                                    else
                                    {
                                        Console.WriteLine(Heal, monsters[1], 0);
                                        Console.WriteLine("");
                                    }
                                    Console.ReadKey();
                                } while (life[1] > 0);
                                Console.WriteLine(Defeat, monsters[1]);
                                life[1] = 5;
                            break;
                            case 2:
                                Console.WriteLine(Figth, monsters[2]);
                                Console.WriteLine(Heal, monsters[2], life[2]);
                                do
                                {
                                    dice = rand.Next(1, 7);                                    
                                    switch (dice)
                                    {
                                        case 1:
                                            Console.WriteLine(Die1Face);
                                            life[2] -= 1;
                                            break;
                                        case 2:
                                            Console.WriteLine(Die2Face);
                                            life[2] -= 2;
                                            break;
                                        case 3:
                                            Console.WriteLine(Die3Face);
                                            life[2] -= 3;
                                            break;
                                        case 4:
                                            Console.WriteLine(Die4Face);
                                            life[2] -= 4;
                                            break;
                                        case 5:
                                            Console.WriteLine(Die5Face);
                                            life[2] -= 5;
                                            break;
                                        case 6:
                                            Console.WriteLine(Die6Face);
                                            life[2] -= 6;
                                            break;
                                    }
                                    if (life[2] > 0)
                                    {
                                        Console.WriteLine(Heal, monsters[2], life[2]);
                                        Console.WriteLine(Key);
                                    }
                                    else
                                    {
                                        Console.WriteLine(Heal, monsters[2], 0);
                                        Console.WriteLine("");
                                    }                                    
                                    Console.ReadKey();
                                } while (life[2] > 0);
                                Console.WriteLine(Defeat, monsters[2]);
                                life[2] = 10;
                            break;
                            case 3:
                                Console.WriteLine(Figth, monsters[3]);
                                Console.WriteLine(Heal, monsters[3], life[3]);
                                do
                                {
                                    dice = rand.Next(1, 7);                                    
                                    switch (dice)
                                    {
                                        case 1:
                                            Console.WriteLine(Die1Face);
                                            life[3] -= 1;
                                            break;
                                        case 2:
                                            Console.WriteLine(Die2Face);
                                            life[3] -= 2;
                                            break;
                                        case 3:
                                            Console.WriteLine(Die3Face);
                                            life[3] -= 3;
                                            break;
                                        case 4:
                                            Console.WriteLine(Die4Face);
                                            life[3] -= 4;
                                            break;
                                        case 5:
                                            Console.WriteLine(Die5Face);
                                            life[3] -= 5;
                                            break;
                                        case 6:
                                            Console.WriteLine(Die6Face);
                                            life[3] -= 6;
                                            break;
                                    }
                                    if (life[3] > 0)
                                    {
                                        Console.WriteLine(Heal, monsters[3], life[3]);
                                        Console.WriteLine(Key);
                                    }
                                    else
                                    {
                                        Console.WriteLine(Heal, monsters[3], 0);
                                        Console.WriteLine("");
                                    }
                                    Console.ReadKey();
                                } while (life[3] > 0);
                                Console.WriteLine(Defeat, monsters[3]);
                                life[3] = 11;
                            break;
                            case 4:
                                Console.WriteLine(Figth, monsters[4]);
                                Console.WriteLine(Heal, monsters[4], life[4]);
                                do
                                {
                                    dice = rand.Next(1, 7);                                    
                                    switch (dice)
                                    {
                                        case 1:
                                            Console.WriteLine(Die1Face);
                                            life[4] -= 1;
                                            break;
                                        case 2:
                                            Console.WriteLine(Die2Face);
                                            life[4] -= 2;
                                            break;
                                        case 3:
                                            Console.WriteLine(Die3Face);
                                            life[4] -= 3;
                                            break;
                                        case 4:
                                            Console.WriteLine(Die4Face);
                                            life[4] -= 4;
                                            break;
                                        case 5:
                                            Console.WriteLine(Die5Face);
                                            life[4] -= 5;
                                            break;
                                        case 6:
                                            Console.WriteLine(Die6Face);
                                            life[4] -= 6;
                                            break;
                                    }
                                    if (life[4] > 0)
                                    {
                                        Console.WriteLine(Heal, monsters[4], life[4]);
                                        Console.WriteLine(Key);
                                    }
                                    else
                                    {
                                        Console.WriteLine(Heal, monsters[4], 0);
                                        Console.WriteLine("");
                                    }
                                    Console.ReadKey();
                                } while (life[4] > 0);
                                Console.WriteLine(Defeat, monsters[4]);
                                life[4] = 18;
                            break;
                            case 5:
                                Console.WriteLine(Figth, monsters[5]);
                                Console.WriteLine(Heal, monsters[5], life[5]);
                                do
                                {
                                    dice = rand.Next(1, 7);                                    
                                    switch (dice)
                                    {
                                        case 1:
                                            Console.WriteLine(Die1Face);
                                            life[5] -= 1;
                                            break;
                                        case 2:
                                            Console.WriteLine(Die2Face);
                                            life[5] -= 2;
                                            break;
                                        case 3:
                                            Console.WriteLine(Die3Face);
                                            life[5] -= 3;
                                            break;
                                        case 4:
                                            Console.WriteLine(Die4Face);
                                            life[5] -= 4;
                                            break;
                                        case 5:
                                            Console.WriteLine(Die5Face);
                                            life[5] -= 5;
                                            break;
                                        case 6:
                                            Console.WriteLine(Die6Face);
                                            life[5] -= 6;
                                        break;
                                    }
                                    if (life[5] > 0)
                                    {
                                        Console.WriteLine(Heal, monsters[5], life[5]);
                                        Console.WriteLine(Key);
                                    }
                                    else
                                    {
                                        Console.WriteLine(Heal, monsters[5], 0);
                                        Console.WriteLine("");
                                    }
                                    Console.ReadKey();
                                } while (life[5] > 0);
                                Console.WriteLine(Defeat, monsters[5]);
                                life[5] = 15;
                            break;
                            case 6:
                                Console.WriteLine(Figth, monsters[6]);
                                Console.WriteLine(Heal, monsters[6], life[6]);
                                do
                                {
                                    dice = rand.Next(1, 7);                                    
                                    switch (dice)
                                    {
                                        case 1:
                                            Console.WriteLine(Die1Face);
                                            life[6] -= 1;
                                            break;
                                        case 2:
                                            Console.WriteLine(Die2Face);
                                            life[6] -= 2;
                                            break;
                                        case 3:
                                            Console.WriteLine(Die3Face);
                                            life[6] -= 3;
                                            break;
                                        case 4:
                                            Console.WriteLine(Die4Face);
                                            life[6] -= 4;
                                            break;
                                        case 5:
                                            Console.WriteLine(Die5Face);
                                            life[6] -= 5;
                                            break;
                                        case 6:
                                            Console.WriteLine(Die6Face);
                                            life[6] -= 6;
                                            break;
                                    }
                                    if (life[6] > 0)
                                    {
                                        Console.WriteLine(Heal, monsters[6], life[6]);
                                        Console.WriteLine(Key);
                                    }
                                    else
                                    {
                                        Console.WriteLine(Heal, monsters[6], 0);
                                        Console.WriteLine("");
                                    }
                                    Console.ReadKey();
                                } while (life[6] > 0);
                                Console.WriteLine(Defeat, monsters[6]);
                                life[6] = 20;
                            break;
                            case 7:
                                Console.WriteLine(Figth, monsters[7]);
                                Console.WriteLine(Heal, monsters[7], life[7]);
                                do
                                {
                                    dice = rand.Next(1, 7);                                    
                                    switch (dice)
                                    {
                                        case 1:
                                            Console.WriteLine(Die1Face);
                                            life[7] -= 1;
                                            break;
                                        case 2:
                                            Console.WriteLine(Die2Face);
                                            life[7] -= 2;
                                            break;
                                        case 3:
                                            Console.WriteLine(Die3Face);
                                            life[7] -= 3;
                                            break;
                                        case 4:
                                            Console.WriteLine(Die4Face);
                                            life[7] -= 4;
                                            break;
                                        case 5:
                                            Console.WriteLine(Die5Face);
                                            life[7] -= 5;
                                            break;
                                        case 6:
                                            Console.WriteLine(Die6Face);
                                            life[7] -= 6;
                                            break;
                                    }
                                    if (life[7] > 0)
                                    {
                                        Console.WriteLine(Heal, monsters[7], life[7]);
                                        Console.WriteLine(Key);
                                    }
                                    else
                                    {
                                        Console.WriteLine(Heal, monsters[7], 0);
                                        Console.WriteLine("");
                                    }
                                    Console.ReadKey();
                                } while (life[7] > 0);
                                Console.WriteLine(Defeat, monsters[7]);
                                life[7] = 50;
                            break;
                        }
                        if (lvl < 5)
                        {
                            Console.WriteLine(LevlUp, user);
                            lvl++;
                        }
                        else
                        {
                            Console.WriteLine(LvlMax);
                        }                        
                    break;                    
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        } while (op != 0);        
    }
}
