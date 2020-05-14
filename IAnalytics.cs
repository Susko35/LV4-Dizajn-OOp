using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_Dizajn_OOP
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
