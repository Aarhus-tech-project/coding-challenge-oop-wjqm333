using ZooObject.AnimalBase; using ZooObject.Interfaces;
namespace ZooObject.Animals { public class Cow : Mammal, IMilkProducer {
    public Cow():base("Ko","Muh"){LegCount=4;HasTail=true;}
    public void ProduceMilk(){} } }