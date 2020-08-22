using System;

namespace PubgCheat
{
    public class Printer
    {
        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine( "╔═════════════════════════════════════════════════════════════════════╗" + "\n" +
                               "║__________     ___.             _________ .__                   __   ║" + "\n" +
                              @"║\______   \__ _\_ |__    ____   \_   ___ \|  |__   ____ _____ _/  |_ ║" + "\n" +
                              @"║ |     ___/  |  \ __ \  / ___\  /    \  \/|  |  \_/ __ \\__  \\   __\║" + "\n" +
                              @"║ |    |   |  |  / \_\ \/ /_/  > \     \___|   Y  \  ___/ / __ \|  |  ║" + "\n" +
                              @"║ |____|   |____/|___  /\___  /   \______  /___|  /\___  >____  /__|  ║" + "\n" +
                              @"║                    \//_____/           \/     \/     \/     \/      ║" + "\n" +
                               "╚═════════════════════════════════════════════════════════════════════╝");
    }
        public void PrintMainMenu()
        {
            Welcome();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Start cheat" + "\n" + "2. Exit cheat");
        }

        public void WrongInput()
        {
            Console.WriteLine("\nWrong input, try again");
        }
        
        public void PrintCheatMenu()
        {
            Console.WriteLine("1. Antena\n2. Jump");
        }

        public void SuccessMessage()
        {
            
        }

        public void ErrorMessage()
        {
            Console.WriteLine("Cant load cheat menu. Firstly start your game, and restart cheat!");
        }

        public void ExitMessage()
        {
            Console.WriteLine("Good luck! Exited.");
        }
    }
}