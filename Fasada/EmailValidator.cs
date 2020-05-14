using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_Dizajn_OOP.Fasada
{
    class EmailValidator : IEmailValidatorService
    {
        public int MinLength { get; private set; }
        public EmailValidator(int minLength)
        {
            this.MinLength = minLength;
        }

        public bool IsValidAddress(String candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return IsLongEnough(candidate) && candidate.Contains("@") && EndsWithSetDomain(candidate);
        }
        private bool IsLongEnough(String candidate)
        {
            return candidate.Length >= this.MinLength;
        }
        private bool EndsWithSetDomain(string candidate)
        {
            return candidate.EndsWith(".com") || candidate.EndsWith(".hr");
        }


    }
}
