namespace zd6
{
    class StringLenghtChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Length > 0)
            {
                this.SetNext(new StringLowerCaseChecker());
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
