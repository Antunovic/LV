using System;
using System.Collections.Generic;

namespace zd7
{
    class GroupNote : Note
    {
        private List<string> members;
        public GroupNote(string message, ITheme theme) : base(message, theme)
        {
            members = new List<string>();
        }

        public void AddMember(string name)
        {
            members.Add(name);
        }

        public void RemoveMember(string name)
        {
            members.Remove(name);
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("GROPP NOTE: ");
            foreach(string member in members)
            {
                Console.WriteLine(member);
            }
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
