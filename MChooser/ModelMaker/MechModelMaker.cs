using MChooser.Constants;
using MChooser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MChooser.ModelMaker
{
    public class MechModelMaker
    {
        public static MechModel GenerateMechModel(MechClasses mechClass, string modelName, string variantName,
            string weightIncrement, Factions faction)
        {
            MechModel mechModel = null;
            switch (mechClass)
            {
                case MechClasses.LIGHT:
                    mechModel = new LightMech(modelName, variantName, faction, 
                        (LightMechWeightIncrements)System.Enum.Parse(typeof(LightMechWeightIncrements), weightIncrement));
                    break;
                case MechClasses.MEDIUM:
                    mechModel = new MediumMech(modelName, variantName, faction,
                        (MediumMechWeightIncrements)System.Enum.Parse(typeof(MediumMechWeightIncrements), weightIncrement));
                    break;
                case MechClasses.HEAVY:
                    mechModel = new HeavyMech(modelName, variantName, faction,
                        (HeavyMechWeightIncrements)System.Enum.Parse(typeof(HeavyMechWeightIncrements), weightIncrement));
                    break;
                case MechClasses.ASSAULT:
                    mechModel = new AssaultMech(modelName, variantName, faction,
                        (AssaultMechWeightIncrements)System.Enum.Parse(typeof(AssaultMechWeightIncrements), weightIncrement));
                    break;
            }

            return mechModel;
        }
    }
}
