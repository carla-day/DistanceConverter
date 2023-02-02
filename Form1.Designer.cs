namespace Distance_Converted
{
    partial class Form1
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
            this.promptDescription = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.convertedDistanceDescription = new System.Windows.Forms.Label();
            this.convertedDistance = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptDescription
            // 
            this.promptDescription.AutoSize = true;
            this.promptDescription.Location = new System.Drawing.Point(148, 96);
            this.promptDescription.Name = "promptDescription";
            this.promptDescription.Size = new System.Drawing.Size(275, 25);
            this.promptDescription.TabIndex = 0;
            this.promptDescription.Text = "Enter a distance to convert:";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(472, 90);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(250, 31);
            this.distanceTextBox.TabIndex = 1;
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromListBox);
            this.fromGroupBox.Location = new System.Drawing.Point(153, 142);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(254, 254);
            this.fromGroupBox.TabIndex = 2;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From";
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.ItemHeight = 25;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(28, 93);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(185, 104);
            this.fromListBox.TabIndex = 0;
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.toListBox);
            this.toGroupBox.Location = new System.Drawing.Point(472, 142);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(254, 254);
            this.toGroupBox.TabIndex = 3;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.ItemHeight = 25;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(31, 93);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(185, 104);
            this.toListBox.TabIndex = 1;
            // 
            // convertedDistanceDescription
            // 
            this.convertedDistanceDescription.AutoSize = true;
            this.convertedDistanceDescription.Location = new System.Drawing.Point(249, 430);
            this.convertedDistanceDescription.Name = "convertedDistanceDescription";
            this.convertedDistanceDescription.Size = new System.Drawing.Size(207, 25);
            this.convertedDistanceDescription.TabIndex = 4;
            this.convertedDistanceDescription.Text = "Converted Distance:";
            // 
            // convertedDistance
            // 
            this.convertedDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedDistance.Location = new System.Drawing.Point(488, 423);
            this.convertedDistance.Name = "convertedDistance";
            this.convertedDistance.Size = new System.Drawing.Size(200, 50);
            this.convertedDistance.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(276, 510);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(180, 43);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(488, 510);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 43);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 636);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedDistance);
            this.Controls.Add(this.convertedDistanceDescription);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.fromGroupBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.promptDescription);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.fromGroupBox.ResumeLayout(false);
            this.toGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptDescription;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Label convertedDistanceDescription;
        private System.Windows.Forms.Label convertedDistance;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

