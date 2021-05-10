using System;

namespace zd6
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

            ReminderNote reminderNote = new ReminderNote("rppoon", new YellowTheme());


            reminderNote.Show();
            groupnote1.Show();
            groupNote2.Show();


        }
    }
}
