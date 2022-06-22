namespace CourseWorkApp
{
    partial class Report2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report2Form));
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.posBox = new System.Windows.Forms.TextBox();
            this.salBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeBox
            // 
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(134, 48);
            this.employeeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(350, 33);
            this.employeeBox.TabIndex = 0;
            this.employeeBox.SelectedIndexChanged += new System.EventHandler(this.employeeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee";
            // 
            // posBox
            // 
            this.posBox.Location = new System.Drawing.Point(110, 123);
            this.posBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.posBox.Name = "posBox";
            this.posBox.Size = new System.Drawing.Size(177, 31);
            this.posBox.TabIndex = 2;
            // 
            // salBox
            // 
            this.salBox.Location = new System.Drawing.Point(110, 170);
            this.salBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salBox.Name = "salBox";
            this.salBox.Size = new System.Drawing.Size(141, 31);
            this.salBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(17, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(22, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salary";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Wheat;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(383, 218);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 38);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Report2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 284);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salBox);
            this.Controls.Add(this.posBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Report2Form";
            this.Text = "Report2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox employeeBox;
        private Label label1;
        private TextBox posBox;
        private TextBox salBox;
        private Label label2;
        private Label label3;
        private Button exitButton;
    }
}