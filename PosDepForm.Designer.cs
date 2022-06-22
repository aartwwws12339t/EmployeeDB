namespace CourseWorkApp
{
    partial class PosDepForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosDepForm));
            this.posList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.posAddButton = new System.Windows.Forms.Button();
            this.posNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vacationBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.posEditButton = new System.Windows.Forms.Button();
            this.depEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.abbBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.depNameBox = new System.Windows.Forms.TextBox();
            this.depAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.departmentList = new System.Windows.Forms.ListBox();
            this.depHeadBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // posList
            // 
            this.posList.FormattingEnabled = true;
            this.posList.ItemHeight = 25;
            this.posList.Location = new System.Drawing.Point(327, 48);
            this.posList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.posList.Name = "posList";
            this.posList.Size = new System.Drawing.Size(247, 129);
            this.posList.TabIndex = 0;
            this.posList.SelectedIndexChanged += new System.EventHandler(this.posList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Positions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // posAddButton
            // 
            this.posAddButton.BackColor = System.Drawing.Color.Wheat;
            this.posAddButton.FlatAppearance.BorderSize = 0;
            this.posAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.posAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.posAddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.posAddButton.Location = new System.Drawing.Point(327, 187);
            this.posAddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.posAddButton.Name = "posAddButton";
            this.posAddButton.Size = new System.Drawing.Size(114, 38);
            this.posAddButton.TabIndex = 2;
            this.posAddButton.Text = "Add";
            this.posAddButton.UseVisualStyleBackColor = false;
            this.posAddButton.Click += new System.EventHandler(this.posAddButton_Click);
            // 
            // posNameBox
            // 
            this.posNameBox.Location = new System.Drawing.Point(129, 49);
            this.posNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.posNameBox.Name = "posNameBox";
            this.posNameBox.Size = new System.Drawing.Size(190, 31);
            this.posNameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vacations";
            // 
            // vacationBox
            // 
            this.vacationBox.Location = new System.Drawing.Point(129, 87);
            this.vacationBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vacationBox.Name = "vacationBox";
            this.vacationBox.Size = new System.Drawing.Size(190, 31);
            this.vacationBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(129, 125);
            this.salaryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(190, 31);
            this.salaryBox.TabIndex = 7;
            // 
            // posEditButton
            // 
            this.posEditButton.BackColor = System.Drawing.Color.Wheat;
            this.posEditButton.FlatAppearance.BorderSize = 0;
            this.posEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.posEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.posEditButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.posEditButton.Location = new System.Drawing.Point(460, 187);
            this.posEditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.posEditButton.Name = "posEditButton";
            this.posEditButton.Size = new System.Drawing.Size(114, 38);
            this.posEditButton.TabIndex = 9;
            this.posEditButton.Text = "Edit ";
            this.posEditButton.UseVisualStyleBackColor = false;
            this.posEditButton.Click += new System.EventHandler(this.posEditButton_Click);
            // 
            // depEdit
            // 
            this.depEdit.BackColor = System.Drawing.Color.Wheat;
            this.depEdit.FlatAppearance.BorderSize = 0;
            this.depEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.depEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depEdit.Location = new System.Drawing.Point(453, 465);
            this.depEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depEdit.Name = "depEdit";
            this.depEdit.Size = new System.Drawing.Size(123, 38);
            this.depEdit.TabIndex = 19;
            this.depEdit.Text = "Edit ";
            this.depEdit.UseVisualStyleBackColor = false;
            this.depEdit.Click += new System.EventHandler(this.depEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 413);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Head Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Abbriviation";
            // 
            // abbBox
            // 
            this.abbBox.Location = new System.Drawing.Point(129, 366);
            this.abbBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.abbBox.Name = "abbBox";
            this.abbBox.Size = new System.Drawing.Size(190, 31);
            this.abbBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(18, 326);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // depNameBox
            // 
            this.depNameBox.Location = new System.Drawing.Point(129, 326);
            this.depNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depNameBox.Name = "depNameBox";
            this.depNameBox.Size = new System.Drawing.Size(190, 31);
            this.depNameBox.TabIndex = 13;
            // 
            // depAdd
            // 
            this.depAdd.BackColor = System.Drawing.Color.Wheat;
            this.depAdd.FlatAppearance.BorderSize = 0;
            this.depAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.depAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depAdd.Location = new System.Drawing.Point(327, 465);
            this.depAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depAdd.Name = "depAdd";
            this.depAdd.Size = new System.Drawing.Size(117, 38);
            this.depAdd.TabIndex = 12;
            this.depAdd.Text = "Add";
            this.depAdd.UseVisualStyleBackColor = false;
            this.depAdd.Click += new System.EventHandler(this.depAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(250, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Departments";
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.ItemHeight = 25;
            this.departmentList.Location = new System.Drawing.Point(329, 326);
            this.departmentList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(247, 129);
            this.departmentList.TabIndex = 10;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // depHeadBox
            // 
            this.depHeadBox.FormattingEnabled = true;
            this.depHeadBox.Location = new System.Drawing.Point(129, 409);
            this.depHeadBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depHeadBox.Name = "depHeadBox";
            this.depHeadBox.Size = new System.Drawing.Size(190, 33);
            this.depHeadBox.TabIndex = 20;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Linen;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(467, 576);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 44);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(215, 447);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(0, 25);
            this.amountLabel.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 447);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Amount of employees:";
            // 
            // PosDepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 653);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.depHeadBox);
            this.Controls.Add(this.depEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.abbBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.depNameBox);
            this.Controls.Add(this.depAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.departmentList);
            this.Controls.Add(this.posEditButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vacationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.posNameBox);
            this.Controls.Add(this.posAddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PosDepForm";
            this.Text = "Positions and Departments Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox posList;
        private Label label1;
        private Button posAddButton;
        private TextBox posNameBox;
        private Label label2;
        private Label label3;
        private TextBox vacationBox;
        private Label label4;
        private TextBox salaryBox;
        private Button posEditButton;
        private Button depEdit;
        private Label label5;
        private Label label6;
        private TextBox abbBox;
        private Label label7;
        private TextBox depNameBox;
        private Button depAdd;
        private Label label8;
        private ListBox departmentList;
        private ComboBox depHeadBox;
        private Button ExitButton;
        private Label amountLabel;
        private Label label9;
    }
}