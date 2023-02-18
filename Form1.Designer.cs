
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
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.groupBoxGeneral.SuspendLayout();
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
            this.flooringBtn.CheckedChanged += new System.EventHandler(this.flooringBtn_CheckedChanged);
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
            this.wallsBtn.CheckedChanged += new System.EventHandler(this.wallsBtn_CheckedChanged);
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
            this.openingsBtn.CheckedChanged += new System.EventHandler(this.openingsBtn_CheckedChanged);
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
            this.roofBtn.CheckedChanged += new System.EventHandler(this.roofBtn_CheckedChanged);
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
            this.otherItemsBtn.CheckedChanged += new System.EventHandler(this.otherItemsBtn_CheckedChanged);
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
            "General"});
            this.listCategory.Location = new System.Drawing.Point(159, 50);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(399, 56);
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
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.label5);
            this.groupBoxGeneral.Controls.Add(this.listBox1);
            this.groupBoxGeneral.Controls.Add(this.label4);
            this.groupBoxGeneral.Controls.Add(this.textBox3);
            this.groupBoxGeneral.Controls.Add(this.label3);
            this.groupBoxGeneral.Controls.Add(this.textBox2);
            this.groupBoxGeneral.Controls.Add(this.label2);
            this.groupBoxGeneral.Controls.Add(this.textBox1);
            this.groupBoxGeneral.Controls.Add(this.label1);
            this.groupBoxGeneral.Controls.Add(this.txtProjectName);
            this.groupBoxGeneral.Location = new System.Drawing.Point(582, 50);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(399, 354);
            this.groupBoxGeneral.TabIndex = 5;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General Info";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(273, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "State";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "MP",
            "OH",
            "OK",
            "OR",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "VI",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.listBox1.Location = new System.Drawing.Point(332, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(46, 17);
            this.listBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "City";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Manager";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(108, 33);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(270, 20);
            this.txtProjectName.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 722);
            this.Controls.Add(this.groupBoxGeneral);
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
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

