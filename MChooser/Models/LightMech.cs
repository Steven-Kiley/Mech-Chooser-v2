using MChooser.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChooser.Models
{
    public class LightMech : MechModel
    {
        public LightMechWeightIncrements Weight;

        public LightMech(string ModelName, string VariantName, Factions faction, LightMechWeightIncrements increment)
        {
            this.MechClass = MechClasses.LIGHT;
            this.MechModelName = ModelName;
            this.ModelVariantName = VariantName;
            this.MechFaction = faction;
            this.Weight = increment;
        }

        public override string GetMechWeight()
        {
            return this.Weight.ToString();
        }
    }
}
