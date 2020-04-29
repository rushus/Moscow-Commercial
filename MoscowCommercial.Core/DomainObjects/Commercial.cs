using System;
using System.Collections.Generic;
using System.Text;

namespace MoscowCommercial.Core.DomainObjects
{
    public class Commercial
    {
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int FicilityArea { get; set; }
        public ObjectType Type { get; set; }
        public SpecializationType Spec { get; set; }
        public string PeriodOfPlacement { get; set; }
        public string NameOfBusinessEntity { get; set; }
        public Location Location { get; set; }
    }
}
