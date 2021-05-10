using System;

namespace zd6
{
    class YellowTheme : ITheme
    {
        public string GetFooter(int width)
        {
            return new string('#', width);
        }

        public string GetHeader(int width)
        {
            return new string('*', width);
        }

        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }

        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }

}
