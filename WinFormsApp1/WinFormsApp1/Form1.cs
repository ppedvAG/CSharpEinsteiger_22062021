namespace WinFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.Button b = new System.Windows.Forms.Button();
            Oracle.ManagedDataAccess.Client.OracleCommand cm = new Oracle.ManagedDataAccess.Client.OracleCommand();
        }

    }
}
