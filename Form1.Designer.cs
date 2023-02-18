
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
            this.roofBtn = new System.Windows.Forms.CheckBox();
            this.openingsBtn = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(159, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 343);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // categoryList
            // 
            this.categoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(159, 60);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(399, 21);
            this.categoryList.TabIndex = 5;
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 552);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.roofBtn);
            this.Controls.Add(this.openingsBtn);
            this.Controls.Add(this.wallsBtn);
            this.Controls.Add(this.flooringBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Material Estimator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox flooringBtn;
        private System.Windows.Forms.CheckBox wallsBtn;
        private System.Windows.Forms.CheckBox roofBtn;
        private System.Windows.Forms.CheckBox openingsBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

