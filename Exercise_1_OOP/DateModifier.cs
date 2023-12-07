using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_OOP
{
    public class DateModifier
    {
        public int DaysDifference(string dateTimeOne, string dateTimeTwo)
        {
			try
			{
				var dateTimeOneResult = DateTime.ParseExact(dateTimeOne, "dd/mm/yyyy", CultureInfo.InvariantCulture);
                var dateTimeTwoResult = DateTime.ParseExact(dateTimeTwo, "dd/mm/yyyy", CultureInfo.InvariantCulture);

                return Math.Abs(dateTimeOneResult.Day - dateTimeTwoResult.Day);
            }
			catch (Exception)
			{
                throw;
            }
        }
    }
}
