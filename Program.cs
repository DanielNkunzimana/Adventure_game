using System;
using System.Collections.Generic;

namespace AdventureGame
{
    struct PlayerStats
    {
        public int Health;
        public int Gold;
    }

    abstract class Entity
    {
        // Added '?' to allow Name to be null/empty initially
        public string? Name { get; set; } 
        public abstract void Speak();
    }

    class Enemy : Entity
    {
        public int Damage { get; set; }
        public override void Speak() => Console.WriteLine($"{Name} growls at you!");
    }

    class Game
    {
        private bool _isRunning = true;
        private PlayerStats _player;
        // Initializing with string.Empty to stop the 'non-nullable' warning
        private string _playerName = string.Empty; 

        public void Start()
        {
            Console.WriteLine("Welcome to the C# Dungeon!");
            Console.Write("What is your name, adventurer? ");
            // Added '?? ""' to provide a fallback if input is null
            _playerName = Console.ReadLine() ?? "Unknown Hero";

            _player.Health = 100;
            _player.Gold = 0;

            while (_isRunning && _player.Health > 0)
            {
                GameLoop();
            }

            Console.WriteLine("\n--- GAME OVER ---");
            Console.WriteLine($"Final Score for {_playerName}: {_player.Gold} Gold.");
        }

        void GameLoop()
        {
            Console.WriteLine($"\n[HP: {_player.Health} | Gold: {_player.Gold}]");
            Console.WriteLine("What would you like to do? (1) Explore (2) Rest (3) Quit");
            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                Explore();
            }
            else if (choice == "2")
            {
                Rest();
            }
            else if (choice == "3")
            {
                _isRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }

        void Explore()
        {
            Random rand = new Random();
            int eventRoll = rand.Next(1, 4);

            if (eventRoll == 1)
            {
                Enemy goblin = new Enemy { Name = "Goblin", Damage = 15 };
                goblin.Speak();
                _player.Health -= goblin.Damage;
                Console.WriteLine($"The {goblin.Name} hit you for {goblin.Damage} damage!");
            }
            else
            {
                int foundGold = rand.Next(5, 20);
                _player.Gold += foundGold;
                Console.WriteLine($"You found a chest containing {foundGold} gold!");
            }
        }

        void Rest()
        {
            Console.WriteLine("You take a nap and recover 20 HP.");
            _player.Health = Math.Min(_player.Health + 20, 100);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            myGame.Start();
        }
    }
}