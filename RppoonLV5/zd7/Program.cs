using System;

namespace zd7
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupNote groupnote1 = new GroupNote("razvoj lv5", new YellowTheme());

            groupnote1.AddMember("pero");
            groupnote1.AddMember("marko");

            GroupNote groupNote2 = new GroupNote("ferit", new LightTheme());

            groupNote2.AddMember("ivo");
            groupNote2.AddMember("slavica");

            Note reminderNote = new ReminderNote("rppoon", new YellowTheme());


            Notebook notebook = new Notebook(new YellowTheme());

            notebook.AddNote(groupnote1);
            notebook.AddNote(groupNote2);
            notebook.AddNote(reminderNote);

            notebook.Display();

        }
    }
}
