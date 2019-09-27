namespace CPAN155_Lab03_2
{
    partial class frmOrder
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
            this.lblTraditional = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.radTraditional = new System.Windows.Forms.RadioButton();
            this.radCustom = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpTiers = new System.Windows.Forms.GroupBox();
            this.radTier3 = new System.Windows.Forms.RadioButton();
            this.radTier2 = new System.Windows.Forms.RadioButton();
            this.radTier1 = new System.Windows.Forms.RadioButton();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpOccasion = new System.Windows.Forms.GroupBox();
            this.radWedding = new System.Windows.Forms.RadioButton();
            this.radGraduation = new System.Windows.Forms.RadioButton();
            this.radAnniversary = new System.Windows.Forms.RadioButton();
            this.grpFlavour = new System.Windows.Forms.GroupBox();
            this.radBanana = new System.Windows.Forms.RadioButton();
            this.radVanilla = new System.Windows.Forms.RadioButton();
            this.radChocolate = new System.Windows.Forms.RadioButton();
            this.grpCustomCake = new System.Windows.Forms.GroupBox();
            this.lstTraditional = new System.Windows.Forms.ListBox();
            this.grpType.SuspendLayout();
            this.grpTiers.SuspendLayout();
            this.grpOccasion.SuspendLayout();
            this.grpFlavour.SuspendLayout();
            this.grpCustomCake.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTraditional
            // 
            this.lblTraditional.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTraditional.AutoSize = true;
            this.lblTraditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraditional.Location = new System.Drawing.Point(357, 40);
            this.lblTraditional.Name = "lblTraditional";
            this.lblTraditional.Size = new System.Drawing.Size(123, 20);
            this.lblTraditional.TabIndex = 26;
            this.lblTraditional.Text = "Traditional Cake";
            // 
            // grpType
            // 
            this.grpType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpType.Controls.Add(this.radTraditional);
            this.grpType.Controls.Add(this.radCustom);
            this.grpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.Location = new System.Drawing.Point(18, 40);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(236, 107);
            this.grpType.TabIndex = 25;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type of Cake";
            // 
            // radTraditional
            // 
            this.radTraditional.AutoSize = true;
            this.radTraditional.Location = new System.Drawing.Point(121, 45);
            this.radTraditional.Name = "radTraditional";
            this.radTraditional.Size = new System.Drawing.Size(100, 24);
            this.radTraditional.TabIndex = 2;
            this.radTraditional.TabStop = true;
            this.radTraditional.Text = "Traditional";
            this.radTraditional.UseVisualStyleBackColor = true;
            this.radTraditional.CheckedChanged += new System.EventHandler(this.radTraditional_CheckedChanged);
            // 
            // radCustom
            // 
            this.radCustom.AutoSize = true;
            this.radCustom.Location = new System.Drawing.Point(6, 45);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(82, 24);
            this.radCustom.TabIndex = 1;
            this.radCustom.TabStop = true;
            this.radCustom.Text = "Custom";
            this.radCustom.UseVisualStyleBackColor = true;
            this.radCustom.CheckedChanged += new System.EventHandler(this.radCustom_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 20);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Baby Batter Bakery";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(500, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 31);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpTiers
            // 
            this.grpTiers.Controls.Add(this.radTier3);
            this.grpTiers.Controls.Add(this.radTier2);
            this.grpTiers.Controls.Add(this.radTier1);
            this.grpTiers.Location = new System.Drawing.Point(309, 25);
            this.grpTiers.Name = "grpTiers";
            this.grpTiers.Size = new System.Drawing.Size(136, 122);
            this.grpTiers.TabIndex = 7;
            this.grpTiers.TabStop = false;
            this.grpTiers.Text = "Number of Tiers";
            // 
            // radTier3
            // 
            this.radTier3.AutoSize = true;
            this.radTier3.Location = new System.Drawing.Point(13, 87);
            this.radTier3.Name = "radTier3";
            this.radTier3.Size = new System.Drawing.Size(74, 24);
            this.radTier3.TabIndex = 3;
            this.radTier3.TabStop = true;
            this.radTier3.Text = "3 Tiers";
            this.radTier3.UseVisualStyleBackColor = true;
            // 
            // radTier2
            // 
            this.radTier2.AutoSize = true;
            this.radTier2.Location = new System.Drawing.Point(13, 57);
            this.radTier2.Name = "radTier2";
            this.radTier2.Size = new System.Drawing.Size(74, 24);
            this.radTier2.TabIndex = 2;
            this.radTier2.TabStop = true;
            this.radTier2.Text = "2 Tiers";
            this.radTier2.UseVisualStyleBackColor = true;
            // 
            // radTier1
            // 
            this.radTier1.AutoSize = true;
            this.radTier1.Location = new System.Drawing.Point(13, 27);
            this.radTier1.Name = "radTier1";
            this.radTier1.Size = new System.Drawing.Size(66, 24);
            this.radTier1.TabIndex = 1;
            this.radTier1.TabStop = true;
            this.radTier1.Text = "1 Tier";
            this.radTier1.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(502, 191);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(103, 31);
            this.btnCheckOut.TabIndex = 29;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(502, 251);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 31);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(502, 131);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 31);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(502, 71);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(103, 31);
            this.btnView.TabIndex = 22;
            this.btnView.Text = "View Cart";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(502, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 31);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpOccasion
            // 
            this.grpOccasion.Controls.Add(this.radWedding);
            this.grpOccasion.Controls.Add(this.radGraduation);
            this.grpOccasion.Controls.Add(this.radAnniversary);
            this.grpOccasion.Location = new System.Drawing.Point(162, 25);
            this.grpOccasion.Name = "grpOccasion";
            this.grpOccasion.Size = new System.Drawing.Size(139, 122);
            this.grpOccasion.TabIndex = 7;
            this.grpOccasion.TabStop = false;
            this.grpOccasion.Text = "Occasion";
            // 
            // radWedding
            // 
            this.radWedding.AutoSize = true;
            this.radWedding.Location = new System.Drawing.Point(12, 87);
            this.radWedding.Name = "radWedding";
            this.radWedding.Size = new System.Drawing.Size(90, 24);
            this.radWedding.TabIndex = 3;
            this.radWedding.TabStop = true;
            this.radWedding.Text = "Wedding";
            this.radWedding.UseVisualStyleBackColor = true;
            // 
            // radGraduation
            // 
            this.radGraduation.AutoSize = true;
            this.radGraduation.Location = new System.Drawing.Point(12, 57);
            this.radGraduation.Name = "radGraduation";
            this.radGraduation.Size = new System.Drawing.Size(107, 24);
            this.radGraduation.TabIndex = 2;
            this.radGraduation.TabStop = true;
            this.radGraduation.Text = "Graduation";
            this.radGraduation.UseVisualStyleBackColor = true;
            // 
            // radAnniversary
            // 
            this.radAnniversary.AutoSize = true;
            this.radAnniversary.Location = new System.Drawing.Point(12, 25);
            this.radAnniversary.Name = "radAnniversary";
            this.radAnniversary.Size = new System.Drawing.Size(109, 24);
            this.radAnniversary.TabIndex = 1;
            this.radAnniversary.TabStop = true;
            this.radAnniversary.Text = "Anniversary";
            this.radAnniversary.UseVisualStyleBackColor = true;
            // 
            // grpFlavour
            // 
            this.grpFlavour.Controls.Add(this.radBanana);
            this.grpFlavour.Controls.Add(this.radVanilla);
            this.grpFlavour.Controls.Add(this.radChocolate);
            this.grpFlavour.Location = new System.Drawing.Point(15, 25);
            this.grpFlavour.Name = "grpFlavour";
            this.grpFlavour.Size = new System.Drawing.Size(137, 122);
            this.grpFlavour.TabIndex = 6;
            this.grpFlavour.TabStop = false;
            this.grpFlavour.Text = "Flavour";
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(12, 92);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(83, 24);
            this.radBanana.TabIndex = 2;
            this.radBanana.TabStop = true;
            this.radBanana.Text = "Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            // 
            // radVanilla
            // 
            this.radVanilla.AutoSize = true;
            this.radVanilla.Location = new System.Drawing.Point(12, 57);
            this.radVanilla.Name = "radVanilla";
            this.radVanilla.Size = new System.Drawing.Size(74, 24);
            this.radVanilla.TabIndex = 1;
            this.radVanilla.TabStop = true;
            this.radVanilla.Text = "Vanilla";
            this.radVanilla.UseVisualStyleBackColor = true;
            // 
            // radChocolate
            // 
            this.radChocolate.AutoSize = true;
            this.radChocolate.Location = new System.Drawing.Point(12, 25);
            this.radChocolate.Name = "radChocolate";
            this.radChocolate.Size = new System.Drawing.Size(99, 24);
            this.radChocolate.TabIndex = 0;
            this.radChocolate.TabStop = true;
            this.radChocolate.Text = "Chocolate";
            this.radChocolate.UseVisualStyleBackColor = true;
            // 
            // grpCustomCake
            // 
            this.grpCustomCake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpCustomCake.Controls.Add(this.grpTiers);
            this.grpCustomCake.Controls.Add(this.grpOccasion);
            this.grpCustomCake.Controls.Add(this.grpFlavour);
            this.grpCustomCake.Enabled = false;
            this.grpCustomCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomCake.Location = new System.Drawing.Point(21, 183);
            this.grpCustomCake.Name = "grpCustomCake";
            this.grpCustomCake.Size = new System.Drawing.Size(459, 161);
            this.grpCustomCake.TabIndex = 20;
            this.grpCustomCake.TabStop = false;
            this.grpCustomCake.Text = "Custom Cake";
            // 
            // lstTraditional
            // 
            this.lstTraditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTraditional.FormattingEnabled = true;
            this.lstTraditional.ItemHeight = 20;
            this.lstTraditional.Items.AddRange(new object[] {
            "Strawberry Cheese Cake",
            "Blueberry Mousse",
            "Lemon Velvet Cake",
            "Tiramisu"});
            this.lstTraditional.Location = new System.Drawing.Point(277, 63);
            this.lstTraditional.Name = "lstTraditional";
            this.lstTraditional.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTraditional.Size = new System.Drawing.Size(203, 84);
            this.lstTraditional.TabIndex = 30;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 358);
            this.Controls.Add(this.lstTraditional);
            this.Controls.Add(this.lblTraditional);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpCustomCake);
            this.Name = "frmOrder";
            this.Text = "Mark Frando N01232785";
            this.Load += new System.EventHandler(this.frmCake_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpTiers.ResumeLayout(false);
            this.grpTiers.PerformLayout();
            this.grpOccasion.ResumeLayout(false);
            this.grpOccasion.PerformLayout();
            this.grpFlavour.ResumeLayout(false);
            this.grpFlavour.PerformLayout();
            this.grpCustomCake.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTraditional;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton radTraditional;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpTiers;
        private System.Windows.Forms.RadioButton radTier3;
        private System.Windows.Forms.RadioButton radTier2;
        private System.Windows.Forms.RadioButton radTier1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpOccasion;
        private System.Windows.Forms.RadioButton radWedding;
        private System.Windows.Forms.RadioButton radGraduation;
        private System.Windows.Forms.RadioButton radAnniversary;
        private System.Windows.Forms.GroupBox grpFlavour;
        private System.Windows.Forms.RadioButton radBanana;
        private System.Windows.Forms.RadioButton radVanilla;
        private System.Windows.Forms.RadioButton radChocolate;
        private System.Windows.Forms.GroupBox grpCustomCake;
        private System.Windows.Forms.ListBox lstTraditional;
    }
}

