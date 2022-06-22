namespace CourseWorkApp
{
    partial class Report1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report1Form));
            this.employeeList = new System.Windows.Forms.ListBox();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeList
            // 
            this.employeeList.FormattingEnabled = true;
            this.employeeList.ItemHeight = 25;
            this.employeeList.Location = new System.Drawing.Point(69, 157);
            this.employeeList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(386, 354);
            this.employeeList.TabIndex = 0;
            // 
            // departmentBox
            // 
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(181, 85);
            this.departmentBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(297, 33);
            this.departmentBox.TabIndex = 1;
            this.departmentBox.SelectedIndexChanged += new System.EventHandler(this.departmentBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(41, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.Color.Transparent;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.amountLabel.Location = new System.Drawing.Point(17, 605);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(0, 25);
            this.amountLabel.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Wheat;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(327, 545);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 42);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Report1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 666);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.employeeList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Report1Form";
            this.Text = "Report1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox employeeList;
        private ComboBox departmentBox;
        private Label label1;
        private Label amountLabel;
        private Button exitButton;
    }
}