using System;

namespace zd5
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }

}
