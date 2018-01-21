using MChooser.Constants;
using MChooser.Models;
using MChooser.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MChooser.XMLControl
{
    public class XMLRetriever
    {
        public static List<MechModel> GetMechModels(MechClasses[] selectedClasses, Factions[] selectedFactions)
        {
            XDocument doc = XDocument.Load(StaticValues.OwnedMechsFile);
            List<MechModel> mechs = new List<MechModel>();

            foreach (MechClasses mechClass in selectedClasses)
            {
                mechs.AddRange(GetMechsByClass(doc, mechClass, selectedFactions));
            }

            return mechs;
        }

        public static object[] GetMechsForDropdown()
        {
            XDocument doc = XDocument.Load(StaticValues.OwnedMechsFile);
            List<DropDownItem> mechs = new List<DropDownItem>();
            IEnumerable<XElement> lights = (from el in doc.Root.Elements(MechClasses.LIGHT.ToString().ToLower())
                                        .Elements(StaticValues.XMLMechTag)
                                         select el);
            IEnumerable<XElement> mediums = (from el in doc.Root.Elements(MechClasses.MEDIUM.ToString().ToLower())
                                        .Elements(StaticValues.XMLMechTag)
                                            select el);
            IEnumerable<XElement> heavies = (from el in doc.Root.Elements(MechClasses.HEAVY.ToString().ToLower())
                                        .Elements(StaticValues.XMLMechTag)
                                            select el);
            IEnumerable<XElement> assaults = (from el in doc.Root.Elements(MechClasses.ASSAULT.ToString().ToLower())
                                        .Elements(StaticValues.XMLMechTag)
                                            select el);

            int index = 0;
            foreach (IEnumerable<XElement> enumerable in new IEnumerable<XElement>[] { lights, mediums, heavies, assaults })
            {
                foreach (XElement xel in enumerable)
                {
                    string modelName = (string)xel.Attribute(StaticValues.XMLModelNameTag);
                    string mechClass = xel.Parent.Name.ToString();
                    mechs.Add(new DropDownItem(modelName, mechClass));
                }
                index++;
            }

            return (mechs.OrderBy(e => e.DisplayValue).ToList()).Cast<object>().ToArray();
        }

        public static MechModel PerformChassisLookup(string chassisName, string chassisClass)
        {
            XDocument doc = XDocument.Load(StaticValues.OwnedMechsFile);
            IEnumerable<XElement> weightClass = (from el in doc.Root.Elements(chassisClass.ToLower())
                                          .Elements(StaticValues.XMLMechTag)
                                                          select el);

            foreach (XElement xel in weightClass)
            {
                string name = (string)xel.Attribute(StaticValues.XMLModelNameTag);
                if (name.ToLower().Equals(chassisName.ToLower()))
                {
                    return GenerateMechModel((MechClasses)System.Enum.Parse(typeof(MechClasses), chassisClass, true),
                        name, "", (string)xel.Attribute(StaticValues.XMLWeightIncrementTag), 
                        (Factions)System.Enum.Parse(typeof(Factions), (string)xel.Attribute(StaticValues.XMLMechfactionTag), true));
                }
            }
            return null;
        }

        private static List<MechModel> GetMechsByClass(XDocument doc, MechClasses mechClass, Factions[] selectedFactions)
        {
            return ConvertXElementsToMechModels((from el in doc.Root.Elements(mechClass.ToString().ToLower())
                                                .Elements(StaticValues.XMLMechTag)
                                                 select el), mechClass, selectedFactions);                               
        }

        private static List<MechModel> ConvertXElementsToMechModels(IEnumerable<XElement> xelements, 
            MechClasses mechClass, Factions[] selectedFactions)
        {
            List<MechModel> mechs = new List<MechModel>();
            foreach(XElement xel in xelements)
            {
                Factions faction = (Factions)System.Enum.Parse(typeof(Factions), (string)xel.Attribute(StaticValues.XMLMechfactionTag));
                if (selectedFactions.Contains(faction))
                {
                    string modelName = (string)xel.Attribute(StaticValues.XMLModelNameTag);
                    string weight = (string)xel.Attribute(StaticValues.XMLWeightIncrementTag);

                    foreach (XElement subXel in xel.Elements())
                    {
                        string variant = subXel.Value;
                        MechModel model = GenerateMechModel(mechClass, modelName, variant, weight, faction);
                        mechs.Add(model);
                    }  
                }
            }
            return mechs;
        }

        private static MechModel GenerateMechModel(MechClasses mechClass, string modelName, string variantName,
            string weight, Factions faction)
        {
            switch (mechClass)
            {
                case MechClasses.ASSAULT:
                    return new AssaultMech(modelName, variantName, faction,
                        (AssaultMechWeightIncrements)System.Enum.Parse(typeof(AssaultMechWeightIncrements), weight));
                case MechClasses.HEAVY:
                    return new HeavyMech(modelName, variantName, faction,
                        (HeavyMechWeightIncrements)System.Enum.Parse(typeof(HeavyMechWeightIncrements), weight));
                case MechClasses.MEDIUM:
                    return new MediumMech(modelName, variantName, faction,
                        (MediumMechWeightIncrements)System.Enum.Parse(typeof(MediumMechWeightIncrements), weight));
                case MechClasses.LIGHT:
                    return new LightMech(modelName, variantName, faction,
                        (LightMechWeightIncrements)System.Enum.Parse(typeof(LightMechWeightIncrements), weight));
            }
            return null;
        }
    }
}
