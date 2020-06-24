using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class CaraTaker
    {
        public Stack<Memento> Save;
        public CaraTaker()
        {
            Save = new Stack<Memento>();
        }
        public void In(Memento memento)
        {
            Save.Push(memento);
        }
        public Memento Out()
        {
           return Save.Pop();
        }
        ~CaraTaker() { }
    }
}
