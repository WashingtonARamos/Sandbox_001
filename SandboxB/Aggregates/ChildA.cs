namespace SandboxB.Aggregates;

public abstract partial record Root
{
    public sealed partial record ChildA
    {
        public void DoStuff()
        {
            Console.WriteLine(Foo);
        }
    }
}