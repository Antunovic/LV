using System.Collections.Generic;

namespace zd4
{
    class CareTaker
    {
        List<Memento> mementos = new List<Memento>();

       

        public Memento PreviousState { get; private set; }

        public void AddState(Memento state)
        {
            PreviousState = state;
            mementos.Add(state);
        }

    }
}
