namespace CourseWorkApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.employeesList = new System.Windows.Forms.ListBox();
            this.vacationButton = new System.Windows.Forms.Button();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.bossBox = new System.Windows.Forms.TextBox();
            this.positionBox = new System.Windows.Forms.ComboBox();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.pasportBox = new System.Windows.Forms.TextBox();
            this.birthplaceBox = new System.Windows.Forms.TextBox();
            this.addresBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.posdepButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.rep1Button = new System.Windows.Forms.Button();
            this.rep2Button = new System.Windows.Forms.Button();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesList
            // 
            this.employeesList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.employeesList.FormattingEnabled = true;
            this.employeesList.ItemHeight = 25;
            this.employeesList.Location = new System.Drawing.Point(42, 58);
            this.employeesList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(348, 529);
            this.employeesList.TabIndex = 0;
            this.employeesList.SelectedIndexChanged += new System.EventHandler(this.employeesList_SelectedIndexChanged);
            // 
            // vacationButton
            // 
            this.vacationButton.BackColor = System.Drawing.Color.Wheat;
            this.vacationButton.FlatAppearance.BorderSize = 0;
            this.vacationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.vacationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vacationButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vacationButton.Location = new System.Drawing.Point(1060, 351);
            this.vacationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vacationButton.Name = "vacationButton";
            this.vacationButton.Size = new System.Drawing.Size(240, 38);
            this.vacationButton.TabIndex = 85;
            this.vacationButton.Text = "Vacations";
            this.vacationButton.UseVisualStyleBackColor = false;
            this.vacationButton.Click += new System.EventHandler(this.vacationButton_Click);
            // 
            // departmentBox
            // 
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(627, 351);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(382, 33);
            this.departmentBox.TabIndex = 84;
            // 
            // bossBox
            // 
            this.bossBox.Enabled = false;
            this.bossBox.Location = new System.Drawing.Point(627, 425);
            this.bossBox.Name = "bossBox";
            this.bossBox.Size = new System.Drawing.Size(382, 31);
            this.bossBox.TabIndex = 83;
            // 
            // positionBox
            // 
            this.positionBox.FormattingEnabled = true;
            this.positionBox.Location = new System.Drawing.Point(627, 306);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(382, 33);
            this.positionBox.TabIndex = 82;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(627, 155);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(382, 31);
            this.birthdayPicker.TabIndex = 81;
            // 
            // salaryBox
            // 
            this.salaryBox.Enabled = false;
            this.salaryBox.Location = new System.Drawing.Point(627, 467);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(382, 31);
            this.salaryBox.TabIndex = 80;
            // 
            // pasportBox
            // 
            this.pasportBox.Location = new System.Drawing.Point(627, 114);
            this.pasportBox.Name = "pasportBox";
            this.pasportBox.Size = new System.Drawing.Size(382, 31);
            this.pasportBox.TabIndex = 79;
            // 
            // birthplaceBox
            // 
            this.birthplaceBox.Location = new System.Drawing.Point(627, 199);
            this.birthplaceBox.Name = "birthplaceBox";
            this.birthplaceBox.Size = new System.Drawing.Size(382, 31);
            this.birthplaceBox.TabIndex = 78;
            // 
            // addresBox
            // 
            this.addresBox.Location = new System.Drawing.Point(627, 261);
            this.addresBox.Name = "addresBox";
            this.addresBox.Size = new System.Drawing.Size(382, 31);
            this.addresBox.TabIndex = 77;
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(1030, 58);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(180, 31);
            this.fnameBox.TabIndex = 76;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(829, 58);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(180, 31);
            this.surnameBox.TabIndex = 75;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(627, 58);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(180, 31);
            this.nameBox.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(482, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 28);
            this.label12.TabIndex = 73;
            this.label12.Text = "Boss";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(483, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 28);
            this.label11.TabIndex = 72;
            this.label11.Text = "Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(481, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 28);
            this.label10.TabIndex = 71;
            this.label10.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(482, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 28);
            this.label9.TabIndex = 70;
            this.label9.Text = "Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(479, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 28);
            this.label8.TabIndex = 69;
            this.label8.Text = "Passport data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(478, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 28);
            this.label6.TabIndex = 68;
            this.label6.Text = "Birth place";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(479, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 67;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(480, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 66;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1030, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 65;
            this.label3.Text = "Fathers name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(827, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 64;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(630, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 63;
            this.label1.Text = "Name";
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.Wheat;
            this.disconnectButton.FlatAppearance.BorderSize = 0;
            this.disconnectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.disconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.disconnectButton.Location = new System.Drawing.Point(1221, 537);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(79, 53);
            this.disconnectButton.TabIndex = 86;
            this.disconnectButton.Text = "Exit";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.Transparent;
            this.adminPanel.Controls.Add(this.posdepButton);
            this.adminPanel.Controls.Add(this.editButton);
            this.adminPanel.Controls.Add(this.addEmployeeButton);
            this.adminPanel.Location = new System.Drawing.Point(1030, 114);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(270, 140);
            this.adminPanel.TabIndex = 87;
            // 
            // posdepButton
            // 
            this.posdepButton.BackColor = System.Drawing.Color.BurlyWood;
            this.posdepButton.FlatAppearance.BorderSize = 0;
            this.posdepButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.posdepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posdepButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.posdepButton.Location = new System.Drawing.Point(7, 95);
            this.posdepButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.posdepButton.Name = "posdepButton";
            this.posdepButton.Size = new System.Drawing.Size(258, 38);
            this.posdepButton.TabIndex = 5;
            this.posdepButton.Text = "Positions and Departments";
            this.posdepButton.UseVisualStyleBackColor = false;
            this.posdepButton.Click += new System.EventHandler(this.posdepButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.BurlyWood;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(7, 50);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(257, 38);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit data";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.BurlyWood;
            this.addEmployeeButton.FlatAppearance.BorderSize = 0;
            this.addEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addEmployeeButton.Location = new System.Drawing.Point(7, 5);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(257, 38);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add new Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // rep1Button
            // 
            this.rep1Button.BackColor = System.Drawing.Color.Wheat;
            this.rep1Button.FlatAppearance.BorderSize = 0;
            this.rep1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.rep1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rep1Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rep1Button.Location = new System.Drawing.Point(1060, 454);
            this.rep1Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rep1Button.Name = "rep1Button";
            this.rep1Button.Size = new System.Drawing.Size(240, 47);
            this.rep1Button.TabIndex = 88;
            this.rep1Button.Text = "Department workers list";
            this.rep1Button.UseVisualStyleBackColor = false;
            this.rep1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // rep2Button
            // 
            this.rep2Button.BackColor = System.Drawing.Color.Wheat;
            this.rep2Button.FlatAppearance.BorderSize = 0;
            this.rep2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.rep2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rep2Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rep2Button.Location = new System.Drawing.Point(1060, 397);
            this.rep2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rep2Button.Name = "rep2Button";
            this.rep2Button.Size = new System.Drawing.Size(240, 47);
            this.rep2Button.TabIndex = 89;
            this.rep2Button.Text = "Employment Details";
            this.rep2Button.UseVisualStyleBackColor = false;
            this.rep2Button.Click += new System.EventHandler(this.rep2Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 636);
            this.Controls.Add(this.rep2Button);
            this.Controls.Add(this.rep1Button);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.vacationButton);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.bossBox);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.pasportBox);
            this.Controls.Add(this.birthplaceBox);
            this.Controls.Add(this.addresBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.adminPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox employeesList;
        private Button vacationButton;
        private ComboBox departmentBox;
        private TextBox bossBox;
        private ComboBox positionBox;
        private DateTimePicker birthdayPicker;
        private TextBox salaryBox;
        private TextBox pasportBox;
        private TextBox birthplaceBox;
        private TextBox addresBox;
        private TextBox fnameBox;
        private TextBox surnameBox;
        private TextBox nameBox;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button disconnectButton;
        private Panel adminPanel;
        private Button editButton;
        private Button addEmployeeButton;
        private Button posdepButton;
        private Button rep1Button;
        private Button rep2Button;
    }
}