using System.Linq;

namespace zd6
{
    class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if(stringToCheck.Any(x => char.IsLower(x)))
            {
                this.SetNext(new StringUpperCaseChecker());
                return true;
            }

            return false;
        }
    }
}
