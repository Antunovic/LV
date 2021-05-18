using System.Collections.Generic;

namespace zd3
{
    class CareTaker
    {
        List<Memento> mementos = new List<Memento>();

        public Memento PreviousState { get; set; }

        public void StoreSave(Memento save)
        {
            this.mementos.Add(save);
            PreviousState = save;
        }

    }
}
