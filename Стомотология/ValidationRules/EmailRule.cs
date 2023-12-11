using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Стомотология.ValidationRules
{
    public class EmailRule : ValidationRule
    {

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            //выявление ошибок при написании электронной почты
            string Почта = "";
            if (value != null)
            {
                Почта = value.ToString();
            }
            else
            {
                return new ValidationResult(false, "Адрес элекронной почты не задан!"); 
            }
            if (Почта.Contains("@") && Почта.Contains("."))
            {
                return new ValidationResult(true, null);
            }
            else
            {
                return new ValidationResult(false, "Адрес элекронной почты должен содержать символы @ и (.) точки \n Шаблон адреса: address@mail.ru");
            }
        }
    }
}
