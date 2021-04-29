using System;

namespace zd4
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }

}
