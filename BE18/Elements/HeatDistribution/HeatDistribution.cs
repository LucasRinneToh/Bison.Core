using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BE18.Attributes;
using Bison.Core.BE18.Elements.HeatingPipes;

namespace Bison.Core.BE18
{
    [ModelAttribute(ElementName = "HEAT_DISTRIBUTION")]
    public class HeatDistribution : BeElement
    {
        public HeatDistribution(
            string name = "Plant type",
            int distributionType = HeatDistributionType.OneString,
            double inletTemperature = 60,
            double returnTemperature = 40
            )
        {
            this.id = name;
            this.DistrubutionType = distributionType;
            this.InletTemperature = new DimTemp("Inlet", inletTemperature);
            this.ReturnTemperature = new DimTemp("Return", returnTemperature);
            this.Pumps_Constant_Year = new List<DistributionPump>();
            this.Pumps_Constant_HeatingSeason = new List<DistributionPump>();
            this.Pumps_TimeReg_HeatingSeason = new List<DistributionPump>();
            this.Pumps_Combi = new List<DistributionPump>();
            this.Pipes = new List<HeatingPipe>();
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

        #region PUMPS
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
        #endregion

        // Heating pipes
        [FieldAttribute(XmlElementName = "has_tube", ValueType = Attributes.ValueType.OneToMany)]
        public List<HeatingPipe> Pipes { get; set; }

    }

    public static class HeatDistributionType
    {
        public const int
            OneString = 1,
            TwoString = 2;
    }
}
