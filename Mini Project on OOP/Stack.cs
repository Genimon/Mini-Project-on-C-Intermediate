using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Project_on_OOP
{
    public class Stack
    {
        
        private readonly List<object> _elements = new List<object>();

        public void Push(object obj)
        {
            _elements.Add(obj);

            if (_elements.Contains(null))
            {
                throw new InvalidOperationException("The input contains a null element, enter a valid input.");
            }

            
            
        }

        public object Pop()
        {
            var lastObject = _elements.Last();
            _elements.Remove(lastObject);
            return lastObject;

        }

        public void Clear()
        {
            _elements.Clear();
        }

    }
}
