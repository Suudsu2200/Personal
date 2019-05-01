using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fissure.Components
{
    public class CardComponent
    {
        private Dictionary<Type, CardComponent> _children;
        private bool IsLeaf() => !_children.Any();
        public void AddChild(CardComponent component)
        {
            _children.Add(component.GetType(), component);
        }

        public T GetChild<T>() where T : CardComponent
        {
            return (T)_children[typeof(T)];
        }

        public T FindDescendant<T>() where T : CardComponent
        {
            if (_children.ContainsKey(typeof(T)))
                return (T)_children[typeof(T)];

            T descendant;
            foreach(CardComponent child in _children.Values)
                if ((descendant = child.FindDescendant<T>()) != null)
                    return descendant;

            return null;
        }
    }
}
