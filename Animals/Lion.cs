using ZooObject.AnimalBase; using ZooObject.Interfaces;
namespace ZooObject.Animals { public class Lion : Mammal, IMilkProducer {
    public Lion():base("Løve","Roar"){LegCount=4;HasTail=true;}
    public void ProduceMilk(){} } }