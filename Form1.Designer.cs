
namespace Materials_List_Estimation
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.flooringBtn = new System.Windows.Forms.CheckBox();
            this.wallsBtn = new System.Windows.Forms.CheckBox();
            this.openingsBtn = new System.Windows.Forms.CheckBox();
            this.roofBtn = new System.Windows.Forms.CheckBox();
            this.otherItemsBtn = new System.Windows.Forms.CheckBox();

            this.saveBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();

            this.listCategory = new System.Windows.Forms.ListBox();

            this.groupBoxFlooring = new System.Windows.Forms.GroupBox();
            this.groupBoxWalls = new System.Windows.Forms.GroupBox();
            this.groupBoxOpenings = new System.Windows.Forms.GroupBox();
            this.groupBoxRoof = new System.Windows.Forms.GroupBox();
            this.groupBoxOtherItems = new System.Windows.Forms.GroupBox();

            this.SuspendLayout();

            // 
            // flooringBtn
            // 
            this.flooringBtn.AutoSize = true;
            this.flooringBtn.Location = new System.Drawing.Point(38, 112);
            this.flooringBtn.Name = "flooringBtn";
            this.flooringBtn.Size = new System.Drawing.Size(63, 17);
            this.flooringBtn.TabIndex = 0;
            this.flooringBtn.Text = "Flooring";
            this.flooringBtn.UseVisualStyleBackColor = true;
            // 
            // wallsBtn
            // 
            this.wallsBtn.AutoSize = true;
            this.wallsBtn.Location = new System.Drawing.Point(38, 135);
            this.wallsBtn.Name = "wallsBtn";
            this.wallsBtn.Size = new System.Drawing.Size(52, 17);
            this.wallsBtn.TabIndex = 1;
            this.wallsBtn.Text = "Walls";
            this.wallsBtn.UseVisualStyleBackColor = true;
            // 
            // openingsBtn
            // 
            this.openingsBtn.AutoSize = true;
            this.openingsBtn.Location = new System.Drawing.Point(38, 158);
            this.openingsBtn.Name = "openingsBtn";
            this.openingsBtn.Size = new System.Drawing.Size(71, 17);
            this.openingsBtn.TabIndex = 2;
            this.openingsBtn.Text = "Openings";
            this.openingsBtn.UseVisualStyleBackColor = true;
            // 
            // roofBtn
            // 
            this.roofBtn.AutoSize = true;
            this.roofBtn.Location = new System.Drawing.Point(38, 181);
            this.roofBtn.Name = "roofBtn";
            this.roofBtn.Size = new System.Drawing.Size(49, 17);
            this.roofBtn.TabIndex = 3;
            this.roofBtn.Text = "Roof";
            this.roofBtn.UseVisualStyleBackColor = true;
            // 
            // otherItemsBtn
            // 
            this.otherItemsBtn.AutoSize = true;
            this.otherItemsBtn.Location = new System.Drawing.Point(38, 204);
            this.otherItemsBtn.Name = "otherItemsBtn";
            this.otherItemsBtn.Size = new System.Drawing.Size(80, 17);
            this.otherItemsBtn.TabIndex = 12;
            this.otherItemsBtn.Text = "Other Items";
            this.otherItemsBtn.UseVisualStyleBackColor = true;

            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(38, 472);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(114, 44);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(173, 472);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(114, 44);
            this.exportBtn.TabIndex = 7;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(310, 472);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(114, 44);
            this.newBtn.TabIndex = 8;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(444, 472);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(114, 44);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);

            // 
            // listCategory
            // 
            this.listCategory.FormattingEnabled = true;
            this.listCategory.Items.AddRange(new object[] {
            "Flooring",
            "Walls",
            "Openings",
            "Roof",
            "Other Items"});
            this.listCategory.Location = new System.Drawing.Point(159, 37);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(399, 69);
            this.listCategory.TabIndex = 10;
            this.listCategory.SelectedIndexChanged += new System.EventHandler(this.listCategory_SelectedIndexChanged);

            // 
            // groupBoxFlooring
            // 
            this.groupBoxFlooring.Location = new System.Drawing.Point(159, 112);
            this.groupBoxFlooring.Name = "groupBoxFlooring";
            this.groupBoxFlooring.Size = new System.Drawing.Size(399, 69);
            this.groupBoxFlooring.TabIndex = 4;
            this.groupBoxFlooring.TabStop = false;
            this.groupBoxFlooring.Text = "Estimating List - Flooring";
            // 
            // groupBoxWalls
            // 
            this.groupBoxWalls.Location = new System.Drawing.Point(159, 186);
            this.groupBoxWalls.Name = "groupBoxWalls";
            this.groupBoxWalls.Size = new System.Drawing.Size(399, 63);
            this.groupBoxWalls.TabIndex = 5;
            this.groupBoxWalls.TabStop = false;
            this.groupBoxWalls.Text = "Estimating List - Walls";
            // 
            // groupBoxOpenings
            // 
            this.groupBoxOpenings.Location = new System.Drawing.Point(159, 255);
            this.groupBoxOpenings.Name = "groupBoxOpenings";
            this.groupBoxOpenings.Size = new System.Drawing.Size(399, 64);
            this.groupBoxOpenings.TabIndex = 6;
            this.groupBoxOpenings.TabStop = false;
            this.groupBoxOpenings.Text = "Estimating List - Openings";
            // 
            // groupBoxRoof
            // 
            this.groupBoxRoof.Location = new System.Drawing.Point(159, 325);
            this.groupBoxRoof.Name = "groupBoxRoof";
            this.groupBoxRoof.Size = new System.Drawing.Size(399, 67);
            this.groupBoxRoof.TabIndex = 6;
            this.groupBoxRoof.TabStop = false;
            this.groupBoxRoof.Text = "Estimating List - Roof";
            // 
            // groupBoxOtherItems
            // 
            this.groupBoxOtherItems.Location = new System.Drawing.Point(159, 398);
            this.groupBoxOtherItems.Name = "groupBoxOtherItems";
            this.groupBoxOtherItems.Size = new System.Drawing.Size(399, 68);
            this.groupBoxOtherItems.TabIndex = 11;
            this.groupBoxOtherItems.TabStop = false;
            this.groupBoxOtherItems.Text = "Estimating List - Other Items";

            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 722);
            this.Controls.Add(this.otherItemsBtn);
            this.Controls.Add(this.flooringBtn);
            this.Controls.Add(this.wallsBtn);
            this.Controls.Add(this.openingsBtn);
            this.Controls.Add(this.roofBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBoxFlooring);
            this.Controls.Add(this.groupBoxWalls);
            this.Controls.Add(this.groupBoxOpenings);
            this.Controls.Add(this.groupBoxRoof);
            this.Controls.Add(this.groupBoxOtherItems);
            this.Controls.Add(this.listCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Estimator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox flooringBtn;
        private System.Windows.Forms.CheckBox wallsBtn;
        private System.Windows.Forms.CheckBox openingsBtn;
        private System.Windows.Forms.CheckBox roofBtn;
        private System.Windows.Forms.CheckBox otherItemsBtn;

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button exitBtn;

        private System.Windows.Forms.ListBox listCategory;
        private System.Windows.Forms.GroupBox groupBoxFlooring;
        private System.Windows.Forms.GroupBox groupBoxWalls;
        private System.Windows.Forms.GroupBox groupBoxOpenings;
        private System.Windows.Forms.GroupBox groupBoxRoof;
        private System.Windows.Forms.GroupBox groupBoxOtherItems;
    }
}

