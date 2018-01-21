using MChooser.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChooser.Models
{
    public class HeavyMech : MechModel
    {
        public HeavyMechWeightIncrements Weight;

        public HeavyMech(string ModelName, string VariantName, Factions faction, HeavyMechWeightIncrements increment)
        {
            this.MechClass = MechClasses.HEAVY;
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
