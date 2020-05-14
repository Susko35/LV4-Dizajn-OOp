using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_Dizajn_OOP.Fasada
{
    interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }

}
