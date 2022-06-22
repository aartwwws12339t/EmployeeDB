namespace CourseWorkApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginBox = new System.Windows.Forms.TextBox();
            this.pswdBox = new System.Windows.Forms.TextBox();
            this.DBconnect = new System.Windows.Forms.Button();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginBox.Location = new System.Drawing.Point(347, 260);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(328, 31);
            this.loginBox.TabIndex = 0;
            this.loginBox.TextChanged += new System.EventHandler(this.loginBox_TextChanged);
            this.loginBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginBox_KeyDown);
            // 
            // pswdBox
            // 
            this.pswdBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pswdBox.Location = new System.Drawing.Point(347, 342);
            this.pswdBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pswdBox.Name = "pswdBox";
            this.pswdBox.Size = new System.Drawing.Size(328, 31);
            this.pswdBox.TabIndex = 1;
            this.pswdBox.TextChanged += new System.EventHandler(this.pswdBox_TextChanged);
            // 
            // DBconnect
            // 
            this.DBconnect.BackColor = System.Drawing.Color.Wheat;
            this.DBconnect.FlatAppearance.BorderSize = 0;
            this.DBconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.DBconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.DBconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DBconnect.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DBconnect.ForeColor = System.Drawing.Color.Black;
            this.DBconnect.Location = new System.Drawing.Point(447, 415);
            this.DBconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DBconnect.Name = "DBconnect";
            this.DBconnect.Size = new System.Drawing.Size(132, 36);
            this.DBconnect.TabIndex = 5;
            this.DBconnect.Text = "Connect";
            this.DBconnect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DBconnect.UseVisualStyleBackColor = false;
            this.DBconnect.Click += new System.EventHandler(this.DBconnect_Click);
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.BackColor = System.Drawing.Color.Thistle;
            this.connectionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectionLabel.ForeColor = System.Drawing.Color.White;
            this.connectionLabel.Location = new System.Drawing.Point(394, 535);
            this.connectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(0, 32);
            this.connectionLabel.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 690);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.DBconnect);
            this.Controls.Add(this.pswdBox);
            this.Controls.Add(this.loginBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox loginBox;
        private TextBox pswdBox;
        private Button DBconnect;
        private Label connectionLabel;
    }
}