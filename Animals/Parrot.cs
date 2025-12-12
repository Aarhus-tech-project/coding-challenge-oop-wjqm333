using ZooObject.AnimalBase; using ZooObject.Interfaces;
namespace ZooObject.Animals { public class Parrot : Bird, IFly, ILayEggs {
    public Parrot():base("Papegøje","Squawk"){LegCount=2;}
    public void Fly(){} public void LayEggs(){} } }