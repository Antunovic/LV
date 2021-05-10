using System;
using System.Collections.Generic;

namespace zd7
{
    class Notebook
    {
        private List<Note> notes;
        private ITheme theme;
        public Notebook(ITheme theme)
        {
            this.notes = new List<Note>();
            this.theme = theme;
            
        }
        public void AddNote(Note note)
        {
            note.Theme = theme;
            this.notes.Add(note);
        }
        public void ChangeTheme(ITheme theme)
        {
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach (Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
