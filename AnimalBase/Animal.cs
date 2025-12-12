using System;
using System.Collections.Generic;

namespace ZooObject.AnimalBase
{
    public abstract class Animal
    {
        public string Name { get; }
        public string Sound { get; protected set; }

        public int LegCount { get; protected set; }
        public int WingCount { get; protected set; }
        public bool HasTail { get; protected set; }
        public bool HasBeak { get; protected set; }

        protected Animal(string n, string s)
        {
            Name = n;
            Sound = s;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name}: {Sound}");
        }

        public virtual string Describe()
        {
            var list = new List<string>();
            list.Add($"{LegCount} ben");
            if (WingCount > 0) list.Add($"{WingCount} vinger");
            if (HasTail) list.Add("hale");
            if (HasBeak) list.Add("næb");
            return string.Join(", ", list);
        }
    }
}
