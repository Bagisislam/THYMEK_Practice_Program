namespace İnterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Open_List_Button = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            checkBox4 = new CheckBox();
            Switchitems_Button = new CheckBox();
            ShowAnswers_Button = new CheckBox();
            EditButton = new Button();
            Random_Checkbox = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Open_List_Button
            // 
            Open_List_Button.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Open_List_Button.Location = new Point(29, 32);
            Open_List_Button.Name = "Open_List_Button";
            Open_List_Button.Size = new Size(322, 59);
            Open_List_Button.TabIndex = 1;
            Open_List_Button.Text = "Open And Edit List";
            Open_List_Button.UseVisualStyleBackColor = true;
            Open_List_Button.Click += Open_List_Button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(Switchitems_Button);
            groupBox1.Controls.Add(ShowAnswers_Button);
            groupBox1.Controls.Add(EditButton);
            groupBox1.Controls.Add(Random_Checkbox);
            groupBox1.Location = new Point(566, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 175);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(656, 125);
            label2.Name = "label2";
            label2.Size = new Size(42, 26);
            label2.TabIndex = 7;
            label2.Text = "SN";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 121);
            label1.Name = "label1";
            label1.Size = new Size(158, 26);
            label1.TabIndex = 6;
            label1.Text = "DURATION : ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(569, 119);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(77, 35);
            numericUpDown1.TabIndex = 5;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.CheckAlign = ContentAlignment.MiddleRight;
            checkBox4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(170, 121);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(183, 30);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "AUTO SLİDE";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Switchitems_Button
            // 
            Switchitems_Button.AutoSize = true;
            Switchitems_Button.CheckAlign = ContentAlignment.MiddleRight;
            Switchitems_Button.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Switchitems_Button.Location = new Point(482, 39);
            Switchitems_Button.Name = "Switchitems_Button";
            Switchitems_Button.Size = new Size(216, 30);
            Switchitems_Button.TabIndex = 3;
            Switchitems_Button.Text = "SWITCH ITEMS";
            Switchitems_Button.UseVisualStyleBackColor = true;
            // 
            // ShowAnswers_Button
            // 
            ShowAnswers_Button.AutoSize = true;
            ShowAnswers_Button.CheckAlign = ContentAlignment.MiddleRight;
            ShowAnswers_Button.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowAnswers_Button.Location = new Point(223, 39);
            ShowAnswers_Button.Name = "ShowAnswers_Button";
            ShowAnswers_Button.Size = new Size(233, 30);
            ShowAnswers_Button.TabIndex = 2;
            ShowAnswers_Button.Text = "SHOW ANSWERS";
            ShowAnswers_Button.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditButton.Location = new Point(23, 121);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(112, 34);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // Random_Checkbox
            // 
            Random_Checkbox.AutoSize = true;
            Random_Checkbox.CheckAlign = ContentAlignment.MiddleRight;
            Random_Checkbox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Random_Checkbox.Location = new Point(45, 39);
            Random_Checkbox.Name = "Random_Checkbox";
            Random_Checkbox.Size = new Size(148, 30);
            Random_Checkbox.TabIndex = 0;
            Random_Checkbox.Text = "RANDOM";
            Random_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1872, 883);
            Controls.Add(groupBox1);
            Controls.Add(Open_List_Button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Open_List_Button;
        private GroupBox groupBox1;
        private CheckBox Random_Checkbox;
        private CheckBox checkBox4;
        private CheckBox Switchitems_Button;
        private CheckBox ShowAnswers_Button;
        private Button EditButton;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
    }
}
