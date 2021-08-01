using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "HEAT_DISTRIBUTION")]
    public class HeatDistribution : BeElement
    {
        public HeatDistribution(
            int distributionType = HeatDistributionType.OneString,
            double inletTemperature = 60,
            double returnTemperature = 40
            )
        {
            DistrubutionType = distributionType;
            InletTemperature = new DimTemp("Inlet", inletTemperature);
            ReturnTemperature = new DimTemp("Return", returnTemperature);
            Pumps_Constant_Year = new List<DistributionPump>();
            Pumps_Constant_HeatingSeason = new List<DistributionPump>();
            Pumps_TimeReg_HeatingSeason = new List<DistributionPump>();
            Pumps_Combi = new List<DistributionPump>();        
        }

        // Sfb code
        [FieldAttribute(XmlElementName = "sfb", ValueType = Attributes.ValueType.String)]
        public string Sfb { get; set; }

        // Distribution type (1 or 2 string system)
        [FieldAttribute(XmlElementName = "tube_type", ValueType = Attributes.ValueType.Int)]
        public int DistrubutionType { get; set; }

        // Inlet temperature [*C]
        [FieldAttribute(XmlElementName = "inlet_temp", ValueType = Attributes.ValueType.OneToOne)]
        public DimTemp InletTemperature { get; set; }

        // Return temperature [*C]
        [FieldAttribute(XmlElementName = "return_temp", ValueType = Attributes.ValueType.OneToOne)]
        public DimTemp ReturnTemperature { get; set; }

        // PUMPS //

        // Pumps in constant operation year around
        [FieldAttribute(XmlElementName = "pump_const_year", ValueType = Attributes.ValueType.OneToMany)]
        public List<DistributionPump> Pumps_Constant_Year { get; set; }

        // Pumps in constant operation during the heating season
        [FieldAttribute(XmlElementName = "pump_const_hs", ValueType = Attributes.ValueType.OneToMany)]
        public List<DistributionPump> Pumps_Constant_HeatingSeason { get; set; }

        // Pumps with time regulation during the heating season
        [FieldAttribute(XmlElementName = "pump_timereg_hs", ValueType = Attributes.ValueType.OneToMany)]
        public List<DistributionPump> Pumps_TimeReg_HeatingSeason { get; set; }

        // Combination pumps that both circulate heating and boiler
        [FieldAttribute(XmlElementName = "pump_combi", ValueType = Attributes.ValueType.OneToMany)]
        public List<DistributionPump> Pumps_Combi { get; set; }
    }

    public static class HeatDistributionType
    {
        public const int
            OneString = 1,
            TwoString = 2;
    }
}
