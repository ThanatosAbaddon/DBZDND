namespace dbzdnd
{
    partial class addValues
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.lblMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(494, 131);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(150, 44);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // nudValue
            // 
            this.nudValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValue.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudValue.Location = new System.Drawing.Point(24, 69);
            this.nudValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudValue.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(620, 44);
            this.nudValue.TabIndex = 1;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(24, 25);
            this.lblMain.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(447, 37);
            this.lblMain.TabIndex = 2;
            this.lblMain.Text = "How many A do you want to B";
            // 
            // addValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 190);
            this.ControlBox = false;
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.btnAccept);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "addValues";
            this.Text = "addValues";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label lblMain;
    }
}