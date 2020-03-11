﻿using System.Collections.Generic;

namespace Visitor
{
    internal class ObjectStructure
    {
        private readonly List<Element> _elements = new List<Element>();
        public void Attach(Element element) => _elements.Add(element);
        public void Detach(Element element) => _elements.Remove(element);
        public void Accept(Visitor visitor) => _elements.ForEach(e => e.Accept(visitor));
    }
}