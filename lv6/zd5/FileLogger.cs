using System;
using System.IO;

namespace zd5
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine( $"{type}: " + message + DateTime.Now);
            }
        }
    }
}
