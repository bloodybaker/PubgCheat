using System;
using System.Collections.Generic;
using PubgCheat.CheatMenu;

namespace PubgCheat
{
    public class Router
    {
        private Printer _printer = new Printer();
        private Dictionary<Char, Action> _menu = new Dictionary<Char, Action>();

        public void GenerateMenu()
        {
            _menu.Add('1', new StartCheat());
            _menu.Add('2', new ExitCheat());
            _printer.PrintMainMenu();
        }

        public void GenerateFuncs()
        {
            _menu.Add('1', new Antena());
            _menu.Add('2', new Jump());
        }

        public void ScanInput()
        {
            char input = Console.ReadKey().KeyChar;
            if (Int32.Parse(input.ToString()) > 0 && Int32.Parse(input.ToString()) <= _menu.Count)
            {
                Console.Clear();
                _menu[input].Selection(_printer,this);
            }
            else
            {
                _printer.WrongInput();
                ScanInput();
            }
        }

        public Dictionary<Char, Action> GetMenu()
        {
            return _menu;
        }
    }
}