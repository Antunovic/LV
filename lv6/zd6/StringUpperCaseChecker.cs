using System.Linq;

namespace zd6
{
    class StringUpperCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Any(x => char.IsUpper(x)))
            {
                return true;
            }

            return false;
        }
    }
}
