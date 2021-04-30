using System;

namespace zd7
{
    interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }

}
