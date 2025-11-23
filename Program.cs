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
        //op1 var
        Random rand = new Random();
        int power = 0, hours = 0, op = -1, lvl = 1;
        string user = "", title = "";        
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
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        } while (op != 0);        
    }
}
