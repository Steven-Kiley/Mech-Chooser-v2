using MChooser.Constants;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChooser.Models
{
    public abstract class MechModel
    {
        public string MechModelName;
        public string ModelVariantName;
        public MechClasses MechClass;
        public Factions MechFaction;

        public abstract string GetMechWeight();

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            MechModel mechObj = (MechModel)obj;
            if (!mechObj.MechModelName.Equals(this.MechModelName)
                || !mechObj.ModelVariantName.Equals(this.ModelVariantName)
                || mechObj.MechClass != this.MechClass
                || mechObj.MechFaction != this.MechFaction)
            {
                return false;
            }

            return true;
        }
    }
}
