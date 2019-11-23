using System;

namespace StrategyPattern
{
    public interface ITimeSource
    {
        DateTime Now { get; }
    }
}
