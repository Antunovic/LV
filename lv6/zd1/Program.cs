using System;

namespace zd1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();

            notebook.AddNote(new Note("razvoj", "LV6"));
            notebook.AddNote(new Note("Rppoon", "vjezba 6"));
            notebook.AddNote(new Note("HŽV", "hajduk zivi vjecno"));



            //IAbstractIterator iterator = notebook.GetIterator();
            
           // Console.WriteLine(iterator.First().Title);



           foreach(Note note in notebook)
            {
                Console.WriteLine(note.Title);
            }

            
        }
    }
}
