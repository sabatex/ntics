using ntics.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ntics.DateTimeExtensions
{
    [DisplayEnum(Name ="Select period")]
    public enum DateTimePeriodType
    {
        [DisplayEnum(Name = "Довільний період")]
        None = 0,
        [DisplayEnum(Name = "Рік")]
        Year = 1,
        [DisplayEnum(Name = "Квартал")]
        Quarter = 2,
        [DisplayEnum(Name = "Місяць")]
        Month = 3,
        [DisplayEnum(Name = "Неділя")]
        Week = 4,
        [DisplayEnum(Name = "День")]
        Day = 5

    }
}
