using ZooObject.AnimalBase;
using ZooObject.Animals;
using ZooObject.ZooSystem;

namespace ZooObject
{
    class Program
    {
        static void Main()
        {
            var zoo = new Zoo();
            zoo.AddAnimal(new Lion());
            zoo.AddAnimal(new Dog());
            zoo.AddAnimal(new Cat());
            zoo.AddAnimal(new Parrot());
            zoo.AddAnimal(new Duck());
            zoo.AddAnimal(new Cow());
            zoo.AddAnimal(new Pig());

            zoo.MakeAllSounds();
            zoo.ShowAbilities();
            zoo.ShowBodyParts();
        }
    }
}
