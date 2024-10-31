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
            components = new System.ComponentModel.Container();
            Open_List_Button = new Button();
            groupBox1 = new GroupBox();
            Start_Button = new Button();
            AutoSliderGroup = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            AutoSlide_Checkbox = new CheckBox();
            TimeNumber = new NumericUpDown();
            Switchitems_Checkbox = new CheckBox();
            ShowAnswers_Checkbox = new CheckBox();
            EditButton = new Button();
            Random_Checkbox = new CheckBox();
            Reveal_Button = new Button();
            Next_Button = new Button();
            Name_Lable = new Label();
            Number_Label = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            groupBox1.SuspendLayout();
            AutoSliderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TimeNumber).BeginInit();
            SuspendLayout();
            // 
            // Open_List_Button
            // 
            Open_List_Button.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Open_List_Button.Location = new Point(56, 44);
            Open_List_Button.Name = "Open_List_Button";
            Open_List_Button.Size = new Size(322, 59);
            Open_List_Button.TabIndex = 1;
            Open_List_Button.Text = "Open And Edit List";
            Open_List_Button.UseVisualStyleBackColor = true;
            Open_List_Button.Click += Open_List_Button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Start_Button);
            groupBox1.Controls.Add(AutoSliderGroup);
            groupBox1.Controls.Add(Switchitems_Checkbox);
            groupBox1.Controls.Add(ShowAnswers_Checkbox);
            groupBox1.Controls.Add(EditButton);
            groupBox1.Controls.Add(Random_Checkbox);
            groupBox1.Location = new Point(528, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 244);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // Start_Button
            // 
            Start_Button.BackColor = SystemColors.MenuHighlight;
            Start_Button.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Start_Button.Location = new Point(22, 165);
            Start_Button.Name = "Start_Button";
            Start_Button.Size = new Size(148, 62);
            Start_Button.TabIndex = 8;
            Start_Button.Text = "Start From The Beginning";
            Start_Button.UseVisualStyleBackColor = false;
            Start_Button.Click += Start_Button_Click;
            // 
            // AutoSliderGroup
            // 
            AutoSliderGroup.BackColor = SystemColors.ControlLight;
            AutoSliderGroup.Controls.Add(label2);
            AutoSliderGroup.Controls.Add(label1);
            AutoSliderGroup.Controls.Add(AutoSlide_Checkbox);
            AutoSliderGroup.Controls.Add(TimeNumber);
            AutoSliderGroup.Location = new Point(185, 116);
            AutoSliderGroup.Name = "AutoSliderGroup";
            AutoSliderGroup.Size = new Size(549, 90);
            AutoSliderGroup.TabIndex = 7;
            AutoSliderGroup.TabStop = false;
            AutoSliderGroup.Text = "AutoSliderGroup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(492, 43);
            label2.Name = "label2";
            label2.Size = new Size(42, 26);
            label2.TabIndex = 7;
            label2.Text = "SN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 43);
            label1.Name = "label1";
            label1.Size = new Size(158, 26);
            label1.TabIndex = 6;
            label1.Text = "DURATION : ";
            // 
            // AutoSlide_Checkbox
            // 
            AutoSlide_Checkbox.AutoSize = true;
            AutoSlide_Checkbox.CheckAlign = ContentAlignment.MiddleRight;
            AutoSlide_Checkbox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AutoSlide_Checkbox.Location = new Point(27, 43);
            AutoSlide_Checkbox.Name = "AutoSlide_Checkbox";
            AutoSlide_Checkbox.Size = new Size(183, 30);
            AutoSlide_Checkbox.TabIndex = 4;
            AutoSlide_Checkbox.Text = "AUTO SLİDE";
            AutoSlide_Checkbox.UseVisualStyleBackColor = true;
            // 
            // TimeNumber
            // 
            TimeNumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimeNumber.Location = new Point(405, 37);
            TimeNumber.Name = "TimeNumber";
            TimeNumber.Size = new Size(77, 35);
            TimeNumber.TabIndex = 5;
            // 
            // Switchitems_Checkbox
            // 
            Switchitems_Checkbox.AutoSize = true;
            Switchitems_Checkbox.CheckAlign = ContentAlignment.MiddleRight;
            Switchitems_Checkbox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Switchitems_Checkbox.Location = new Point(482, 39);
            Switchitems_Checkbox.Name = "Switchitems_Checkbox";
            Switchitems_Checkbox.Size = new Size(216, 30);
            Switchitems_Checkbox.TabIndex = 3;
            Switchitems_Checkbox.Text = "SWITCH ITEMS";
            Switchitems_Checkbox.UseVisualStyleBackColor = true;
            // 
            // ShowAnswers_Checkbox
            // 
            ShowAnswers_Checkbox.AutoSize = true;
            ShowAnswers_Checkbox.CheckAlign = ContentAlignment.MiddleRight;
            ShowAnswers_Checkbox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowAnswers_Checkbox.Location = new Point(223, 39);
            ShowAnswers_Checkbox.Name = "ShowAnswers_Checkbox";
            ShowAnswers_Checkbox.Size = new Size(233, 30);
            ShowAnswers_Checkbox.TabIndex = 2;
            ShowAnswers_Checkbox.Text = "SHOW ANSWERS";
            ShowAnswers_Checkbox.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.BackColor = SystemColors.AppWorkspace;
            EditButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditButton.ForeColor = SystemColors.HotTrack;
            EditButton.Location = new Point(22, 75);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(148, 84);
            EditButton.TabIndex = 1;
            EditButton.Text = "Save Changes";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click_1;
            // 
            // Random_Checkbox
            // 
            Random_Checkbox.AutoSize = true;
            Random_Checkbox.CheckAlign = ContentAlignment.MiddleRight;
            Random_Checkbox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Random_Checkbox.Location = new Point(22, 39);
            Random_Checkbox.Name = "Random_Checkbox";
            Random_Checkbox.Size = new Size(148, 30);
            Random_Checkbox.TabIndex = 0;
            Random_Checkbox.Text = "RANDOM";
            Random_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Reveal_Button
            // 
            Reveal_Button.BackColor = SystemColors.Highlight;
            Reveal_Button.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reveal_Button.Location = new Point(876, 608);
            Reveal_Button.Name = "Reveal_Button";
            Reveal_Button.Size = new Size(124, 41);
            Reveal_Button.TabIndex = 5;
            Reveal_Button.Text = "Reveal";
            Reveal_Button.UseVisualStyleBackColor = false;
            Reveal_Button.Click += Reveal_Button_Click_1;
            // 
            // Next_Button
            // 
            Next_Button.BackColor = SystemColors.Info;
            Next_Button.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Next_Button.Location = new Point(775, 690);
            Next_Button.Name = "Next_Button";
            Next_Button.Size = new Size(322, 115);
            Next_Button.TabIndex = 6;
            Next_Button.Text = "Next";
            Next_Button.UseVisualStyleBackColor = false;
            Next_Button.Click += Next_Button_Click;
            // 
            // Name_Lable
            // 
            Name_Lable.BackColor = SystemColors.ScrollBar;
            Name_Lable.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_Lable.Location = new Point(713, 275);
            Name_Lable.Name = "Name_Lable";
            Name_Lable.Size = new Size(439, 131);
            Name_Lable.TabIndex = 7;
            Name_Lable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Number_Label
            // 
            Number_Label.BackColor = SystemColors.InactiveCaption;
            Number_Label.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Number_Label.Location = new Point(713, 434);
            Number_Label.Name = "Number_Label";
            Number_Label.Size = new Size(439, 130);
            Number_Label.TabIndex = 8;
            Number_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(1749, 853);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 9;
            label3.Text = "Made By Islam";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1872, 883);
            Controls.Add(label3);
            Controls.Add(Number_Label);
            Controls.Add(Name_Lable);
            Controls.Add(Next_Button);
            Controls.Add(Reveal_Button);
            Controls.Add(groupBox1);
            Controls.Add(Open_List_Button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            AutoSliderGroup.ResumeLayout(false);
            AutoSliderGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TimeNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Open_List_Button;
        private GroupBox groupBox1;
        private CheckBox Random_Checkbox;
        private CheckBox AutoSlide_Checkbox;
        private CheckBox Switchitems_Checkbox;
        private CheckBox ShowAnswers_Checkbox;
        private Button EditButton;
        private NumericUpDown TimeNumber;
        private Label label1;
        private Label label2;
        private Button Reveal_Button;
        private Button Next_Button;
        private GroupBox AutoSliderGroup;
        private Label Name_Lable;
        private Label Number_Label;
        private System.Windows.Forms.Timer Timer;
        private Button Start_Button;
        private Label label3;
    }
}
