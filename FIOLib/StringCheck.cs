using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; //библиотека для работы с регулярными выражениями
using System.Threading.Tasks;

namespace StringCheckLibrary
{
    public class StringCheck
    /// <summary>
    /// Проверка stringName на наличие символов: буква, пробел и дефис.
    /// Строка stringName не должна превышать 50 символов.
    /// </summary>
    /// <param name="stringName"></param>
    /// <returns>true/false</returns>
    {
        public bool CheckName(string stringName)
        {
            {
                string regex = @"^(([а-я])|(\s)|(-\))+$";
                string rexexWhiteSpace = @"^((\s)|(\-))+$";
                if (Regex.Match(stringName,rexexWhiteSpace,RegexOptions.IgnoreCase).Success)
                {
                    return false;
                }
                else
                {
                    if (Regex.Match(stringName, regex, RegexOptions.IgnoreCase).Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }
        }
    }
}
