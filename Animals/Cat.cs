using ZooObject.AnimalBase; using ZooObject.Interfaces;
namespace ZooObject.Animals { public class Cat : Mammal, IMilkProducer {
    public Cat():base("Kat","Mijav"){LegCount=4;HasTail=true;}
    public void ProduceMilk(){} } }