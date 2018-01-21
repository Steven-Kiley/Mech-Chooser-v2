namespace MChooser.UI
{
    partial class SelectionForm
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
            this.FactionGroup = new System.Windows.Forms.GroupBox();
            this.FactionSelectError = new System.Windows.Forms.Label();
            this.ClanCheckbox = new System.Windows.Forms.CheckBox();
            this.InnerSphereCheckbox = new System.Windows.Forms.CheckBox();
            this.WeightClassGroup = new System.Windows.Forms.GroupBox();
            this.WeightClassSelectError = new System.Windows.Forms.Label();
            this.AssaultCheckbox = new System.Windows.Forms.CheckBox();
            this.HeavyCheckbox = new System.Windows.Forms.CheckBox();
            this.MediumCheckbox = new System.Windows.Forms.CheckBox();
            this.LightCheckbox = new System.Windows.Forms.CheckBox();
            this.ChooseMechButton = new System.Windows.Forms.Button();
            this.AddMechButton = new System.Windows.Forms.Button();
            this.RandomMechDetails = new System.Windows.Forms.GroupBox();
            this.VariantName = new System.Windows.Forms.Label();
            this.ChassisName = new System.Windows.Forms.Label();
            this.Variant = new System.Windows.Forms.Label();
            this.ChassisLabel = new System.Windows.Forms.Label();
            this.NoMechsError = new System.Windows.Forms.Label();
            this.FactionGroup.SuspendLayout();
            this.WeightClassGroup.SuspendLayout();
            this.RandomMechDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // FactionGroup
            // 
            this.FactionGroup.Controls.Add(this.FactionSelectError);
            this.FactionGroup.Controls.Add(this.ClanCheckbox);
            this.FactionGroup.Controls.Add(this.InnerSphereCheckbox);
            this.FactionGroup.Location = new System.Drawing.Point(13, 13);
            this.FactionGroup.Name = "FactionGroup";
            this.FactionGroup.Size = new System.Drawing.Size(206, 155);
            this.FactionGroup.TabIndex = 0;
            this.FactionGroup.TabStop = false;
            this.FactionGroup.Text = "Select Faction(s)";
            // 
            // FactionSelectError
            // 
            this.FactionSelectError.AutoSize = true;
            this.FactionSelectError.ForeColor = System.Drawing.Color.Red;
            this.FactionSelectError.Location = new System.Drawing.Point(28, 121);
            this.FactionSelectError.Name = "FactionSelectError";
            this.FactionSelectError.Size = new System.Drawing.Size(141, 20);
            this.FactionSelectError.TabIndex = 2;
            this.FactionSelectError.Text = "Select at least one";
            this.FactionSelectError.Visible = false;
            // 
            // ClanCheckbox
            // 
            this.ClanCheckbox.AutoSize = true;
            this.ClanCheckbox.Checked = true;
            this.ClanCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClanCheckbox.Location = new System.Drawing.Point(28, 80);
            this.ClanCheckbox.Name = "ClanCheckbox";
            this.ClanCheckbox.Size = new System.Drawing.Size(67, 24);
            this.ClanCheckbox.TabIndex = 1;
            this.ClanCheckbox.Text = "Clan";
            this.ClanCheckbox.UseVisualStyleBackColor = true;
            this.ClanCheckbox.CheckedChanged += new System.EventHandler(this.ClanCheckbox_CheckedChanged);
            // 
            // InnerSphereCheckbox
            // 
            this.InnerSphereCheckbox.AutoSize = true;
            this.InnerSphereCheckbox.Checked = true;
            this.InnerSphereCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InnerSphereCheckbox.Location = new System.Drawing.Point(28, 38);
            this.InnerSphereCheckbox.Name = "InnerSphereCheckbox";
            this.InnerSphereCheckbox.Size = new System.Drawing.Size(128, 24);
            this.InnerSphereCheckbox.TabIndex = 0;
            this.InnerSphereCheckbox.Text = "Inner Sphere";
            this.InnerSphereCheckbox.UseVisualStyleBackColor = true;
            this.InnerSphereCheckbox.CheckedChanged += new System.EventHandler(this.InnerSphereCheckbox_CheckedChanged);
            // 
            // WeightClassGroup
            // 
            this.WeightClassGroup.Controls.Add(this.WeightClassSelectError);
            this.WeightClassGroup.Controls.Add(this.AssaultCheckbox);
            this.WeightClassGroup.Controls.Add(this.HeavyCheckbox);
            this.WeightClassGroup.Controls.Add(this.MediumCheckbox);
            this.WeightClassGroup.Controls.Add(this.LightCheckbox);
            this.WeightClassGroup.Location = new System.Drawing.Point(279, 13);
            this.WeightClassGroup.Name = "WeightClassGroup";
            this.WeightClassGroup.Size = new System.Drawing.Size(311, 155);
            this.WeightClassGroup.TabIndex = 1;
            this.WeightClassGroup.TabStop = false;
            this.WeightClassGroup.Text = "Select Weight Class(es)";
            // 
            // WeightClassSelectError
            // 
            this.WeightClassSelectError.AutoSize = true;
            this.WeightClassSelectError.ForeColor = System.Drawing.Color.Red;
            this.WeightClassSelectError.Location = new System.Drawing.Point(27, 121);
            this.WeightClassSelectError.Name = "WeightClassSelectError";
            this.WeightClassSelectError.Size = new System.Drawing.Size(231, 20);
            this.WeightClassSelectError.TabIndex = 4;
            this.WeightClassSelectError.Text = "Select at least one weight class";
            this.WeightClassSelectError.Visible = false;
            // 
            // AssaultCheckbox
            // 
            this.AssaultCheckbox.AutoSize = true;
            this.AssaultCheckbox.Checked = true;
            this.AssaultCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AssaultCheckbox.Location = new System.Drawing.Point(192, 80);
            this.AssaultCheckbox.Name = "AssaultCheckbox";
            this.AssaultCheckbox.Size = new System.Drawing.Size(96, 24);
            this.AssaultCheckbox.TabIndex = 3;
            this.AssaultCheckbox.Text = "Assaults";
            this.AssaultCheckbox.UseVisualStyleBackColor = true;
            this.AssaultCheckbox.CheckedChanged += new System.EventHandler(this.AssaultCheckbox_CheckedChanged);
            // 
            // HeavyCheckbox
            // 
            this.HeavyCheckbox.AutoSize = true;
            this.HeavyCheckbox.Checked = true;
            this.HeavyCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HeavyCheckbox.Location = new System.Drawing.Point(192, 38);
            this.HeavyCheckbox.Name = "HeavyCheckbox";
            this.HeavyCheckbox.Size = new System.Drawing.Size(92, 24);
            this.HeavyCheckbox.TabIndex = 2;
            this.HeavyCheckbox.Text = "Heavies";
            this.HeavyCheckbox.UseVisualStyleBackColor = true;
            this.HeavyCheckbox.CheckedChanged += new System.EventHandler(this.HeavyCheckbox_CheckedChanged);
            // 
            // MediumCheckbox
            // 
            this.MediumCheckbox.AutoSize = true;
            this.MediumCheckbox.Checked = true;
            this.MediumCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MediumCheckbox.Location = new System.Drawing.Point(27, 80);
            this.MediumCheckbox.Name = "MediumCheckbox";
            this.MediumCheckbox.Size = new System.Drawing.Size(99, 24);
            this.MediumCheckbox.TabIndex = 1;
            this.MediumCheckbox.Text = "Mediums";
            this.MediumCheckbox.UseVisualStyleBackColor = true;
            this.MediumCheckbox.CheckedChanged += new System.EventHandler(this.MediumCheckbox_CheckedChanged);
            // 
            // LightCheckbox
            // 
            this.LightCheckbox.AutoSize = true;
            this.LightCheckbox.Checked = true;
            this.LightCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LightCheckbox.Location = new System.Drawing.Point(27, 38);
            this.LightCheckbox.Name = "LightCheckbox";
            this.LightCheckbox.Size = new System.Drawing.Size(78, 24);
            this.LightCheckbox.TabIndex = 0;
            this.LightCheckbox.Text = "Lights";
            this.LightCheckbox.UseVisualStyleBackColor = true;
            this.LightCheckbox.CheckedChanged += new System.EventHandler(this.LightCheckbox_CheckedChanged);
            // 
            // ChooseMechButton
            // 
            this.ChooseMechButton.BackColor = System.Drawing.Color.DarkGreen;
            this.ChooseMechButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ChooseMechButton.Location = new System.Drawing.Point(13, 210);
            this.ChooseMechButton.Name = "ChooseMechButton";
            this.ChooseMechButton.Size = new System.Drawing.Size(143, 33);
            this.ChooseMechButton.TabIndex = 2;
            this.ChooseMechButton.Text = "Choose Mech";
            this.ChooseMechButton.UseVisualStyleBackColor = false;
            this.ChooseMechButton.Click += new System.EventHandler(this.ChooseMechButton_Click);
            // 
            // AddMechButton
            // 
            this.AddMechButton.Location = new System.Drawing.Point(13, 256);
            this.AddMechButton.Name = "AddMechButton";
            this.AddMechButton.Size = new System.Drawing.Size(143, 31);
            this.AddMechButton.TabIndex = 3;
            this.AddMechButton.Text = "Add Mech ";
            this.AddMechButton.UseVisualStyleBackColor = true;
            this.AddMechButton.Click += new System.EventHandler(this.AddMechButton_Click);
            // 
            // RandomMechDetails
            // 
            this.RandomMechDetails.Controls.Add(this.NoMechsError);
            this.RandomMechDetails.Controls.Add(this.VariantName);
            this.RandomMechDetails.Controls.Add(this.ChassisName);
            this.RandomMechDetails.Controls.Add(this.Variant);
            this.RandomMechDetails.Controls.Add(this.ChassisLabel);
            this.RandomMechDetails.Location = new System.Drawing.Point(279, 184);
            this.RandomMechDetails.Name = "RandomMechDetails";
            this.RandomMechDetails.Size = new System.Drawing.Size(314, 147);
            this.RandomMechDetails.TabIndex = 4;
            this.RandomMechDetails.TabStop = false;
            this.RandomMechDetails.Text = "Random Mech";
            // 
            // VariantName
            // 
            this.VariantName.AutoSize = true;
            this.VariantName.Location = new System.Drawing.Point(93, 73);
            this.VariantName.Name = "VariantName";
            this.VariantName.Size = new System.Drawing.Size(0, 20);
            this.VariantName.TabIndex = 3;
            // 
            // ChassisName
            // 
            this.ChassisName.AutoSize = true;
            this.ChassisName.Location = new System.Drawing.Point(89, 29);
            this.ChassisName.Name = "ChassisName";
            this.ChassisName.Size = new System.Drawing.Size(0, 20);
            this.ChassisName.TabIndex = 2;
            // 
            // Variant
            // 
            this.Variant.AutoSize = true;
            this.Variant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Variant.Location = new System.Drawing.Point(11, 74);
            this.Variant.Name = "Variant";
            this.Variant.Size = new System.Drawing.Size(67, 20);
            this.Variant.TabIndex = 1;
            this.Variant.Text = "Variant";
            // 
            // ChassisLabel
            // 
            this.ChassisLabel.AutoSize = true;
            this.ChassisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChassisLabel.Location = new System.Drawing.Point(7, 29);
            this.ChassisLabel.Name = "ChassisLabel";
            this.ChassisLabel.Size = new System.Drawing.Size(72, 20);
            this.ChassisLabel.TabIndex = 0;
            this.ChassisLabel.Text = "Chassis";
            // 
            // NoMechsError
            // 
            this.NoMechsError.AutoSize = true;
            this.NoMechsError.ForeColor = System.Drawing.Color.Red;
            this.NoMechsError.Location = new System.Drawing.Point(15, 110);
            this.NoMechsError.Name = "NoMechsError";
            this.NoMechsError.Size = new System.Drawing.Size(252, 20);
            this.NoMechsError.TabIndex = 4;
            this.NoMechsError.Text = "No mech matches selected criteria";
            this.NoMechsError.Visible = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 343);
            this.Controls.Add(this.RandomMechDetails);
            this.Controls.Add(this.AddMechButton);
            this.Controls.Add(this.ChooseMechButton);
            this.Controls.Add(this.WeightClassGroup);
            this.Controls.Add(this.FactionGroup);
            this.Name = "SelectionForm";
            this.Text = "Mech Chooser";
            this.FactionGroup.ResumeLayout(false);
            this.FactionGroup.PerformLayout();
            this.WeightClassGroup.ResumeLayout(false);
            this.WeightClassGroup.PerformLayout();
            this.RandomMechDetails.ResumeLayout(false);
            this.RandomMechDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FactionGroup;
        private System.Windows.Forms.CheckBox InnerSphereCheckbox;
        private System.Windows.Forms.CheckBox ClanCheckbox;
        private System.Windows.Forms.Label FactionSelectError;
        private System.Windows.Forms.GroupBox WeightClassGroup;
        private System.Windows.Forms.CheckBox LightCheckbox;
        private System.Windows.Forms.CheckBox MediumCheckbox;
        private System.Windows.Forms.CheckBox HeavyCheckbox;
        private System.Windows.Forms.CheckBox AssaultCheckbox;
        private System.Windows.Forms.Label WeightClassSelectError;
        private System.Windows.Forms.Button ChooseMechButton;
        private System.Windows.Forms.Button AddMechButton;
        private System.Windows.Forms.GroupBox RandomMechDetails;
        private System.Windows.Forms.Label ChassisLabel;
        private System.Windows.Forms.Label Variant;
        private System.Windows.Forms.Label ChassisName;
        private System.Windows.Forms.Label VariantName;
        private System.Windows.Forms.Label NoMechsError;
    }
}