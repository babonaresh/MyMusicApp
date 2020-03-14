using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace MyMusicApp.ViewModels
{
    public class ValidTime : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isvalid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:MM",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);


            return (isvalid);

        }
        }
    }