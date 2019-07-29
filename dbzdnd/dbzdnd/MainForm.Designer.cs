namespace dbzdnd
{
    partial class MainForm
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.cbInventory = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnAmountAdd = new System.Windows.Forms.Button();
            this.btnAmountMinus = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cbEquipment = new System.Windows.Forms.ComboBox();
            this.cbEquipmentStatChanged = new System.Windows.Forms.ComboBox();
            this.nudEquipmentStatValue = new System.Windows.Forms.NumericUpDown();
            this.InventoryGroup = new System.Windows.Forms.GroupBox();
            this.PlayerGroup = new System.Windows.Forms.GroupBox();
            this.lblPowerLevel = new System.Windows.Forms.Label();
            this.tabStrengthTop = new System.Windows.Forms.TabControl();
            this.tabStrength = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.StatsGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipmentStatValue)).BeginInit();
            this.InventoryGroup.SuspendLayout();
            this.PlayerGroup.SuspendLayout();
            this.tabStrengthTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.StatsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(6, 44);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(124, 23);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Player Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.PlayerInfo_Click);
            // 
            // cbInventory
            // 
            this.cbInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInventory.FormattingEnabled = true;
            this.cbInventory.Items.AddRange(new object[] {
            "Recovery Pills",
            "Stamina Pills",
            "Credits",
            "Add"});
            this.cbInventory.Location = new System.Drawing.Point(6, 19);
            this.cbInventory.Name = "cbInventory";
            this.cbInventory.Size = new System.Drawing.Size(346, 28);
            this.cbInventory.TabIndex = 4;
            this.cbInventory.Text = "Inventory";
            this.cbInventory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblName.Location = new System.Drawing.Point(1, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "PlayerName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dbzdnd.Properties.Resources.CharacterPic;
            this.pictureBox1.Location = new System.Drawing.Point(387, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nudLevel
            // 
            this.nudLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.Location = new System.Drawing.Point(54, 71);
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(159, 22);
            this.nudLevel.TabIndex = 6;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(2, 70);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 20);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "Level";
            // 
            // btnAmountAdd
            // 
            this.btnAmountAdd.Location = new System.Drawing.Point(290, 53);
            this.btnAmountAdd.Name = "btnAmountAdd";
            this.btnAmountAdd.Size = new System.Drawing.Size(28, 28);
            this.btnAmountAdd.TabIndex = 9;
            this.btnAmountAdd.Text = "+";
            this.btnAmountAdd.UseVisualStyleBackColor = true;
            // 
            // btnAmountMinus
            // 
            this.btnAmountMinus.Location = new System.Drawing.Point(324, 53);
            this.btnAmountMinus.Name = "btnAmountMinus";
            this.btnAmountMinus.Size = new System.Drawing.Size(28, 28);
            this.btnAmountMinus.TabIndex = 10;
            this.btnAmountMinus.Text = "-";
            this.btnAmountMinus.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(2, 56);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 20);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Amount:";
            // 
            // cbEquipment
            // 
            this.cbEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEquipment.FormattingEnabled = true;
            this.cbEquipment.Items.AddRange(new object[] {
            "add"});
            this.cbEquipment.Location = new System.Drawing.Point(6, 87);
            this.cbEquipment.Name = "cbEquipment";
            this.cbEquipment.Size = new System.Drawing.Size(346, 28);
            this.cbEquipment.TabIndex = 12;
            this.cbEquipment.Text = "Equipment";
            // 
            // cbEquipmentStatChanged
            // 
            this.cbEquipmentStatChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEquipmentStatChanged.FormattingEnabled = true;
            this.cbEquipmentStatChanged.Items.AddRange(new object[] {
            "add"});
            this.cbEquipmentStatChanged.Location = new System.Drawing.Point(6, 121);
            this.cbEquipmentStatChanged.Name = "cbEquipmentStatChanged";
            this.cbEquipmentStatChanged.Size = new System.Drawing.Size(250, 28);
            this.cbEquipmentStatChanged.TabIndex = 13;
            this.cbEquipmentStatChanged.Text = "Stat Changed";
            // 
            // nudEquipmentStatValue
            // 
            this.nudEquipmentStatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudEquipmentStatValue.Location = new System.Drawing.Point(262, 123);
            this.nudEquipmentStatValue.Name = "nudEquipmentStatValue";
            this.nudEquipmentStatValue.Size = new System.Drawing.Size(90, 26);
            this.nudEquipmentStatValue.TabIndex = 14;
            // 
            // InventoryGroup
            // 
            this.InventoryGroup.Controls.Add(this.cbInventory);
            this.InventoryGroup.Controls.Add(this.nudEquipmentStatValue);
            this.InventoryGroup.Controls.Add(this.btnAmountAdd);
            this.InventoryGroup.Controls.Add(this.cbEquipmentStatChanged);
            this.InventoryGroup.Controls.Add(this.btnAmountMinus);
            this.InventoryGroup.Controls.Add(this.cbEquipment);
            this.InventoryGroup.Controls.Add(this.lblAmount);
            this.InventoryGroup.Location = new System.Drawing.Point(12, 149);
            this.InventoryGroup.Name = "InventoryGroup";
            this.InventoryGroup.Size = new System.Drawing.Size(358, 161);
            this.InventoryGroup.TabIndex = 15;
            this.InventoryGroup.TabStop = false;
            this.InventoryGroup.Text = "Inventory";
            // 
            // PlayerGroup
            // 
            this.PlayerGroup.Controls.Add(this.lblPowerLevel);
            this.PlayerGroup.Controls.Add(this.lblName);
            this.PlayerGroup.Controls.Add(this.btnInfo);
            this.PlayerGroup.Controls.Add(this.lblLevel);
            this.PlayerGroup.Controls.Add(this.nudLevel);
            this.PlayerGroup.Location = new System.Drawing.Point(12, 12);
            this.PlayerGroup.Name = "PlayerGroup";
            this.PlayerGroup.Size = new System.Drawing.Size(358, 131);
            this.PlayerGroup.TabIndex = 16;
            this.PlayerGroup.TabStop = false;
            this.PlayerGroup.Text = "Player";
            // 
            // lblPowerLevel
            // 
            this.lblPowerLevel.AutoSize = true;
            this.lblPowerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPowerLevel.Location = new System.Drawing.Point(2, 96);
            this.lblPowerLevel.Name = "lblPowerLevel";
            this.lblPowerLevel.Size = new System.Drawing.Size(98, 20);
            this.lblPowerLevel.TabIndex = 8;
            this.lblPowerLevel.Text = "Power Level:";
            // 
            // tabStrengthTop
            // 
            this.tabStrengthTop.Controls.Add(this.tabStrength);
            this.tabStrengthTop.Controls.Add(this.tabPage2);
            this.tabStrengthTop.Controls.Add(this.tabPage3);
            this.tabStrengthTop.Controls.Add(this.tabPage4);
            this.tabStrengthTop.Controls.Add(this.tabPage5);
            this.tabStrengthTop.Controls.Add(this.tabPage6);
            this.tabStrengthTop.Location = new System.Drawing.Point(3, 45);
            this.tabStrengthTop.Name = "tabStrengthTop";
            this.tabStrengthTop.SelectedIndex = 0;
            this.tabStrengthTop.Size = new System.Drawing.Size(349, 175);
            this.tabStrengthTop.TabIndex = 17;
            // 
            // tabStrength
            // 
            this.tabStrength.Location = new System.Drawing.Point(4, 22);
            this.tabStrength.Name = "tabStrength";
            this.tabStrength.Padding = new System.Windows.Forms.Padding(3);
            this.tabStrength.Size = new System.Drawing.Size(341, 149);
            this.tabStrength.TabIndex = 0;
            this.tabStrength.Text = "STR";
            this.tabStrength.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(341, 149);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CON";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(341, 149);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "INT";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(341, 149);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "WISD";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(341, 149);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "CHAR";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DEX";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(89, 16);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 21);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Stat Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Spec Points";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(293, 16);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(59, 21);
            this.numericUpDown2.TabIndex = 20;
            // 
            // StatsGroup
            // 
            this.StatsGroup.Controls.Add(this.label1);
            this.StatsGroup.Controls.Add(this.label2);
            this.StatsGroup.Controls.Add(this.tabStrengthTop);
            this.StatsGroup.Controls.Add(this.numericUpDown2);
            this.StatsGroup.Controls.Add(this.numericUpDown1);
            this.StatsGroup.Location = new System.Drawing.Point(12, 316);
            this.StatsGroup.Name = "StatsGroup";
            this.StatsGroup.Size = new System.Drawing.Size(358, 226);
            this.StatsGroup.TabIndex = 22;
            this.StatsGroup.TabStop = false;
            this.StatsGroup.Text = "Stats";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 554);
            this.Controls.Add(this.StatsGroup);
            this.Controls.Add(this.PlayerGroup);
            this.Controls.Add(this.InventoryGroup);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "PlayerName";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipmentStatValue)).EndInit();
            this.InventoryGroup.ResumeLayout(false);
            this.InventoryGroup.PerformLayout();
            this.PlayerGroup.ResumeLayout(false);
            this.PlayerGroup.PerformLayout();
            this.tabStrengthTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.StatsGroup.ResumeLayout(false);
            this.StatsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbInventory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnAmountAdd;
        private System.Windows.Forms.Button btnAmountMinus;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cbEquipment;
        private System.Windows.Forms.ComboBox cbEquipmentStatChanged;
        private System.Windows.Forms.NumericUpDown nudEquipmentStatValue;
        private System.Windows.Forms.GroupBox InventoryGroup;
        private System.Windows.Forms.GroupBox PlayerGroup;
        private System.Windows.Forms.Label lblPowerLevel;
        private System.Windows.Forms.TabControl tabStrengthTop;
        private System.Windows.Forms.TabPage tabStrength;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox StatsGroup;
    }
}

