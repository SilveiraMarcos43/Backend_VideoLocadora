using System;

namespace SVL.Base.Domain.Generics
{
    /// <summary>
    /// Valida��o mascara telefone com express�o regular
    /// </summary>
    class PhoneValid
    {

        public static bool validPhone(String phoneString) 
        {
            System.Text.RegularExpressions.Match match =
                    System.Text.RegularExpressions.Regex.Match(phoneString, @"^\(\d{2}\)\d{4}-\d{4}$");
            if (!match.Success)
            {                
                return false;
            }
            else
                return true;
        }
    }
}
