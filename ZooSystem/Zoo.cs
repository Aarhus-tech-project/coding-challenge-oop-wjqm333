using System;
using System.Collections.Generic;
using ZooObject.AnimalBase;
using ZooObject.Interfaces;

namespace ZooObject.ZooSystem
{
    public class Zoo
    {
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal a)
        {
            animals.Add(a);
        }

        public void MakeAllSounds()
        {
            Console.WriteLine("=== Lyde ===");
            foreach (var a in animals)
                a.MakeSound();
        }

        public void ShowAbilities()
        {
            Console.WriteLine("=== Evner ===");
            foreach (var a in animals)
            {
                List<string> ab = new List<string>();
                if (a is IFly) ab.Add("flyver");
                if (a is ISwim) ab.Add("svømmer");
                if (a is ILayEggs) ab.Add("lægger æg");
                if (a is IMilkProducer) ab.Add("producerer mælk");
                Console.WriteLine($"{a.Name}: " + (ab.Count>0?string.Join(", ",ab):"ingen"));
            }
        }

        public void ShowBodyParts()
        {
            Console.WriteLine("=== Kropsdele ===");
            foreach (var a in animals)
                Console.WriteLine($"{a.Name}: {a.Describe()}");
        }
    }
}
