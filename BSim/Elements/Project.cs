using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bison.Core.BSim.Attributes;

namespace Bison.Core.BSim.Elements
{
    [BSimXmlModel(Name = "DIS_PROJECT")]
    public class Project : BSimElement
    {
        public Project(
            string name = "BS9001-255",
            string description = "''",
            string database = "",
            int timeSteps = 10,
            int options = 0,
            double scale = 100,
            double grid = 1,
            double layerThickness = 0.05,
            string startTime = "2002.1.1",
            string endTime = "2002.12.31",
            string designParameters = "$"
            )
        {
            this.Name = name;
            this.Description = description;
            this.Database = database;
            this.TimeSteps = timeSteps;
            this.Options = options;
            this.Scale = scale;
            this.Grid = grid;
            this.LayerThickness = layerThickness;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.DesignParameters = designParameters;
        }

        // Description
        [BSimXmlModelProperty(Name = "description", Type = BSimValueType.String)]
        public string Description { get; set; }

        // Path to database
        [BSimXmlModelProperty(Name = "database", Type = BSimValueType.String)]
        public string Database { get; set; }

        // Timesteps
        [BSimXmlModelProperty(Name = "tstep", Type = BSimValueType.Int)]
        public int TimeSteps { get; set; }

        // Options
        [BSimXmlModelProperty(Name = "options", Type = BSimValueType.Int)]
        public int Options { get; set; }

        // Scale (used by the viewer)
        [BSimXmlModelProperty(Name = "scale", Type = BSimValueType.Double)]
        public double Scale { get; set; }

        // Grid size (used by the viewer)
        [BSimXmlModelProperty(Name = "grid", Type = BSimValueType.Double)]
        public double Grid { get; set; }

        // Layer thickness (for simulation)
        [BSimXmlModelProperty(Name = "layer_thick", Type = BSimValueType.Double)]
        public double LayerThickness { get; set; }

        // Start time (for simulation)
        [BSimXmlModelProperty(Name = "start_time", Type = BSimValueType.String)]
        public string StartTime { get; set; }

        // End time (for simulation)
        [BSimXmlModelProperty(Name = "end_time", Type = BSimValueType.String)]
        public string EndTime { get; set; }

        // Design parameters
        [BSimXmlModelProperty(Name = "has_design_parm", Type = BSimValueType.OneToOne, NullValue = "$")]
        public string DesignParameters { get; set; }
    }
}
