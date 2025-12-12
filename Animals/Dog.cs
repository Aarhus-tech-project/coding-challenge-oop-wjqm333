using ZooObject.AnimalBase; using ZooObject.Interfaces;
namespace ZooObject.Animals { public class Dog : Mammal, IMilkProducer {
    public Dog():base("Hund","Vov"){LegCount=4;HasTail=true;}
    public void ProduceMilk(){} } }