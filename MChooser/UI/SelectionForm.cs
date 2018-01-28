using MChooser.Constants;
using MChooser.Models;
using MChooser.RandomNumberGeneration;
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

namespace MChooser.UI
{
    public partial class SelectionForm : Form
    {
        private Action SwitchMethod;
        private List<MechModel> AlreadySelectedMechs;
        private static int NoRepeatsFailoverLimit = 25;

        public SelectionForm(Action switchMethod)
        {
            this.SwitchMethod = switchMethod;
            this.AlreadySelectedMechs = new List<MechModel>();
            InitializeComponent();
        }

        private void ClanCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidateFactionCheckboxes())
                this.FactionSelectError.Visible = false;
            else
                this.FactionSelectError.Visible = true;
        }

        private void InnerSphereCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidateFactionCheckboxes())
                this.FactionSelectError.Visible = false;
            else
                this.FactionSelectError.Visible = true;
        }

        private bool ValidateFactionCheckboxes()
        {
            if (this.InnerSphereCheckbox.Checked || this.ClanCheckbox.Checked)
                return true;
            else
                return false;
        }

        private void LightCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidateWeightClassCheckboxes())
                this.WeightClassSelectError.Visible = false;
            else
                this.WeightClassSelectError.Visible = true;
        }

        private void HeavyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidateWeightClassCheckboxes())
                this.WeightClassSelectError.Visible = false;
            else
                this.WeightClassSelectError.Visible = true;
        }

        private void MediumCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidateWeightClassCheckboxes())
                this.WeightClassSelectError.Visible = false;
            else
                this.WeightClassSelectError.Visible = true;
        }

        private void AssaultCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidateWeightClassCheckboxes())
                this.WeightClassSelectError.Visible = false;
            else
                this.WeightClassSelectError.Visible = true;
        }

        private bool ValidateWeightClassCheckboxes()
        {
            if (this.LightCheckbox.Checked || this.MediumCheckbox.Checked
                || this.HeavyCheckbox.Checked || this.AssaultCheckbox.Checked)
                return true;
            else
                return false;
        }

        private void ChooseMechButton_Click(object sender, EventArgs e)
        {
            if (ValidateFactionCheckboxes() && ValidateWeightClassCheckboxes())
            {
                StrongRandom rand = new StrongRandom();
                List<MechClasses> chosenClasses = new List<MechClasses>();
                if (this.LightCheckbox.Checked)
                    chosenClasses.Add(MechClasses.LIGHT);
                if (this.MediumCheckbox.Checked)
                    chosenClasses.Add(MechClasses.MEDIUM);
                if (this.HeavyCheckbox.Checked)
                    chosenClasses.Add(MechClasses.HEAVY);
                if (this.AssaultCheckbox.Checked)
                    chosenClasses.Add(MechClasses.ASSAULT);

                List<Factions> chosenFactions = new List<Factions>();
                if (this.ClanCheckbox.Checked)
                    chosenFactions.Add(Factions.CLAN);
                if (this.InnerSphereCheckbox.Checked)
                    chosenFactions.Add(Factions.INNER_SPHERE);

                List<MechModel> choosableModels = XMLRetriever.GetMechModels(chosenClasses.ToArray(), chosenFactions.ToArray());

                if (choosableModels.Count > 0)
                {
                    int mechSelectAttempts = 0;
                    bool successfullySelectedMech = false;
                    while (!successfullySelectedMech && mechSelectAttempts < NoRepeatsFailoverLimit)
                    {
                        int randomMechIndex = rand.Next(choosableModels.Count);
                        MechModel chosenMech = choosableModels[randomMechIndex];

                        if (!AlreadySelectedMechs.Contains(chosenMech))
                        {
                            this.ChassisName.Text = chosenMech.MechModelName;
                            this.VariantName.Text = chosenMech.ModelVariantName;
                            this.NoMechsError.Visible = false;
                            AlreadySelectedMechs.Add(chosenMech);
                            successfullySelectedMech = true;
                        }
                        else
                        {
                            mechSelectAttempts++;
                            //Simple cleanout: if reached no repeat failover limit minus 1, 
                            //assume already selected mech list should be emptied so that last 
                            //attempt in while loop *should* succeed if any mech matches criteria
                            if (mechSelectAttempts == (NoRepeatsFailoverLimit - 1))
                            {
                                AlreadySelectedMechs.Clear();
                            }
                        }
                    }
                }
                else
                {
                    this.ChassisName.Text = "";
                    this.VariantName.Text = "";
                    this.NoMechsError.Visible = true;
                }
            }
        }

        private void AddMechButton_Click(object sender, EventArgs e)
        {
            this.SwitchMethod();
        }
    }
}
