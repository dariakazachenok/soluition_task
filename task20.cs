using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20
{
    class Voin
    {
         public string Name { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }

        public Voin(string name)
        {
            Name = name;
            Health = 100;
            Armor = 0;
            }

        public virtual  int Geturon(int Damage)
        {
            Console.Write(Name + " Войн без брони получит урона:");
            return Health - Damage;
        }
    }

    class VoinEasy : Voin // класс наследник 1
    {
        public int Armor { get; set; } //  броня

        public VoinEasy(string name) : base(name)
        {
            Armor = 50;
        }

        public override int Geturon(int Damage)
        {
            Console.Write(Name + " Bойн со слабой бронёй получит урон:");
            return base.Geturon(Damage) + Armor;
        }
    }

    class VoinHard : Voin // класс наследник 2
    {
        public int Armor { get; set; } //  броня
        
        public VoinHard(string name) : base(name)
        {
           Armor = 80;
        }

        public override int Geturon(int Damage)
        {
            Console.Write(Name + " Bойн с сильной бронёй получит урон:" );
            return base.Geturon(Damage) + Armor;
            }
    }
    
    class task20
    {
        static void Main(string[] args)
        {
            List<Voin> voins = new List<Voin>();
            voins.Add(new Voin("Василий"));
            voins.Add(new VoinEasy("Эдуард"));
            voins.Add(new VoinHard("Петр"));
            
            foreach (Voin p in voins)
            Console.Write(p.Geturon(50) + "\n");
            Console.ReadKey();
        }
    }
}


