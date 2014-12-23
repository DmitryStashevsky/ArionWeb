using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Element : BaseStringEntity
    {
        public ElementClass ElementClass { get; set; }
        public ElementGroup ElementGroup { get; set; }
        public Position Position { get; set; }
        public string Specification { get; set; }
        public float? FailureRate { get; set; }
        public float? FailureRateSwitch { get; set; }
        public string SubType { get; set; }
        public string ManufacturingTechnology { get; set; }
        public string TypeOfHousing { get; set; }
        public int? TemperatureMax { get; set; }
        public int? TemperatureSuperheat { get; set; }
        public int? TemperatureTransition { get; set; }
        public int? Quantity { get; set; }
    }
}
