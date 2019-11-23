using System;

namespace StrategyPattern
{
    internal class TimeSourceWrapper : ITimeSource
    {
        public DateTime Now => DateTime.Now;
    }
}
