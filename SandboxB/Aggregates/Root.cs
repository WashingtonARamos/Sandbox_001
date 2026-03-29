using System.Runtime.CompilerServices;
using SandboxB.Struct;

namespace SandboxB.Aggregates;

public abstract partial record Root
{
    private Root() { }
    public abstract string WhoAmI { get; }
    

    public sealed partial record ChildA : Root
    {
        private string Foo { get; }
        private string Bar { get; }

        internal ChildA(ChildAData data)
        {
            Foo = data.Foo;
            Bar = data.Bar;
        }

        public override string WhoAmI => "I'm class A";
    }
    
    public sealed partial record ChildB : Root
    {
        private string SomeData { get; }
        private string SomeOtherData { get; }
        
        internal ChildB(ChildBData data)
        {
            SomeData = data.SomeData;
            SomeOtherData = data.SomeOtherData;
        }

        public override string WhoAmI => "I'm class B";
    }

    public static implicit operator Root(ChildAData data) => new ChildA(data);
    public static implicit operator Root(ChildBData data) => new ChildB(data);
}