namespace BabelFish;

using System;

public class ErrorOutput<V>: Output<V> where V : class {

    public ErrorOutput(Exception error): base(null, error) {
    
    }

    public override bool isError()
    {
        return true;
    }
}