using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Element : BaseModel
    {
        public string Name { get; set; }
        public ElementType ElementType { get; set; }
        public Specification Specification { get; set; }
        public bool IsNative { get; set; }
        public float? FailureRate { get; set; }
        public float? FailureRateSwitch { get; set; }
        public string SubType { get; set; }
        public ManufacturingTechnology ManufacturingTechnology { get; set; }
        public TypeOfHousing TypeOfHousing { get; set; }
        public int? TemperatureMax { get; set; }
        public int? TemperatureSuperheat { get; set; }
        public int? TemperatureTransition { get; set; }
        public int? Quantity { get; set; }
    }
}
