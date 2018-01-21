using MChooser.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChooser.Models
{
    public class AssaultMech : MechModel
    {
        public AssaultMechWeightIncrements Weight;

        public AssaultMech(string ModelName, string VariantName, Factions faction, AssaultMechWeightIncrements increment)
        {
            this.MechClass = MechClasses.ASSAULT;
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
