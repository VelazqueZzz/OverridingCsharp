using System;
using System.Security.Cryptography.X509Certificates;

class Alpha
{
    public int alpha;
    public virtual void show()
    {
        Console.WriteLine("Klass Alpha: {0}", alpha);
    }
    public Alpha(int a)
    {
        alpha = a;
    }
}
class Bravo : Alpha
{
    public int bravo;
    public override void show()
    {
         Console.WriteLine("Class Bravo: {0} and {1}", alpha, bravo);
    }
    public Bravo(int a, int b): base(a){
            bravo = b;
    }
 }
class Charlie: Bravo
{
    public int charlie;
    public override void show()
    {
        Console.WriteLine("Class Charlie: {0},{1} and {2}",alpha,bravo,charlie);
    }
    public Charlie(int a,int b,int c) : base(a, b)
    {
        charlie = c;
    }
}
class OverridingDemo
{
    static void Main()
    {
        Alpha objA = new Alpha(10);
        objA.show();
        Console.WriteLine();
        Bravo objB = new Bravo(20, 30);
        objA = objB;
        objA.show();
        objB.show();
        Console.WriteLine();
        Charlie objC = new Charlie(40, 50, 60);
        objA = objC;
        objB = objC;
        objA.show();
        objB.show();
        objC.show();

    }
}
