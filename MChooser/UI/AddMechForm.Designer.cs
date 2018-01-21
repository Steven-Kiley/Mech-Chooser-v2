namespace MChooser
{
    partial class AddMechForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExistingMechs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewChassisName = new System.Windows.Forms.TextBox();
            this.NewChassisLabel = new System.Windows.Forms.Label();
            this.FactionSelector = new System.Windows.Forms.ComboBox();
            this.WeightClassSelector = new System.Windows.Forms.ComboBox();
            this.VariantName = new System.Windows.Forms.TextBox();
            this.WeightIncrement = new System.Windows.Forms.ComboBox();
            this.FactionSelectorLabel = new System.Windows.Forms.Label();
            this.WeightIncrementLabel = new System.Windows.Forms.Label();
            this.WeightClassSelectorLabel = new System.Windows.Forms.Label();
            this.VariantNameLabel = new System.Windows.Forms.Label();
            this.ResponseMessage = new System.Windows.Forms.Label();
            this.AddMechButton = new System.Windows.Forms.Button();
            this.ReturnToMechChooserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExistingMechs
            // 
            this.ExistingMechs.FormattingEnabled = true;
            this.ExistingMechs.Location = new System.Drawing.Point(147, 53);
            this.ExistingMechs.Name = "ExistingMechs";
            this.ExistingMechs.Size = new System.Drawing.Size(276, 28);
            this.ExistingMechs.TabIndex = 0;
            this.ExistingMechs.SelectedIndexChanged += new System.EventHandler(this.ExistingMechs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Chassis";
            // 
            // NewChassisName
            // 
            this.NewChassisName.Location = new System.Drawing.Point(629, 53);
            this.NewChassisName.Name = "NewChassisName";
            this.NewChassisName.Size = new System.Drawing.Size(268, 26);
            this.NewChassisName.TabIndex = 2;
            // 
            // NewChassisLabel
            // 
            this.NewChassisLabel.AutoSize = true;
            this.NewChassisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewChassisLabel.Location = new System.Drawing.Point(441, 56);
            this.NewChassisLabel.Name = "NewChassisLabel";
            this.NewChassisLabel.Size = new System.Drawing.Size(162, 20);
            this.NewChassisLabel.TabIndex = 3;
            this.NewChassisLabel.Text = "New Chassis Name";
            // 
            // FactionSelector
            // 
            this.FactionSelector.FormattingEnabled = true;
            this.FactionSelector.Location = new System.Drawing.Point(147, 132);
            this.FactionSelector.Name = "FactionSelector";
            this.FactionSelector.Size = new System.Drawing.Size(276, 28);
            this.FactionSelector.TabIndex = 4;
            // 
            // WeightClassSelector
            // 
            this.WeightClassSelector.FormattingEnabled = true;
            this.WeightClassSelector.Location = new System.Drawing.Point(629, 132);
            this.WeightClassSelector.Name = "WeightClassSelector";
            this.WeightClassSelector.Size = new System.Drawing.Size(268, 28);
            this.WeightClassSelector.TabIndex = 5;
            this.WeightClassSelector.SelectedIndexChanged += new System.EventHandler(this.WeightClassSelector_SelectedIndexChanged);
            // 
            // VariantName
            // 
            this.VariantName.Location = new System.Drawing.Point(629, 211);
            this.VariantName.Name = "VariantName";
            this.VariantName.Size = new System.Drawing.Size(268, 26);
            this.VariantName.TabIndex = 7;
            // 
            // WeightIncrement
            // 
            this.WeightIncrement.FormattingEnabled = true;
            this.WeightIncrement.Location = new System.Drawing.Point(147, 211);
            this.WeightIncrement.Name = "WeightIncrement";
            this.WeightIncrement.Size = new System.Drawing.Size(276, 28);
            this.WeightIncrement.TabIndex = 8;
            // 
            // FactionSelectorLabel
            // 
            this.FactionSelectorLabel.AutoSize = true;
            this.FactionSelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactionSelectorLabel.Location = new System.Drawing.Point(13, 135);
            this.FactionSelectorLabel.Name = "FactionSelectorLabel";
            this.FactionSelectorLabel.Size = new System.Drawing.Size(125, 20);
            this.FactionSelectorLabel.TabIndex = 9;
            this.FactionSelectorLabel.Text = "Select Faction";
            // 
            // WeightIncrementLabel
            // 
            this.WeightIncrementLabel.AutoSize = true;
            this.WeightIncrementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightIncrementLabel.Location = new System.Drawing.Point(17, 214);
            this.WeightIncrementLabel.Name = "WeightIncrementLabel";
            this.WeightIncrementLabel.Size = new System.Drawing.Size(121, 20);
            this.WeightIncrementLabel.TabIndex = 10;
            this.WeightIncrementLabel.Text = "Select Weight";
            // 
            // WeightClassSelectorLabel
            // 
            this.WeightClassSelectorLabel.AutoSize = true;
            this.WeightClassSelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightClassSelectorLabel.Location = new System.Drawing.Point(441, 135);
            this.WeightClassSelectorLabel.Name = "WeightClassSelectorLabel";
            this.WeightClassSelectorLabel.Size = new System.Drawing.Size(170, 20);
            this.WeightClassSelectorLabel.TabIndex = 11;
            this.WeightClassSelectorLabel.Text = "Select Weight Class";
            // 
            // VariantNameLabel
            // 
            this.VariantNameLabel.AutoSize = true;
            this.VariantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VariantNameLabel.Location = new System.Drawing.Point(441, 214);
            this.VariantNameLabel.Name = "VariantNameLabel";
            this.VariantNameLabel.Size = new System.Drawing.Size(118, 20);
            this.VariantNameLabel.TabIndex = 12;
            this.VariantNameLabel.Text = "Variant Name";
            // 
            // ResponseMessage
            // 
            this.ResponseMessage.AutoSize = true;
            this.ResponseMessage.Location = new System.Drawing.Point(143, 370);
            this.ResponseMessage.Name = "ResponseMessage";
            this.ResponseMessage.Size = new System.Drawing.Size(147, 20);
            this.ResponseMessage.TabIndex = 13;
            this.ResponseMessage.Text = "ResponseMessage";
            this.ResponseMessage.Visible = false;
            // 
            // AddMechButton
            // 
            this.AddMechButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddMechButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMechButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddMechButton.Location = new System.Drawing.Point(629, 286);
            this.AddMechButton.Name = "AddMechButton";
            this.AddMechButton.Size = new System.Drawing.Size(268, 41);
            this.AddMechButton.TabIndex = 14;
            this.AddMechButton.Text = "Add Mech to my Inventory";
            this.AddMechButton.UseVisualStyleBackColor = false;
            this.AddMechButton.Click += new System.EventHandler(this.AddMechButton_Click);
            // 
            // ReturnToMechChooserButton
            // 
            this.ReturnToMechChooserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToMechChooserButton.Location = new System.Drawing.Point(147, 286);
            this.ReturnToMechChooserButton.Name = "ReturnToMechChooserButton";
            this.ReturnToMechChooserButton.Size = new System.Drawing.Size(276, 41);
            this.ReturnToMechChooserButton.TabIndex = 15;
            this.ReturnToMechChooserButton.Text = "Return to Mech Chooser";
            this.ReturnToMechChooserButton.UseVisualStyleBackColor = true;
            this.ReturnToMechChooserButton.Click += new System.EventHandler(this.ReturnToMechChooserButton_Click);
            // 
            // AddMechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 399);
            this.Controls.Add(this.ReturnToMechChooserButton);
            this.Controls.Add(this.AddMechButton);
            this.Controls.Add(this.ResponseMessage);
            this.Controls.Add(this.VariantNameLabel);
            this.Controls.Add(this.WeightClassSelectorLabel);
            this.Controls.Add(this.WeightIncrementLabel);
            this.Controls.Add(this.FactionSelectorLabel);
            this.Controls.Add(this.WeightIncrement);
            this.Controls.Add(this.VariantName);
            this.Controls.Add(this.WeightClassSelector);
            this.Controls.Add(this.FactionSelector);
            this.Controls.Add(this.NewChassisLabel);
            this.Controls.Add(this.NewChassisName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExistingMechs);
            this.Name = "AddMechForm";
            this.Text = "Mech Chooser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ExistingMechs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewChassisName;
        private System.Windows.Forms.Label NewChassisLabel;
        private System.Windows.Forms.ComboBox FactionSelector;
        private System.Windows.Forms.ComboBox WeightClassSelector;
        private System.Windows.Forms.TextBox VariantName;
        private System.Windows.Forms.ComboBox WeightIncrement;
        private System.Windows.Forms.Label FactionSelectorLabel;
        private System.Windows.Forms.Label WeightIncrementLabel;
        private System.Windows.Forms.Label WeightClassSelectorLabel;
        private System.Windows.Forms.Label VariantNameLabel;
        private System.Windows.Forms.Label ResponseMessage;
        private System.Windows.Forms.Button AddMechButton;
        private System.Windows.Forms.Button ReturnToMechChooserButton;
    }
}

