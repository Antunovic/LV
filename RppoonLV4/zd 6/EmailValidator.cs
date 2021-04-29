using System;

namespace zd6
{
    class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(String candidate)
        {
            if(ContainsAtSign(candidate) && EndsWithDomain(candidate))
            {
                return true;
            }

            return false;
        }

        private bool ContainsAtSign(String candidate)
        {
            if (candidate.Contains('@'))
            {
                return true;
            }
            return false;
        }

        private bool EndsWithDomain(String candidate)
        {
            if(candidate.EndsWith(".com") || candidate.EndsWith(".hr"))
            {
                return true;
            }

            return false;
        }
    }

}
