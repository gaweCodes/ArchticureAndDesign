﻿namespace Prototype
{
    public abstract class Prototype
    {
        public string Id { get; }
        protected Prototype(string id)
        {
            Id = id;
        }
        public abstract Prototype Clone();
    }
}
