using ZooObject.AnimalBase; using ZooObject.Interfaces;
namespace ZooObject.Animals { public class Duck : Bird, IFly, ISwim, ILayEggs {
    public Duck():base("And","Kvak"){LegCount=2;}
    public void Fly(){} public void Swim(){} public void LayEggs(){} } }