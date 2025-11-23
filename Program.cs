using Microsoft.Win32.SafeHandles;

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
        //op3 const
        const int MaxAtt = 5;
        const string Empty = "➖";
        const string Coin = "\U0001fa99";
        const string Fail = "❌";
        const string Attempts = "You have 5 attempts to mine for bits.";
        const string Column = "  0 1 2 3 4";
        const string InsertX = "Insert the x axis:";
        const string InsertY = "Insert the y axis:";
        const string InvaliVal = "Invalid axis. Please enter a value between 0 and 4";
        const string Mine = "You mine at position [{0}][{1}] and you get ";
        const string Bits = "{0} bits";
        const string FailMine = "You mine at position [{0}][{1}] but found nothing.";
        //op4 const
        const string EmptyInv = "Your inventory is empty.";
        const string Inventory = "Your inventory contains:";
        //op5 const
        const string ByuItems = "You chose to buy items\n" +
            "You have {0} bits available.\n" +
            "Items available for purchase:";        
        const string OpStore = "Select the item you wish to buy (1 - 5) (0 to exit):";
        const string ZeroExit = "0 - Exit";
        const string Bought = "You have purchased: {0} for {1} bits. Bits remaining: {2}";
        const string NoMoney = "You do not have enough bits to purchase this item.";
        //op6 const 
        const string NewPowers = "Keep training to unlock new powers!";
        const string AtkFor = "Available attacks for level {0}:";
        const string AllPowers = "You already know all powers, congratulations ⭐";
        //op7 const
        const string EncripMsg = "You found an ancient scroll with encrypted messages!\n";
        const string Scrool = "Scroll to decode:";
        const string SecretCodeMenu = "  1. \"The 🐲 sleeps in the mountain of fire 🔥\"\n" +
            "  2. \"Ancient magic flows through the crystal caves\"\n" +
            "  3. \"Spell: Ignis 5 🔥, Aqua 6 💧, Terra 3 🌍, Ventus 8 🌪️\"\n\n" +
            "You must decode the following scroll:\n" +
            "Choose a decoding operation:\n" +
            "1. Decipher spell (remove spaces)\n" +
            "2. Count magical runes (vowels)\n" +
            "3. Extract secret code (numbers)";
        const string DecipheSpell = "Deciphered Spell: ";
        const string DragonSleep = "The 🐲 sleeps in the mountain of fire 🔥";        
        const string MagicVowel = "{0} magical runes (vowels) found";
        const string MagiCave = "Ancient magic flows through the crystal caves";
        const string Scan = "Scanning: ...";
        const string DecodeNumber = "🔮 Decoded number: ";
        const string Spell = "Spell: Ignis 5 🔥, Aqua 6 💧, Terra 3 🌍, Ventus 8 🌪️";
        const string Error2 = "Invalid input. Please enter a number between 0 and 3.";
        const string ThreeOfThree = "Congratulations! You have successfully decoded all parts of the scroll.";
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
        //op3 var
        int coin = 0, count = 0, valX = 5, valY = 5, money = 0;
        string[,] map0 = new string[5, 5];
        string[,] mapDig = new string[5, 5];
        //op4 var        
        string[] inventory = { "" };
        string[] tempInven = { "" };
        //op5 var
        int opStore = -1;
        int[] price = { 30, 10, 50, 40, 20 };
        string[] store = { "Iron Dagger 🗡️",
            "Healing Potion ⚗️",
            "Ancient Key 🗝️",
            "Crossbow 🏹",
            "Metal Shield 🛡️"};
        //op6 var
        string[] level1 = { "Magic Spark 💫" };
        string[] level2 = { "Fireball 🔥", "Ice Ray 🥏", "Arcane Shield ⚕️" };
        string[] level3 = { "Meteor ☄️", "Pure Energy Explosion 💥", "Minor Charm 🎭", "Air Strike 🍃" };
        string[] level4 = { "Wave of Light ⚜️", "Storm of Wings 🐦" };
        string[] level5 = { "Cataclysm 🌋", "Portal of Chaos 🌀", "Arcane Blood Pact 🩸", "Elemental Storm ⛈️" };
        //op7 var
        int msgOp, vowelCount = 0;
        bool codeMsg1 = false, codeMsg2 = false, codeMsg3 = false;
        string noSpaces = "";
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
                    case 3:
                        for (int i = 0; i < mapDig.GetLength(0); i++)
                        {
                            for (int j = 0; j < mapDig.GetLength(1); j++)
                            {
                                coin = rand.Next(0, 101);
                                if (coin <= 35)
                                {
                                    mapDig[i, j] = Coin;
                                    //Console.Write(mapDig[i, j]); hacks
                                }
                                else
                                {
                                    mapDig[i, j] = Fail;
                                    //Console.Write(mapDig[i, j]); hacks
                                }
                            }
                            //Console.WriteLine(""); hacks
                        }
                        //Console.WriteLine(""); hacks
                        for (int i = 0; i < map0.GetLength(0); i++)
                        {
                            for (int j = 0; j < map0.GetLength(1); j++)
                            {
                                map0[i, j] = Empty;                                
                            }                            
                        }                        
                        Console.WriteLine(Attempts);
                        do
                        {
                            Console.WriteLine(Column);
                            for (int i = 0; i < map0.GetLength(0); i++)
                            {
                                Console.Write(i);
                                for (int j = 0; j < map0.GetLength(1); j++)
                                {                                    
                                    Console.Write(map0[i, j]);
                                }
                                Console.WriteLine("");
                            }
                            do
                            {
                                try
                                {
                                    Console.WriteLine(InsertX);
                                    valX = Int32.Parse(Console.ReadLine());
                                    if (valX < 0 || valX > 4)
                                    {
                                        Console.WriteLine(InvaliVal);
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine(Error);
                                }
                            } while (valX < 0 || valX > 4);
                            do
                            {
                                try
                                {
                                    Console.WriteLine(InsertY);
                                    valY = Int32.Parse(Console.ReadLine());
                                    if (valY < 0 || valY > 4)
                                    {
                                        Console.WriteLine(InvaliVal);
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine(Error);
                                }
                            } while (valY < 0 || valY > 4);
                            if (mapDig[valX, valY].Contains(Coin))
                            {
                                coin = rand.Next(5, 51);
                                map0[valX, valY] = Coin;
                                mapDig[valX, valY] = Fail;
                                Console.Write(Mine, valX, valY);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(Bits, coin);
                                Console.ForegroundColor = ConsoleColor.White;
                                money += coin;
                            }
                            else
                            {
                                map0[valX, valY] = Fail;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(FailMine, valX, valY);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            count++;
                        } while (count < MaxAtt);
                        count = 0;
                        Console.WriteLine(Column);
                        for (int i = 0; i < map0.GetLength(0); i++)
                        {
                            Console.Write(i);
                            for (int j = 0; j < map0.GetLength(1); j++)
                            {
                                Console.Write(map0[i, j]);
                            }
                            Console.WriteLine("");
                        }
                    break;
                    
                    case 4:
                        if (inventory[0].Equals(""))
                        {
                            Console.WriteLine(EmptyInv);
                        }
                        else
                        {
                            Console.WriteLine(Inventory);
                            foreach (string item in inventory)
                            {
                                Console.WriteLine($" {item}");
                            }
                        }
                    break;
                    case 5:
                        Console.WriteLine(ByuItems, money);
                        do
                        {                            
                            for (int i = 0; i < store.GetLength(0); i++)
                            {
                                Console.Write($"{i + 1} - {store[i]} ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"Price: {price[i]}");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.WriteLine(ZeroExit);
                            do
                            {
                                Console.WriteLine(OpStore);
                                opStore = Int32.Parse(Console.ReadLine());
                                try
                                {
                                    if (opStore != 0)
                                    {
                                        if (money > price[opStore - 1])
                                        {
                                            money -= price[opStore - 1];
                                            Console.WriteLine(Bought, store[opStore - 1], price[opStore - 1], money);
                                            tempInven[0] = store[opStore - 1];
                                            if (inventory[0].Equals(""))
                                            {
                                                inventory[0] = tempInven[0];
                                            }
                                            else
                                            {
                                                inventory = inventory.Concat(tempInven).ToArray();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(NoMoney);
                                        }
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine(Error);
                                }
                            } while (opStore < 0 || opStore > 5);
                        } while (opStore != 0);
                    break;
                    case 6:
                        switch (lvl)
                        {
                            case 1:
                                Console.WriteLine(AtkFor, 1);
                                Console.WriteLine(level1[0]);
                                Console.WriteLine(NewPowers);
                            break;
                            case 2:
                                Console.WriteLine(AtkFor, 2);
                                Console.WriteLine(level1[0]);
                                for (int i = 0; i < level2.GetLength(0); i++)
                                {
                                    Console.WriteLine(level2[i]);
                                }
                                Console.WriteLine(NewPowers); 
                            break;
                            case 3:
                                Console.WriteLine(AtkFor, 3);
                                Console.WriteLine(level1[0]);
                                for (int i = 0; i < level2.GetLength(0); i++)
                                {
                                    Console.WriteLine(level2[i]);
                                }
                                for (int i = 0; i < level3.GetLength(0); i++)
                                {
                                    Console.WriteLine(level3[i]);
                                }
                                Console.WriteLine(NewPowers);
                            break;
                            case 4:
                                Console.WriteLine(AtkFor, 4);
                                Console.WriteLine(level1[0]);
                                for (int i = 0; i < level2.GetLength(0); i++)
                                {
                                    Console.WriteLine(level2[i]);
                                }
                                for (int i = 0; i < level3.GetLength(0); i++)
                                {
                                    Console.WriteLine(level3[i]);
                                }
                                for (int i = 0; i < level4.GetLength(0); i++)
                                {
                                    Console.WriteLine(level4[i]);
                                }
                                Console.WriteLine(NewPowers);
                            break;
                            case 5:
                                Console.WriteLine(AtkFor, 5);
                                Console.WriteLine(level1[0]);
                                for (int i = 0; i < level2.GetLength(0); i++)
                                {
                                    Console.WriteLine(level2[i]);
                                }
                                for (int i = 0; i < level3.GetLength(0); i++)
                                {
                                    Console.WriteLine(level3[i]);
                                }
                                for (int i = 0; i < level4.GetLength(0); i++)
                                {
                                    Console.WriteLine(level4[i]);
                                }
                                for (int i = 0; i < level5.GetLength(0); i++)
                                {
                                    Console.WriteLine(level5[i]);
                                }
                                Console.WriteLine(AllPowers);
                            break;
                        }
                    break;
                    case 7:
                        try
                        {
                            Console.WriteLine(EncripMsg);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(Scrool);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(SecretCodeMenu);
                            msgOp = Int32.Parse(Console.ReadLine());
                            switch (msgOp)
                            {
                                case 1:
                                    Console.Write(DecipheSpell);
                                    noSpaces = DragonSleep.Replace(" ", "");
                                    Console.WriteLine(noSpaces);
                                    codeMsg1 = true;
                                break;
                                case 2:
                                    foreach (char vowel in MagiCave)
                                    {
                                        if ("aeiouAEIOUáéíóúàèìòùAÉÍÓÚÀÈÌÒÙ".Contains(vowel))
                                        {
                                            vowelCount++;
                                        }
                                    }
                                    Console.WriteLine(MagicVowel, vowelCount);
                                    codeMsg2 = true;
                                break;
                                case 3:
                                    Console.WriteLine(Scan);
                                    Thread.Sleep(1000);
                                    Console.Write(DecodeNumber);
                                    foreach (char num in Spell)
                                    {
                                        if ("1234567890".Contains(num))
                                        {
                                            Console.Write(num);
                                        }
                                    }
                                    Console.WriteLine("");
                                    codeMsg3 = true;
                                break;
                                default:
                                    Console.WriteLine(Error2);
                                break;
                            }
                            if (codeMsg1 && codeMsg2 && codeMsg3)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(ThreeOfThree);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(Error2);
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