using MChooser.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChooser.Models
{
    public class MediumMech : MechModel
    {
        public MediumMechWeightIncrements Weight;

        public MediumMech(string ModelName, string VariantName, Factions faction, MediumMechWeightIncrements increment)
        {
            this.MechClass = MechClasses.MEDIUM;
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
