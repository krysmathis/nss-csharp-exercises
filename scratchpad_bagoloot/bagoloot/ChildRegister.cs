using System;
using System.Collections.Generic;

namespace bagoloot
{
    public class ChildRegister
    {
        public List<Child> _register = new List<Child>();
        public void AddChild(Child child)
        {
            _register.Add(child);
        }

        public List<Child> GetContents() => _register;

        public void RemoveChild(Child child)
        {
            _register.Remove(child);
        }
    }
}