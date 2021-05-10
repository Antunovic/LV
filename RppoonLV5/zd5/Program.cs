using System;

namespace zd5
{
    class Program
    {
        static void Main(string[] args)
        {
            ITheme theme = new YellowTheme();

            Note note = new ReminderNote("razvoj lv5", theme);

            note.Show();

            theme = new LightTheme();

            note.Theme = theme;

            note.Show();



        }
    }

}
