namespace ZooSim.Main
{
    partial class frmMain
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Group", System.Windows.Forms.HorizontalAlignment.Left);
            this.lstEnclosures = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblZooName = new System.Windows.Forms.Label();
            this.btnFeedAnimals = new System.Windows.Forms.Button();
            this.animalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.animalHealth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deadOrAlive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lblSimTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEnclosures
            // 
            this.lstEnclosures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.animalName,
            this.animalHealth,
            this.deadOrAlive});
            listViewGroup1.Header = "Group";
            listViewGroup1.Name = "animalType";
            this.lstEnclosures.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lstEnclosures.HideSelection = false;
            this.lstEnclosures.Location = new System.Drawing.Point(12, 12);
            this.lstEnclosures.Name = "lstEnclosures";
            this.lstEnclosures.Size = new System.Drawing.Size(540, 426);
            this.lstEnclosures.TabIndex = 0;
            this.lstEnclosures.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSimTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFeedAnimals);
            this.groupBox1.Location = new System.Drawing.Point(559, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zoo Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to: ";
            // 
            // lblZooName
            // 
            this.lblZooName.AutoSize = true;
            this.lblZooName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZooName.Location = new System.Drawing.Point(562, 33);
            this.lblZooName.Name = "lblZooName";
            this.lblZooName.Size = new System.Drawing.Size(133, 16);
            this.lblZooName.TabIndex = 3;
            this.lblZooName.Text = "Default Zoo Name";
            // 
            // btnFeedAnimals
            // 
            this.btnFeedAnimals.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnFeedAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedAnimals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFeedAnimals.Location = new System.Drawing.Point(6, 309);
            this.btnFeedAnimals.Name = "btnFeedAnimals";
            this.btnFeedAnimals.Size = new System.Drawing.Size(217, 64);
            this.btnFeedAnimals.TabIndex = 0;
            this.btnFeedAnimals.Text = "Feed Animals";
            this.btnFeedAnimals.UseVisualStyleBackColor = false;
            this.btnFeedAnimals.Click += new System.EventHandler(this.btnFeedAnimals_Click);
            // 
            // animalName
            // 
            this.animalName.Text = "Animal Name";
            this.animalName.Width = 120;
            // 
            // animalHealth
            // 
            this.animalHealth.Text = "Animal Health";
            this.animalHealth.Width = 120;
            // 
            // deadOrAlive
            // 
            this.deadOrAlive.Text = "Animal Mortality";
            this.deadOrAlive.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Sim Time:";
            // 
            // lblSimTime
            // 
            this.lblSimTime.AutoSize = true;
            this.lblSimTime.Location = new System.Drawing.Point(104, 19);
            this.lblSimTime.Name = "lblSimTime";
            this.lblSimTime.Size = new System.Drawing.Size(57, 13);
            this.lblSimTime.TabIndex = 2;
            this.lblSimTime.Text = "lblSimTime";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblZooName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstEnclosures);
            this.Name = "frmMain";
            this.Text = "ZooSim 2020 - By Derek Hampton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstEnclosures;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblZooName;
        private System.Windows.Forms.Button btnFeedAnimals;
        private System.Windows.Forms.ColumnHeader animalName;
        private System.Windows.Forms.ColumnHeader animalHealth;
        private System.Windows.Forms.ColumnHeader deadOrAlive;
        private System.Windows.Forms.Label lblSimTime;
        private System.Windows.Forms.Label label2;
    }
}

