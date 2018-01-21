using MChooser.Constants;
using MChooser.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MChooser.XMLControl
{
    public class MChooserXMLWriter
    {
        public static AddMechResult AddMechToFile(MechModel mech)
        {
            AddMechResult result = AddMechResult.CHASSIS_AND_VARIANT_EXIST;
            FileInfo fileInfo = new FileInfo(Constants.StaticValues.OwnedMechsFile);
            XDocument doc = XDocument.Load(fileInfo.FullName);
            XElement model = (from el in doc.Root.Elements(mech.MechClass.ToString().ToLower())
                                               .Elements(StaticValues.XMLMechTag)
                              where (string)el.Attribute(StaticValues.XMLModelNameTag) == mech.MechModelName
                              select el)
                                  .FirstOrDefault();

            if (CheckEntryExists(model, mech) == false)
            {
                if (model == null)
                {
                    XElement weightClass = doc.Root.Element(mech.MechClass.ToString().ToLower());

                    weightClass.Add(
                        new XElement(StaticValues.XMLMechTag, new object[] {
                            new XAttribute(StaticValues.XMLMechfactionTag, mech.MechFaction),
                            new XAttribute(StaticValues.XMLWeightIncrementTag, mech.GetMechWeight()),
                            new XAttribute(StaticValues.XMLModelNameTag, mech.MechModelName),
                            new XElement(StaticValues.XMLModelVariantTag, mech.ModelVariantName)
                     }));
                    result = AddMechResult.SUCCESSFULLY_ADDED_NEW_CHASSIS_AND_VARIANT;
                }
                else
                {
                    model.Add(
                        new XElement(StaticValues.XMLModelVariantTag, mech.ModelVariantName));
                    result = AddMechResult.SUCCESSFULLY_ADDED_NEW_VARIANT;
                }

                doc.Save(fileInfo.FullName); 
            }
            else
            {
                result = AddMechResult.CHASSIS_AND_VARIANT_EXIST;
            }

            return result;
        }

        private static bool CheckEntryExists(XElement model, MechModel mech)
        {
            if (model == null)
            {
                return false;
            }
            else
            {
                XElement variant = (from el in model.Elements(StaticValues.XMLModelVariantTag)
                               where (string)el.Value == mech.ModelVariantName
                               select el)
                              .FirstOrDefault();
                if (variant == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
