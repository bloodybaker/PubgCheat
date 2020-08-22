using System;

namespace PubgCheat
{
    class Program
    {
        static void Main(string[] args)
        {
            Router router = new Router();
            router.GenerateMenu();
            router.ScanInput();
        }
    }
}