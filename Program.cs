using System.Configuration;

namespace CourseWorkApp
{
    public class TransferContext
    {
        public ApplicationDataContext context { get; set; }
        public string username { get; set; }
    }
    public static class Program
    {

        [STAThread]
        static void Main()
        {
            string connectionString = "Data Source=DESKTOP-TFTG5CD\\SQLEXPRESS;Initial Catalog=Database_workers;User ID=\"{0}\";Password=\"{1}\"";
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(connectionString, out TransferContext context));
            if(context.context != null)
            {
                var logic = new Logic(context);
                Application.Run(new MainForm(logic));
            }
        }
    }
}