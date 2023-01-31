namespace BabelFish;

using System;
using System.Threading.Tasks;

public class CompositeJobDisposable : IDisposable
{
    Task? job { get; set; }

    public void Dispose() {
        job?.Dispose();
    }
    public void add(Task job) {
        this.job = job;
    }
}