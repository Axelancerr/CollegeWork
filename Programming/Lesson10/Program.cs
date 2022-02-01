using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Lesson10
{
    class Program
    {
        public class Entity
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int AttackDamage { get; set; }
        }
        public class Player : Entity
        {
            public Player(string name, int health, int attackDamage)
            {
                Name = name;
                Health = health;
                AttackDamage = attackDamage;
            }
        }
        public class Spider : Entity
        {
            public Spider(string name, int health, int attackDamage)
            {
                Name = name;
                Health = health;
                AttackDamage = attackDamage;
            }
        }
        public class Goblin : Entity
        {
            public Goblin(string name, int health, int attackDamage)
            {
                Name = name;
                Health = health;
                AttackDamage = attackDamage;
            }
        }

        public static void DisplayEntity(Entity entity)
        {
            Console.WriteLine($"Name: {entity.Name}");
            Console.WriteLine($"Health: {entity.Health}");
            Console.WriteLine($"Attack damage: {entity.AttackDamage}");
        }

        static void Main(string[] args)
        {
            var player = new Player("Axel", 10, 10);
            var spider = new Spider("Spider", 10, 10);
            var goblin = new Goblin("Spider", 10, 10);
            DisplayEntity(player);
            DisplayEntity(spider);
            DisplayEntity(goblin);
        }
    }
}