namespace BabelFish;

using System;

public class SequenceUseCase: UseCase<Void, object>
{
    List<UseCaseUnit<object, object>> units { get; set; }
    List<Output<object>> stream { get; set; }

    public SequenceUseCase(List<UseCaseUnit<object, object>> units){
        this.units = units;
        this.stream = new List<Output<object>>();
    }
    public override Output<object> execute(Void param)
    {
        foreach (var unit in units) {
            var output = unit.process();
            stream.Add(output);
        }
        return (Output<object>)new ValueOutput<object>(stream);
    }
}