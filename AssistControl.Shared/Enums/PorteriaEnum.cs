using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssistControl.Shared.Enums
{
    public enum PorteriaEnum
    {
        [Display(Name = "Norte")]
        Norte,
        [Display(Name = "Sur")]
        Sur,
        [Display(Name = "Oriental")]
        Oriental, 
        [Display(Name = "Occidental")]
        Occidental
    }
}
