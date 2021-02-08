namespace Unit_Converter
{
    partial class unitConverter
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
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.RadioButton();
            this.angle = new System.Windows.Forms.RadioButton();
            this.temperature = new System.Windows.Forms.RadioButton();
            this.length = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.toLable = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fromLable = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromComboBox
            // 
            this.fromComboBox.Location = new System.Drawing.Point(374, 140);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(336, 40);
            this.fromComboBox.TabIndex = 3;
            this.fromComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBox_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.weight);
            this.groupBox.Controls.Add(this.angle);
            this.groupBox.Controls.Add(this.temperature);
            this.groupBox.Controls.Add(this.length);
            this.groupBox.Location = new System.Drawing.Point(87, 150);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(285, 287);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Units:";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(27, 132);
            this.weight.Margin = new System.Windows.Forms.Padding(4);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(133, 36);
            this.weight.TabIndex = 4;
            this.weight.TabStop = true;
            this.weight.Text = "Weight";
            this.weight.UseVisualStyleBackColor = true;
            this.weight.CheckedChanged += new System.EventHandler(this.Weight_Checked);
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Location = new System.Drawing.Point(27, 176);
            this.angle.Margin = new System.Windows.Forms.Padding(4);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(115, 36);
            this.angle.TabIndex = 3;
            this.angle.TabStop = true;
            this.angle.Text = "Angle";
            this.angle.UseVisualStyleBackColor = true;
            this.angle.CheckedChanged += new System.EventHandler(this.angle_CheckedChanged);
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Location = new System.Drawing.Point(27, 220);
            this.temperature.Margin = new System.Windows.Forms.Padding(4);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(197, 36);
            this.temperature.TabIndex = 2;
            this.temperature.TabStop = true;
            this.temperature.Text = "Temperature";
            this.temperature.UseVisualStyleBackColor = true;
            this.temperature.CheckedChanged += new System.EventHandler(this.temperature_CheckedChanged);
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(27, 88);
            this.length.Margin = new System.Windows.Forms.Padding(4);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(129, 36);
            this.length.TabIndex = 1;
            this.length.TabStop = true;
            this.length.Text = "Length";
            this.length.UseVisualStyleBackColor = true;
            this.length.CheckedChanged += new System.EventHandler(this.Length_Checked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.toComboBox);
            this.panel1.Controls.Add(this.toLable);
            this.panel1.Controls.Add(this.toTextBox);
            this.panel1.Location = new System.Drawing.Point(500, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 189);
            this.panel1.TabIndex = 1;
            // 
            // toComboBox
            // 
            this.toComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toComboBox.Location = new System.Drawing.Point(374, 106);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(336, 40);
            this.toComboBox.TabIndex = 4;
            this.toComboBox.SelectedIndexChanged += new System.EventHandler(this.toComboBox_ItemSelected);
            // 
            // toLable
            // 
            this.toLable.AutoSize = true;
            this.toLable.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold);
            this.toLable.Location = new System.Drawing.Point(27, 50);
            this.toLable.Name = "toLable";
            this.toLable.Size = new System.Drawing.Size(48, 32);
            this.toLable.TabIndex = 2;
            this.toLable.Text = "To";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(33, 108);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(265, 38);
            this.toTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.fromComboBox);
            this.panel2.Controls.Add(this.fromLable);
            this.panel2.Controls.Add(this.fromTextBox);
            this.panel2.Location = new System.Drawing.Point(500, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 220);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // fromLable
            // 
            this.fromLable.AutoSize = true;
            this.fromLable.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold);
            this.fromLable.Location = new System.Drawing.Point(27, 52);
            this.fromLable.Name = "fromLable";
            this.fromLable.Size = new System.Drawing.Size(86, 32);
            this.fromLable.TabIndex = 1;
            this.fromLable.Text = "From";
            // 
            // fromTextBox
            // 
            this.fromTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromTextBox.Location = new System.Drawing.Point(33, 140);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(265, 38);
            this.fromTextBox.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.IndianRed;
            this.closeButton.Location = new System.Drawing.Point(794, 613);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(170, 77);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // unitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1395, 755);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "unitConverter";
            this.Text = "UNIT CONVERTER";
            this.Load += new System.EventHandler(this.unitConverter_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton weight;
        private System.Windows.Forms.RadioButton angle;
        private System.Windows.Forms.RadioButton temperature;
        private System.Windows.Forms.RadioButton length;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.Label toLable;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label fromLable;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.ComboBox fromComboBox;
    }
}

