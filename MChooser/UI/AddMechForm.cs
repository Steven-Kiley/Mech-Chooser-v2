using MChooser.Constants;
using MChooser.ModelMaker;
using MChooser.Models;
using MChooser.UI;
using MChooser.XMLControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace MChooser
{
    public partial class AddMechForm : Form
    {
        private bool CompletedInitialization = false;
        private Action SwitchMethod;

        public AddMechForm(Action switchMethod)
        {
            this.SwitchMethod = switchMethod;
            InitializeComponent();
            this.ExistingMechs.Items.Add(new DropDownItem("--New Chassis--", StaticValues.NOCHASSIS));
            this.ExistingMechs.Items.AddRange(XMLRetriever.GetMechsForDropdown());
            this.ExistingMechs.SelectedIndex = 0;
            this.ActiveControl = this.NewChassisName;

            this.FactionSelector.Items.Add(new DropDownItem(Factions.INNER_SPHERE.ToString().Replace('_', ' '), Factions.INNER_SPHERE.ToString()));
            this.FactionSelector.Items.Add(new DropDownItem(Factions.CLAN.ToString(), Factions.CLAN.ToString()));
            this.FactionSelector.SelectedIndex = 0;

            this.WeightClassSelector.Items.Add(new DropDownItem(MechClasses.LIGHT.ToString(), MechClasses.LIGHT.ToString()));
            this.WeightClassSelector.Items.Add(new DropDownItem(MechClasses.MEDIUM.ToString(), MechClasses.MEDIUM.ToString()));
            this.WeightClassSelector.Items.Add(new DropDownItem(MechClasses.HEAVY.ToString(), MechClasses.HEAVY.ToString()));
            this.WeightClassSelector.Items.Add(new DropDownItem(MechClasses.ASSAULT.ToString(), MechClasses.ASSAULT.ToString()));
            this.WeightClassSelector.SelectedIndex = 0;

            CompletedInitialization = true;
        }

        private void ExistingMechs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.ExistingMechs.SelectedIndex;
            if (index == 0)
            {
                this.NewChassisLabel.Visible = true;
                this.NewChassisName.Visible = true;
                this.FactionSelector.Enabled = true;

                UpdateWeightClassDropdown(MechClasses.LIGHT);
                this.WeightClassSelector.Enabled = true;
                UpdateWeightIncrement(LightMechWeightIncrements.TWENTY.ToString());
                this.WeightIncrement.Enabled = true;
            }
            else
            {
                this.NewChassisLabel.Visible = false;
                this.NewChassisName.Visible = false;

                DropDownItem item = (DropDownItem)ExistingMechs.Items[index];
                MechModel model = XMLRetriever.PerformChassisLookup(item.DisplayValue, item.Value);

                if (model.MechFaction == Factions.INNER_SPHERE)
                {
                    this.FactionSelector.SelectedIndex = 0;
                    this.FactionSelector.Enabled = false;
                }
                else
                {
                    this.FactionSelector.SelectedIndex = 1;
                    this.FactionSelector.Enabled = false;
                }

                UpdateWeightClassDropdown(model.MechClass);
                this.WeightClassSelector.Enabled = false;
                UpdateWeightIncrement(model.GetMechWeight());
                this.WeightIncrement.Enabled = false;
            }
        }

        private void WeightClassSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.WeightClassSelector.SelectedIndex;
            UpdateWeightIncrements(index);
        }

        private void UpdateWeightIncrements(int indexOfWeightClass)
        {
            switch (indexOfWeightClass)
            {
                case 0:
                    this.WeightIncrement.Items.Clear();
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)LightMechWeightIncrements.TWENTY).ToString(), LightMechWeightIncrements.TWENTY.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)LightMechWeightIncrements.TWENTY_FIVE).ToString(), LightMechWeightIncrements.TWENTY_FIVE.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)LightMechWeightIncrements.THIRTY).ToString(), LightMechWeightIncrements.THIRTY.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)LightMechWeightIncrements.THIRTY_FIVE).ToString(), LightMechWeightIncrements.THIRTY_FIVE.ToString()));
                    this.WeightIncrement.SelectedIndex = 0;
                    break;
                case 1:
                    this.WeightIncrement.Items.Clear();
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)MediumMechWeightIncrements.FORTY).ToString(), MediumMechWeightIncrements.FORTY.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)MediumMechWeightIncrements.FORTY_FIVE).ToString(), MediumMechWeightIncrements.FORTY_FIVE.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)MediumMechWeightIncrements.FIFTY).ToString(), MediumMechWeightIncrements.FIFTY.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)MediumMechWeightIncrements.FIFTY_FIVE).ToString(), MediumMechWeightIncrements.FIFTY_FIVE.ToString()));
                    this.WeightIncrement.SelectedIndex = 0;
                    break;
                case 2:
                    this.WeightIncrement.Items.Clear();
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)HeavyMechWeightIncrements.SIXTY).ToString(), HeavyMechWeightIncrements.SIXTY.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)HeavyMechWeightIncrements.SIXTY_FIVE).ToString(), HeavyMechWeightIncrements.SIXTY_FIVE.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)HeavyMechWeightIncrements.SEVENTY).ToString(), HeavyMechWeightIncrements.SEVENTY.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)HeavyMechWeightIncrements.SEVENTY_FIVE).ToString(), HeavyMechWeightIncrements.SEVENTY_FIVE.ToString()));
                    this.WeightIncrement.SelectedIndex = 0;
                    break;
                case 3:
                    this.WeightIncrement.Items.Clear();
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)AssaultMechWeightIncrements.EIGHTY).ToString(), AssaultMechWeightIncrements.EIGHTY.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)AssaultMechWeightIncrements.EIGHTY_FIVE).ToString(), AssaultMechWeightIncrements.EIGHTY_FIVE.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)AssaultMechWeightIncrements.NINETY).ToString(), AssaultMechWeightIncrements.NINETY.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)AssaultMechWeightIncrements.NINETY_FIVE).ToString(), AssaultMechWeightIncrements.NINETY_FIVE.ToString()));
                    this.WeightIncrement.Items.Add(new DropDownItem(((int)AssaultMechWeightIncrements.HUNDRED).ToString(), AssaultMechWeightIncrements.HUNDRED.ToString()));
                    this.WeightIncrement.SelectedIndex = 0;
                    break;
            }
        }

        private void UpdateWeightClassDropdown(MechClasses weightClass)
        {
            if (CompletedInitialization)
            {
                switch (weightClass)
                {
                    case MechClasses.LIGHT:
                        this.WeightClassSelector.SelectedIndex = 0;
                        UpdateWeightIncrements(0);
                        break;
                    case MechClasses.MEDIUM:
                        this.WeightClassSelector.SelectedIndex = 1;
                        UpdateWeightIncrements(1);
                        break;
                    case MechClasses.HEAVY:
                        this.WeightClassSelector.SelectedIndex = 2;
                        UpdateWeightIncrements(2);
                        break;
                    case MechClasses.ASSAULT:
                        this.WeightClassSelector.SelectedIndex = 3;
                        UpdateWeightIncrements(3);
                        break;
                } 
            }
        }

        private void UpdateWeightIncrement(string increment)
        {
            for (int i = 0; i < this.WeightIncrement.Items.Count; i++)
            {
                DropDownItem item = (DropDownItem)this.WeightIncrement.Items[i];
                if (item.Value.ToLower().Equals(increment.ToLower()))
                {
                    this.WeightIncrement.SelectedIndex = i;
                    break;
                }
            }
        }

        private void AddMechButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string mechModel;
                if (this.ExistingMechs.SelectedIndex == 0)
                {
                    mechModel = this.NewChassisName.Text;
                }
                else
                {
                    mechModel = ((DropDownItem)this.ExistingMechs.Items[this.ExistingMechs.SelectedIndex]).DisplayValue;
                }
                string mechVariant = this.VariantName.Text; 
                Factions faction = (Factions)System.Enum.Parse(typeof(Factions), 
                    ((DropDownItem)this.FactionSelector.Items[this.FactionSelector.SelectedIndex]).Value);
                string weightIncrement = ((DropDownItem)this.WeightIncrement.Items[this.WeightIncrement.SelectedIndex]).Value;
                MechClasses mechClass = (MechClasses)System.Enum.Parse(typeof(MechClasses),
                    ((DropDownItem)this.WeightClassSelector.Items[this.WeightClassSelector.SelectedIndex]).Value);

                MechModel mechForAddition = MechModelMaker.GenerateMechModel(mechClass, mechModel, mechVariant,
                    weightIncrement, faction);

                AddMechResult result = MChooserXMLWriter.AddMechToFile(mechForAddition);

                HandleAddMechResults(result, mechForAddition);
            }
            else
            {
                this.ResponseMessage.Text = "Please fill out all relevent data for new mech or variant";
                this.ResponseMessage.ForeColor = Color.Red;
                this.ResponseMessage.Visible = true;
            }
        }

        private bool ValidateForm()
        {
            if(this.ExistingMechs.SelectedIndex == 0 && String.IsNullOrEmpty(this.NewChassisName.Text))
                return false;
            if (String.IsNullOrEmpty(this.VariantName.Text))
                return false;

            return true;
        }

        private void HandleAddMechResults(AddMechResult result, MechModel mechForAddition)
        {
            switch (result)
            {
                case AddMechResult.CHASSIS_AND_VARIANT_EXIST:
                    this.ResponseMessage.Text = String.Format("{0} - {1} already in inventory", 
                        mechForAddition.MechModelName, mechForAddition.ModelVariantName);
                    this.ResponseMessage.ForeColor = Color.Red;
                    break;
                case AddMechResult.SUCCESSFULLY_ADDED_NEW_CHASSIS_AND_VARIANT:
                    this.ResponseMessage.Text = String.Format("Successfully added {0} - {1} to inventory!",
                        mechForAddition.MechModelName, mechForAddition.ModelVariantName);
                    UpdateExistingMechsDropdown(mechForAddition);
                    this.ResponseMessage.ForeColor = Color.Green;
                    break;
                case AddMechResult.SUCCESSFULLY_ADDED_NEW_VARIANT:
                    this.ResponseMessage.Text = String.Format("Successfully added {0} variant to {1}",
                        mechForAddition.ModelVariantName, mechForAddition.MechModelName);
                    this.ResponseMessage.ForeColor = Color.Green;
                    break;
            }
            this.ResponseMessage.Visible = true;
        }

        private void UpdateExistingMechsDropdown(MechModel addedMech)
        {
            this.ExistingMechs.Items.Add(new DropDownItem(addedMech.MechModelName, addedMech.MechClass.ToString()));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void ReturnToMechChooserButton_Click(object sender, EventArgs e)
        {
            this.SwitchMethod();
        }
    }
}
