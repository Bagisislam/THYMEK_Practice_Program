namespace İnterface
{
    partial class İtemListPage
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
            Save_Button = new Button();
            İtem_save_and_appere_box = new GroupBox();
            dataGridView1 = new DataGridView();
            İtem_save_and_appere_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Save_Button
            // 
            Save_Button.Location = new Point(77, 57);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(213, 44);
            Save_Button.TabIndex = 2;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Button_Click;
            // 
            // İtem_save_and_appere_box
            // 
            İtem_save_and_appere_box.Controls.Add(Save_Button);
            İtem_save_and_appere_box.Location = new Point(203, 1113);
            İtem_save_and_appere_box.Name = "İtem_save_and_appere_box";
            İtem_save_and_appere_box.Size = new Size(366, 139);
            İtem_save_and_appere_box.TabIndex = 5;
            İtem_save_and_appere_box.TabStop = false;
            İtem_save_and_appere_box.Text = "Save";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(167, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(431, 1046);
            dataGridView1.TabIndex = 4;
            // 
            // İtemListPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1361);
            Controls.Add(İtem_save_and_appere_box);
            Controls.Add(dataGridView1);
            Name = "İtemListPage";
            Text = "İtemListPage";
            Load += İtemListPage_Load;
            İtem_save_and_appere_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Save_Button;
        private GroupBox İtem_save_and_appere_box;
        private DataGridView dataGridView1;
    }
}