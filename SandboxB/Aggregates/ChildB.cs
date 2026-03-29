namespace SandboxB.Aggregates;

public abstract partial record Root
{
    public sealed partial record ChildB
    {
        public void DoSomeStuff()
        {
            Console.WriteLine(SomeData);
        }
    }
}