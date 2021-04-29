using System;

namespace zd6
{
    interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }

}
