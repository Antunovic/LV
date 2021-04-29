using System;

namespace zd3
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }

}
