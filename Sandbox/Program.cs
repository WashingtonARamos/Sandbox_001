using SandboxB.Aggregates;
using SandboxB.Struct;

public class Program
{
    public static void Main()
    {
        var data = new ChildAData()
        {
            Foo = "foo",
            Bar = "bar"
        };

        Root root = data;
        Console.WriteLine(root.WhoAmI);

        switch (root)
        {
            case Root.ChildA a:
                a.DoStuff();
                break;
            case Root.ChildB b:
                b.DoSomeStuff();
                break;
        }
    }
}