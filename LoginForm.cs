using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CourseWorkApp
{
    public partial class LoginForm : Form
    {
        string _connectionString;
        private TransferContext _context;
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(string connectionString,out TransferContext context)
        {
            _connectionString = connectionString;
            InitializeComponent();
            _context = new TransferContext();
            context = _context;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DBconnect_Click(object sender, EventArgs e)
        {
            connectionLabel.Text = string.Empty;
            if (loginBox.Text.Length == 0)
            {
                connectionLabel.ForeColor = Color.Red;
                connectionLabel.Text = "Please enter Username";
                return;
            }
            if (pswdBox.Text.Length == 0)
            {
                connectionLabel.ForeColor = Color.Red;
                connectionLabel.Text = "Please enter Password";
                return;
            }

            connectionLabel.ForeColor = Color.Black;
            connectionLabel.Text = "Please wait trying to establish connection with database";



            string connectionString = String.Format(_connectionString, loginBox.Text,pswdBox.Text);
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDataContext>();
                optionsBuilder.UseSqlServer(connectionString);
                var context = new ApplicationDataContext(optionsBuilder.Options);
                context.Database.OpenConnection();
                _context.context = context;
                _context.username = loginBox.Text;
                connectionLabel.Text = "Connection Succesfull";
                this.Close();
            }catch (Exception ex)
            {
                connectionLabel.Text = "Connection Failed";
            }
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            connectionLabel.Text = string.Empty;
        }

        private void pswdBox_TextChanged(object sender, EventArgs e)
        {
            connectionLabel.Text = string.Empty;
        }

        private void loginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                this.ActiveControl = pswdBox;
            }
        }
    }
}