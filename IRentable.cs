using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_Dizajn_OOP
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
