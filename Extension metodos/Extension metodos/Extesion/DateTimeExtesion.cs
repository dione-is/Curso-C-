using System;
using System.Globalization;

namespace Extension_metodos.Extesion {
     static class DateTimeExtesion {
    
        public static string ElapsedTime(this DateTime thisObj) {

            TimeSpan duracao = DateTime.Now.Subtract(thisObj);

            if (duracao.TotalHours < 24.0) {

                return duracao.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas";
            }else {
                return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + "dias";
            }



        }
    }
}
