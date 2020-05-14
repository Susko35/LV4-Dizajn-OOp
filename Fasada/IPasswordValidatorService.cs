using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_Dizajn_OOP.Fasada
{
    interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }
}
