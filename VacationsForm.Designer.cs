namespace CourseWorkApp
{
    partial class VacationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacationsForm));
            this.vacationsList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.EditButton = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grantedLabel = new System.Windows.Forms.Label();
            this.usedLabel = new System.Windows.Forms.Label();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vacationsList
            // 
            this.vacationsList.FormattingEnabled = true;
            this.vacationsList.ItemHeight = 25;
            this.vacationsList.Location = new System.Drawing.Point(395, 34);
            this.vacationsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vacationsList.Name = "vacationsList";
            this.vacationsList.Size = new System.Drawing.Size(263, 329);
            this.vacationsList.TabIndex = 0;
            this.vacationsList.SelectedIndexChanged += new System.EventHandler(this.vacationsList_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Wheat;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(7, 7);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 38);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date";
            // 
            // startPicker
            // 
            this.startPicker.Location = new System.Drawing.Point(143, 34);
            this.startPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(244, 31);
            this.startPicker.TabIndex = 5;
            // 
            // endPicker
            // 
            this.endPicker.Location = new System.Drawing.Point(143, 102);
            this.endPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endPicker.Name = "endPicker";
            this.endPicker.Size = new System.Drawing.Size(244, 31);
            this.endPicker.TabIndex = 6;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Wheat;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.Location = new System.Drawing.Point(125, 7);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(107, 38);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.White;
            this.adminPanel.Controls.Add(this.AddButton);
            this.adminPanel.Controls.Add(this.EditButton);
            this.adminPanel.Location = new System.Drawing.Point(47, 199);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(240, 53);
            this.adminPanel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Days off used:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Days off granted:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // grantedLabel
            // 
            this.grantedLabel.AutoSize = true;
            this.grantedLabel.BackColor = System.Drawing.Color.Transparent;
            this.grantedLabel.Location = new System.Drawing.Point(222, 285);
            this.grantedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grantedLabel.Name = "grantedLabel";
            this.grantedLabel.Size = new System.Drawing.Size(0, 25);
            this.grantedLabel.TabIndex = 11;
            // 
            // usedLabel
            // 
            this.usedLabel.AutoSize = true;
            this.usedLabel.BackColor = System.Drawing.Color.Transparent;
            this.usedLabel.Location = new System.Drawing.Point(192, 319);
            this.usedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usedLabel.Name = "usedLabel";
            this.usedLabel.Size = new System.Drawing.Size(0, 25);
            this.usedLabel.TabIndex = 12;
            // 
            // VacationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 497);
            this.Controls.Add(this.usedLabel);
            this.Controls.Add(this.grantedLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.endPicker);
            this.Controls.Add(this.startPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vacationsList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VacationsForm";
            this.Text = "Vacations";
            this.adminPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox vacationsList;
        private Button AddButton;
        private Label label1;
        private Label label2;
        private DateTimePicker startPicker;
        private DateTimePicker endPicker;
        private Button EditButton;
        private Panel adminPanel;
        private Label label3;
        private Label label4;
        private Label grantedLabel;
        private Label usedLabel;
    }
}