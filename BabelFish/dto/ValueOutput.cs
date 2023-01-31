namespace BabelFish;

using System;

public class ValueOutput<V> : Output<V> where V : class {
    public ValueOutput(V value): base(value, null) {

    }
    
    public override bool isError()
    {
        return false;
    }
}