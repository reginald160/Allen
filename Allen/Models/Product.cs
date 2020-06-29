using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Allen.Models;

namespace Allen.Models
{
    public enum Product

    {

        [Display(Name = "Data bundles")]
        Data,

        [Display(Name = "Hosing Services")]
        Hosting,

        [Display(Name = "internet Services")]
        Inteernet,

        [Display(Name = "Simcard")]
        Simcard,

        [Display(Name = "Tariff Plans")]
        Tariff,
        [Display(Name = "Phone Plans")]
        Phone,


        [Display(Name = "Others")]
        Others,

    }
}
