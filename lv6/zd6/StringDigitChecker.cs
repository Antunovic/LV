using System.Linq;

namespace zd6
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Where(x=>char.IsDigit(x)).Any())
            {
                this.SetNext(new StringLenghtChecker());
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
